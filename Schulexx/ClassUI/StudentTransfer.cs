using Schulexx.ErrorHandling;
using Schulexx.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Schulexx.StudentsUI
{
    public partial class StudentTransfer : Form
    {

        #region Members

        private study_term_settings SETTINGS;
        private List<ClassDetails> CLASSLIST = new List<ClassDetails>();
        private List<ST_StudentDetails> ALL_OLD_STUDENT_LIST = new List<ST_StudentDetails>();

        private List<ST_StudentDetails> ORG_OLD_STUDENT_LIST = new List<ST_StudentDetails>();
        private List<ST_StudentDetails> ORG_P_NEW_STUDENT_LIST = new List<ST_StudentDetails>();
        private List<ST_StudentDetails> ORG_F_NEW_STUDENT_LIST = new List<ST_StudentDetails>();

        private BindingSource BS_OLD_STUDENTS = new BindingSource();
        private BindingSource BS_P_NEW_STUDENTS = new BindingSource();
        private BindingSource BS_F_NEW_STUDENTS = new BindingSource();
        private BindingList<ST_StudentDetails> BL_OLD_STUDENTS = new BindingList<ST_StudentDetails>();
        private BindingList<ST_StudentDetails> BL_P_NEW_STUDENTS = new BindingList<ST_StudentDetails>();
        private BindingList<ST_StudentDetails> BL_F_NEW_STUDENTS = new BindingList<ST_StudentDetails>();

        int OLD_CLASS_ID;
        int NEW_CLASS_ID;
        short CUR_YEAR;
        int LAST_YEAR;

        int LAST_CLASS_ID;

        #endregion

        #region Form Events

        public StudentTransfer()
        {
            InitializeComponent();
            lblYear.Text = "";
            butPromoSelectedTrn.Enabled = butPromoAllTrn.Enabled = butPromoSelectedTrnBk.Enabled = butPromoAllTrnBack.Enabled = false;
            butFailSelectedTrn.Enabled = butFailAllTrn.Enabled = butFailSelectedTrnBk.Enabled = butFailAllTrnBack.Enabled = false;
            dgvFailedStudents.AutoGenerateColumns = dgvPromoStudents.AutoGenerateColumns = dgvOldStudents.AutoGenerateColumns = false;
        }

        private void StudentTransfer_Load(object sender, EventArgs e)
        {
            BS_OLD_STUDENTS.DataSource = BL_OLD_STUDENTS;
            BS_P_NEW_STUDENTS.DataSource = BL_P_NEW_STUDENTS;
            BS_F_NEW_STUDENTS.DataSource = BL_F_NEW_STUDENTS;

            dgvOldStudents.DataSource = BS_OLD_STUDENTS;
            dgvPromoStudents.DataSource = BS_P_NEW_STUDENTS;
            dgvFailedStudents.DataSource = BS_F_NEW_STUDENTS;
        }

        private void StudentTransfer_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        #endregion

        #region Data Load

        private void LoadData()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                butSave.Enabled = false;
                butLoad.Enabled = false;
                using (var db = new schulex_dbEntities())
                {
                    SETTINGS = db.study_term_settings.FirstOrDefault();
                    if (SETTINGS == null)
                    {
                        ErrorHelper.ShowError(this, "Current Academic Year not found");
                        return;
                    }
                    CUR_YEAR = SETTINGS.academic_year;
                    LAST_YEAR = CUR_YEAR - 1;
                    lblYear.Text = LAST_YEAR.ToString();
                    LAST_CLASS_ID = 0;
                    CLASSLIST = db.classes.Select(x => new ClassDetails
                    {
                        CName = x.cname,
                        id = x.class_id,
                        position = x.class_position,
                    }).OrderBy(x => x.position).ToList();
                    if (CLASSLIST.Count <= 1)
                    {
                        ErrorHelper.ShowError(this, "Class Details not found");
                        return;
                    }
                    LAST_CLASS_ID = CLASSLIST.Last().id;
                    List<KeyValuePair<int, string>> filterClassList = CLASSLIST//.Take(CLASSLIST.Count - 1)
                        .Select(x => new KeyValuePair<int, string>(x.id, x.CName)).ToList();

                    cboClass.DataSource = filterClassList;
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.ShowError(this, ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LoadStudents(bool showMsg)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                butSave.Enabled = false;
                butPromoSelectedTrn.Enabled = butPromoAllTrn.Enabled = butPromoSelectedTrnBk.Enabled = butPromoAllTrnBack.Enabled = false;
                butFailSelectedTrn.Enabled = butFailAllTrn.Enabled = butFailSelectedTrnBk.Enabled = butFailAllTrnBack.Enabled = false;

                BL_OLD_STUDENTS = new BindingList<ST_StudentDetails>();
                BL_P_NEW_STUDENTS = new BindingList<ST_StudentDetails>();
                BL_F_NEW_STUDENTS = new BindingList<ST_StudentDetails>();

                using (var db = new schulex_dbEntities())
                {
                    ALL_OLD_STUDENT_LIST = db.class_enrollments.Where(x => x.class_id == OLD_CLASS_ID && x.year == LAST_YEAR).
                          Select(x => new ST_StudentDetails
                          {
                              class_id = x.class_id,
                              fname = x.student.fname,
                              lname = x.student.lname,
                              reg_number = x.student.reg_number,
                              year = x.year,
                              //stream_id = x.stream_id,
                              student_id = x.student_id,
                              hasSubjects = false
                          }).ToList();
                    if (ALL_OLD_STUDENT_LIST.Count == 0)
                    {
                        ErrorHelper.ShowWarning(this, "No Students Found");
                    }
                    else
                    {
                        var oldStudentIds = ALL_OLD_STUDENT_LIST.Select(x => x.student_id).ToList();
                        ORG_P_NEW_STUDENT_LIST = db.class_enrollments.Where(x => x.class_id == NEW_CLASS_ID && x.year == CUR_YEAR && oldStudentIds.Contains(x.student_id)).
                             Select(x => new ST_StudentDetails
                             {
                                 class_id = x.class_id,
                                 fname = x.student.fname,
                                 lname = x.student.lname,
                                 reg_number = x.student.reg_number,
                                 year = x.year,
                                 //stream_id = x.stream_id,
                                 student_id = x.student_id,
                                 hasSubjects = x.@class.level.Abbrev == "A" ?
                                    x.student.subject_enrolments_alevel.Any(y => y.student_id == x.student_id && y.year == x.year)
                                    : x.student.subject_enrolments_olevel.Any(y => y.student_id == x.student_id && y.year == x.year)
                             }).OrderBy(x => x.lname).ThenBy(x => x.fname).ToList();

                        ORG_F_NEW_STUDENT_LIST = db.class_enrollments.Where(x => x.class_id == OLD_CLASS_ID && x.year == CUR_YEAR && oldStudentIds.Contains(x.student_id)).
                             Select(x => new ST_StudentDetails
                             {
                                 class_id = x.class_id,
                                 fname = x.student.fname,
                                 lname = x.student.lname,
                                 reg_number = x.student.reg_number,
                                 year = x.year,
                                 //stream_id = x.stream_id,
                                 student_id = x.student_id,
                                 hasSubjects = x.@class.level.Abbrev == "A" ?
                                    x.student.subject_enrolments_alevel.Any(y => y.student_id == x.student_id && y.year == x.year)
                                    : x.student.subject_enrolments_olevel.Any(y => y.student_id == x.student_id && y.year == x.year)
                             }).OrderBy(x => x.lname).ThenBy(x => x.fname).ToList();

                        var TransferredID = ORG_P_NEW_STUDENT_LIST.Select(x => x.student_id)
                            .Union(ORG_F_NEW_STUDENT_LIST.Select(x => x.student_id))
                            .ToList();
                        ORG_OLD_STUDENT_LIST = ALL_OLD_STUDENT_LIST.Where(x => !TransferredID.Contains(x.student_id))
                            .OrderBy(x => x.lname).ThenBy(x => x.fname).ToList();

                        BL_OLD_STUDENTS = new BindingList<ST_StudentDetails>(ORG_OLD_STUDENT_LIST.Select(x => x.Clone()).ToList());
                        BL_P_NEW_STUDENTS = new BindingList<ST_StudentDetails>(ORG_P_NEW_STUDENT_LIST.Select(x => x.Clone()).ToList());
                        BL_F_NEW_STUDENTS = new BindingList<ST_StudentDetails>(ORG_F_NEW_STUDENT_LIST.Select(x => x.Clone()).ToList());
                        butSave.Enabled = true;
                    }
                    BS_OLD_STUDENTS.DataSource = BL_OLD_STUDENTS;
                    BS_P_NEW_STUDENTS.DataSource = BL_P_NEW_STUDENTS;
                    BS_F_NEW_STUDENTS.DataSource = BL_F_NEW_STUDENTS;
                    ManageButtons();
                    if (showMsg && ALL_OLD_STUDENT_LIST.Count > 0 && BL_OLD_STUDENTS.Count == 0)
                    {
                        ErrorHelper.ShowInfo(this, "All Students Transferred");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.ShowError(this, ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Combo Handlers

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selClassId = (int)cboClass.SelectedValue;
            OLD_CLASS_ID = NEW_CLASS_ID = 0;
            var selClass = CLASSLIST.FirstOrDefault(x => x.id == selClassId);
            if (selClass == null)
            {
                Text = "Transfer Students";
                butLoad.Enabled = false;
                gbOldStudents.Text = "Students to be Transferred";
                gbPromoStudents.Text = "Students Transferred";
            }
            else
            {
                bool isLatClass = LAST_CLASS_ID == selClass.id;
                var nextClass = CLASSLIST.FirstOrDefault(x => x.position == selClass.position + 1);
                if (isLatClass)
                {
                    nextClass = selClass;
                }
                if (nextClass == null)
                {
                    Text = "Transfer Students";
                    butLoad.Enabled = false;
                    gbOldStudents.Text = "Students to be Transferred";
                    gbPromoStudents.Text = "Students Transferred";
                    gbFailedStudents.Text = "Students Transferred";
                }
                else
                {
                    OLD_CLASS_ID = selClass.id;
                    NEW_CLASS_ID = nextClass.id;
                    Text = string.Format("Transfer Students from Class {0} of Year {1}", selClass.CName, LAST_YEAR);
                    butLoad.Enabled = true;
                    gbOldStudents.Text = string.Format("Students to be Transferred from Class {0} of Year {1}", selClass.CName, LAST_YEAR);
                    gbPromoStudents.Text = string.Format("Promoted Students Transferred to Class {0} of Year {1}", nextClass.CName, CUR_YEAR);
                    gbFailedStudents.Text = string.Format("Unsucessful Students Transferred to Class {0} of Year {1}", selClass.CName, CUR_YEAR);
                    gbPromoStudents.Visible = !isLatClass;
                    if (isLatClass)
                    {
                        tlpMain.SetRow(gbFailedStudents, 1);
                        tlpMain.SetRowSpan(gbFailedStudents, 2);
                    }
                    else
                    {
                        tlpMain.SetRow(gbFailedStudents, 2);
                        tlpMain.SetRowSpan(gbFailedStudents, 1);
                    }
                }
            }
            BL_F_NEW_STUDENTS.Clear();
            BL_P_NEW_STUDENTS.Clear();
            BL_OLD_STUDENTS.Clear();
            butPromoAllTrn.Enabled = butPromoAllTrnBack.Enabled = butSave.Enabled = false;
            butFailAllTrn.Enabled = butFailAllTrnBack.Enabled = false;
        }

        #endregion

        #region GridView Events

        private void dgvOldStudents_SelectionChanged(object sender, EventArgs e)
        {
            butPromoSelectedTrn.Enabled = dgvOldStudents.SelectedRows.Count > 0;
            butFailSelectedTrn.Enabled = dgvOldStudents.SelectedRows.Count > 0;
        }

        private void dgvPromoStudents_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            BindGridView(dgvPromoStudents.Rows);
        }

        private void dgvPromoStudents_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPromoStudents.SelectedRows)
            {
                ST_StudentDetails selStudent = row.DataBoundItem as ST_StudentDetails;
                if (selStudent != null && !selStudent.hasSubjects)
                {
                    butPromoSelectedTrnBk.Enabled = true;
                    return;
                }
            }
            butPromoSelectedTrnBk.Enabled = false;
        }

        private void dgvFailedStudents_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            BindGridView(dgvFailedStudents.Rows);
        }

        private void dgvFailedStudents_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvFailedStudents.SelectedRows)
            {
                ST_StudentDetails selStudent = row.DataBoundItem as ST_StudentDetails;
                if (selStudent != null && !selStudent.hasSubjects)
                {
                    butFailSelectedTrnBk.Enabled = true;
                    return;
                }
            }
            butFailSelectedTrnBk.Enabled = false;
        }

        #endregion

        #region Button Handlers

        private void butLoad_Click(object sender, EventArgs e)
        {
            LoadStudents(true);
        }

        private void butPromoSelectedTrn_Click(object sender, EventArgs e)
        {
            List<ST_StudentDetails> selList = (from DataGridViewRow row in dgvOldStudents.SelectedRows
                                               orderby row.Index
                                               select row.DataBoundItem as ST_StudentDetails).ToList();
            MoveForwardStudents(selList, true);
        }

        private void butPromoAllTrn_Click(object sender, EventArgs e)
        {
            MoveForwardAllStudents(BL_OLD_STUDENTS, true);
        }

        private void butPromoTrnBk_Click(object sender, EventArgs e)
        {
            List<ST_StudentDetails> selList = (from DataGridViewRow row in dgvPromoStudents.SelectedRows
                                               orderby row.Index
                                               select row.DataBoundItem as ST_StudentDetails).ToList();
            MoveBackStudents(selList, true);
        }

        private void butPromoAllTrnBack_Click(object sender, EventArgs e)
        {
            var FilterList = BL_P_NEW_STUDENTS.Where(x => !x.hasSubjects);
            MoveBackAllStudents(FilterList, true);
        }

        private void butFailSelectedTrn_Click(object sender, EventArgs e)
        {
            List<ST_StudentDetails> selList = (from DataGridViewRow row in dgvOldStudents.SelectedRows
                                               orderby row.Index
                                               select row.DataBoundItem as ST_StudentDetails).ToList();
            MoveForwardStudents(selList, false);
        }

        private void butFailAllTrn_Click(object sender, EventArgs e)
        {
            MoveForwardAllStudents(BL_OLD_STUDENTS, false);
        }

        private void butFailSelectedTrnBk_Click(object sender, EventArgs e)
        {
            List<ST_StudentDetails> selList = (from DataGridViewRow row in dgvFailedStudents.SelectedRows
                                               orderby row.Index
                                               select row.DataBoundItem as ST_StudentDetails).ToList();
            MoveBackStudents(selList, false);
        }

        private void butFailAllTrnBack_Click(object sender, EventArgs e)
        {
            var FilterList = BL_F_NEW_STUDENTS.Where(x => !x.hasSubjects);
            MoveBackAllStudents(FilterList, false);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            var addPStudentIds = BL_P_NEW_STUDENTS.Select(x => x.student_id)
                .Except(ORG_P_NEW_STUDENT_LIST.Select(x => x.student_id)).ToList();
            var addFStudentIds = BL_F_NEW_STUDENTS.Select(x => x.student_id)
                .Except(ORG_F_NEW_STUDENT_LIST.Select(x => x.student_id)).ToList();
            var delPStudentIds = ORG_P_NEW_STUDENT_LIST.Select(x => x.student_id)
                .Except(BL_P_NEW_STUDENTS.Select(x => x.student_id)).ToList();
            var delFStudentIds = ORG_F_NEW_STUDENT_LIST.Select(x => x.student_id)
                .Except(BL_F_NEW_STUDENTS.Select(x => x.student_id)).ToList();

            if (delPStudentIds.Count + addPStudentIds.Count + delFStudentIds.Count + addFStudentIds.Count == 0)
            {
                ErrorHelper.ShowInfo(this, "You have not made any changes. Nothing to save.");
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                using (var db = new schulex_dbEntities())
                {

                    //Delete Passed Students
                    var delClassEnrolList = db.class_enrollments.Where(x => delPStudentIds.Contains(x.student_id) && x.year == CUR_YEAR && x.class_id == NEW_CLASS_ID).ToList();
                    foreach (var delClassEnrol in delClassEnrolList)
                    {
                        db.class_enrollments.Remove(delClassEnrol);
                    }
                    //Delete Failed Students
                    delClassEnrolList = db.class_enrollments.Where(x => delFStudentIds.Contains(x.student_id) && x.year == CUR_YEAR && x.class_id == OLD_CLASS_ID).ToList();
                    foreach (var delClassEnrol in delClassEnrolList)
                    {
                        db.class_enrollments.Remove(delClassEnrol);
                    }
                    
                    //Add Passed Students
                    foreach (var addClassEnrol in ALL_OLD_STUDENT_LIST.Where(x => addPStudentIds.Contains(x.student_id)))
                    {
                        db.class_enrollments.Add(new class_enrollments
                        {
                            student_id = addClassEnrol.student_id,
                            class_id = NEW_CLASS_ID,
                            year = CUR_YEAR,
                            //stream_id = addClassEnrol.stream_id
                        });
                    }
                    //Add Failed Students
                    foreach (var addClassEnrol in ALL_OLD_STUDENT_LIST.Where(x => addFStudentIds.Contains(x.student_id)))
                    {
                        db.class_enrollments.Add(new class_enrollments
                        {
                            student_id = addClassEnrol.student_id,
                            class_id = OLD_CLASS_ID,
                            year = CUR_YEAR,
                            //stream_id = addClassEnrol.stream_id
                        });
                    }
                    db.SaveChanges();
                }
                LoadStudents(false);
                ErrorHelper.ShowSuccess(this, "Transferred Students.");
            }
            catch (Exception ex)
            {
                ErrorHelper.ShowError(this, ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Utility Methods

        private void ManageButtons()
        {
            butPromoAllTrn.Enabled = butFailAllTrn.Enabled = BL_OLD_STUDENTS.Count > 0;
            butPromoAllTrnBack.Enabled = BL_P_NEW_STUDENTS.Count(x => !x.hasSubjects) > 0;
            butFailAllTrnBack.Enabled = BL_F_NEW_STUDENTS.Count(x => !x.hasSubjects) > 0;
        }

        private void BindGridView(DataGridViewRowCollection rows)
        {
            foreach (DataGridViewRow row in rows)
            {
                ST_StudentDetails selStudent = row.DataBoundItem as ST_StudentDetails;
                if (selStudent != null)
                {
                    if (selStudent.year == CUR_YEAR)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                    if (selStudent.hasSubjects)
                    {
                        row.ReadOnly = true;
                        row.DefaultCellStyle.ForeColor = Color.Brown;
                        row.DefaultCellStyle.Font = new Font(new FontFamily("Century Gothic"), 10, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
                    }
                }
            }
        }

        private void ScrollGridViews(bool IsOld, bool IsPromoted)
        {
            if (IsOld)
            {
                dgvOldStudents.FirstDisplayedScrollingRowIndex = dgvOldStudents.Rows.Count - 1;
            }
            else
            {
                if (IsPromoted)
                {
                    dgvPromoStudents.FirstDisplayedScrollingRowIndex = dgvPromoStudents.Rows.Count - 1;
                }
                else
                {
                    dgvFailedStudents.FirstDisplayedScrollingRowIndex = dgvFailedStudents.Rows.Count - 1;
                }
            }
        }

        private void MoveForwardStudents(List<ST_StudentDetails> selList, bool IsPromoted)
        {
            foreach (var selStudent in selList)
            {
                if (selStudent != null)
                {
                    BL_OLD_STUDENTS.Remove(selStudent);
                    if (IsPromoted)
                    {
                        BL_P_NEW_STUDENTS.Add(selStudent.Clone());
                    }
                    else
                    {
                        BL_F_NEW_STUDENTS.Add(selStudent.Clone());
                    }
                }
            }

            ScrollGridViews(false, IsPromoted);
            ManageButtons();
        }

        private void MoveForwardAllStudents(BindingList<ST_StudentDetails> Students, bool IsPromoted)
        {
            while (Students.Count > 0)
            {
                var selStudent = Students.First();
                BL_OLD_STUDENTS.Remove(selStudent);
                if (IsPromoted)
                {
                    BL_P_NEW_STUDENTS.Add(selStudent.Clone());
                }
                else
                {
                    BL_F_NEW_STUDENTS.Add(selStudent.Clone());
                }
            }
            ScrollGridViews(false, IsPromoted);
            ManageButtons();
        }

        private void MoveBackStudents(List<ST_StudentDetails> selList, bool IsPromoted)
        {
            foreach (var selStudent in selList)
            {
                if (selStudent != null && !selStudent.hasSubjects)
                {
                    if (IsPromoted)
                    {
                        BL_P_NEW_STUDENTS.Remove(selStudent);
                    }
                    else
                    {
                        BL_F_NEW_STUDENTS.Remove(selStudent);
                    }
                    BL_OLD_STUDENTS.Add(selStudent);
                }
            }
            ScrollGridViews(true, IsPromoted);
            ManageButtons();
        }

        private void MoveBackAllStudents(IEnumerable<ST_StudentDetails> FilterList, bool IsPromoted)
        {
            while (FilterList.Count() > 0)
            {
                var selStudent = FilterList.First();
                if (IsPromoted)
                {
                    BL_P_NEW_STUDENTS.Remove(selStudent);
                }
                else
                {
                    BL_F_NEW_STUDENTS.Remove(selStudent);
                }
                BL_OLD_STUDENTS.Add(selStudent.Clone());
            }
            ScrollGridViews(true, IsPromoted);
            ManageButtons();
        }

        #endregion

        #region Nested Classes

        internal class ClassDetails
        {
            public int id { get; set; }
            public string CName { get; set; }
            public int position;
        }

        internal class ST_StudentDetails
        {
            public string reg_number { get; internal set; }
            public int student_id { get; internal set; }
            public string fname { get; internal set; }
            public string lname { get; internal set; }
            public int class_id { get; internal set; }
            public int year { get; internal set; }
            public int stream_id { get; internal set; }
            public bool hasSubjects { get; set; }

            internal ST_StudentDetails Clone()
            {
                return new ST_StudentDetails
                {
                    reg_number = reg_number,
                    stream_id = stream_id,
                    class_id = class_id,
                    fname = fname,
                    hasSubjects = hasSubjects,
                    lname = lname,
                    student_id = student_id,
                    year = year
                };
            }
        }

        #endregion

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
