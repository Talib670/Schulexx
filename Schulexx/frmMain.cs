using Schulexx.AlertUI;
using Schulexx.AttendanceUI;
using Schulexx.CommonUI;
using Schulexx.ConfigureUI;
using Schulexx.Configure;
using Schulexx.Controls;
using Schulexx.ExamUI;
using Schulexx.Forms;
using Schulexx.LibraryUI;
using Schulexx.My_Account;
using Schulexx.ParentsUI;
using Schulexx.Reports;
using Schulexx.Reports.Academic;
using Schulexx.Reports.Fees;
using Schulexx.School_Fees;
using Schulexx.StaffUI;
using Schulexx.StudentsUI;
using Schulexx.Utility;
using Schulexx.ToolsUI.BulkImportUIs;
using Schulexx.ClassUI;
using Schulexx.ExtrasUI.SMS;
using Schulexx.ExtrasUI.StudLeadershipUI;
using Schulexx.ExtrasUI.DormMgtUI;
using Schulexx.ExtrasUI.DisciplineUI;
using Schulexx.ExamUI.ExternalExamsUI;
using Schulexx.Model;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Schulexx
{
    public partial class frmMain : Form
    {
        string SchName, moto, SchAdd, pNumber;
        byte[] school_logo;
        public frmMain(List<string> access_settings)
        {
            InitializeComponent();
            customDesign();
            if (!AppHelper.IsSuperAdmin())
            {
                AccessControl(access_settings);
            }
        }

        #region Access Control

        int i = 1;
        int j = 1;

        class tagCls
        {
            public int? pid;
            public int id;
        }

        private void AccessControl(List<string> access_settings)
        {
            List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem toolItem in menuStrip1.Items)
            {
                if (toolItem.Text == "My Account")
                    continue;
                i = j * 100;
                toolItem.Tag = new tagCls() { pid = null, id = i++ };
                allItems.Add(toolItem);
                if (toolItem.HasDropDownItems)
                {
                    //add sub items
                    allItems.AddRange(GetItems(toolItem));
                }
                j++;
            }
            allItems.ForEach(z => z.Visible = false);
            foreach (var setting in access_settings)
            {
                var menu = allItems.FirstOrDefault(x => x.Name == setting);
                if (menu != null)
                {
                    menu.Visible = true;
                }

            }
            // If menu struture changes, call this function to generate insert SQL
            //CreateMenuMasterDataInsertSQL(allItems);

        }

        private void CreateMenuMasterDataInsertSQL(List<ToolStripMenuItem> allItems)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in allItems)
            {
                tagCls tag = item.Tag as tagCls;
                int fact = (tag.id / 100) * 100 - 1;
                if (tag.pid.HasValue)
                {
                    sb.AppendFormat("INSERT INTO menu_master (menu_id, parent_menu_id, display_name, menu_name, disp_order) VALUES ({0}, {1}, '{2}', '{3}', {4});" + Environment.NewLine,
                        tag.id, tag.pid, item.Text, item.Name, tag.id - fact);
                }
                else
                {
                    sb.AppendFormat("INSERT INTO menu_master (menu_id, display_name, menu_name, disp_order) VALUES ({0}, '{1}', '{2}', {3});" + Environment.NewLine,
                        tag.id, item.Text, item.Name, tag.id - fact);
                }
            }
            string ss = sb.ToString();
        }

        private IEnumerable<ToolStripMenuItem> GetItems(ToolStripMenuItem item)
        {
            foreach (var dropDownItem in item.DropDownItems)
            {
                if (dropDownItem.GetType() != typeof(ToolStripMenuItem))
                    continue;

                ToolStripMenuItem ddItem = (ToolStripMenuItem)dropDownItem;
                tagCls tag = item.Tag as tagCls;
                ddItem.Tag = new tagCls() { pid = tag.id, id = i++ };
                yield return ddItem;
                if (ddItem.HasDropDownItems)
                {
                    foreach (ToolStripMenuItem subItem in GetItems(ddItem))
                    {
                        //subItem.Text = item.Text + "-->" + subItem.Text;
                        yield return subItem;
                    }
                }
                else
                {
                    //ddItem.Text = item.Text + "-->" + ddItem.Text;
                }
            }
        }

        #endregion

        #region Menu Handlers

        #region My Account Menu

        private void mnuMyAcc_ChangePassword_Click(object sender, EventArgs e)
        {
            new frmChangePassword().ShowDialog(this);
        }

        private void mnuMyAcc_ResetToHome_Click(object sender, EventArgs e)
        {
            DataViewPanel.Controls.Clear();
        }

        private void mnuMyAcc_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Students Menu

        private void mnuStudent_AddNew_Click(object sender, EventArgs e)
        {
            ShowControl<ManageStudents>();
        }

        private void mnuStudent_View_Click(object sender, EventArgs e)
        {
            ShowControl<SearchStudent>();
        }

        private void mnuStudent_Transfer_Click(object sender, EventArgs e)
        {
            new StudentTransfer().ShowDialog(this);
        }

        private void mnuStudent_Leadership_Click(object sender, EventArgs e)
        {
            new StudentLeadership().ShowDialog(this);
        }

        private void mnuStudent_Assign_Club_Click(object sender, EventArgs e)
        {
            new AllocateStudentClub().ShowDialog(this);
        }

        private void mnuStudent_Assign_Athletics_Click(object sender, EventArgs e)
        {
            new AssignSport().ShowDialog(this);
        }

        private void mnuStudent_Assign_MDD_Click(object sender, EventArgs e)
        {
            new AssignMdd().ShowDialog(this);
        }

        private void mnuStudent_Discipline_Passouts_Click(object sender, EventArgs e)
        {
            ShowControl<StudentsPassouts>();
        }

        private void mnuStudent_Discipline_Suspensions_Click(object sender, EventArgs e)
        {
            ShowControl<StudentsSuspensions>();
        }

        private void mnuStudent_Discipline_Expulsions_Click(object sender, EventArgs e)
        {
            ShowControl<StudentsExpulsions>();
        }

        private void mnuStudent_AllocateDomitry_Click(object sender, EventArgs e)
        {
            new Student_dormitry().ShowDialog(this);
        }

        private void mnuStudent_ICardInfo_Click(object sender, EventArgs e)
        {
            ShowControl<StudentIDCrad>();
        }

        private void mnuStudent_UNEBInfo_Click(object sender, EventArgs e)
        {
            ShowControl<UNEB_info>();
        }

        private void mnuStudent_Alumnis_Click(object sender, EventArgs e)
        {
            ShowControl<SchoolAlumnis>();
        }

        #endregion

        #region Parents Menu

        private void mnuParents_AddNew_Click(object sender, EventArgs e)
        {
            ShowControl<ManageParents>();
        }

        private void mnuParents_View_Click(object sender, EventArgs e)
        {
            ShowControl<SearchParent>();
        }

        private void mnuParents_ICardInfo_Click(object sender, EventArgs e)
        {
            ShowControl<ParentIDCrad>();
        }

        private void mnuParents_GatePass_Click(object sender, EventArgs e)
        {
            ShowControl<ParentGatePass>();
        }

        #endregion

        #region School Fees Menu

        private void mnuFees_Types_Click(object sender, EventArgs e)
        {
            new frmFeesTypes().ShowDialog(this);
        }

        private void mnuFees_Structure_Click(object sender, EventArgs e)
        {
            new frmFeesStructures().ShowDialog(this);
        }

        private void mnuFees_GenerateInvoice_Click(object sender, EventArgs e)
        {
            ShowControl<ucFeesInvoice>();
        }

        private void mnuFees_ReceivePayment_Click(object sender, EventArgs e)
        {
            object[] args = { "NEW" };
            ShowControl<ucFeesPayment>("ReceivePayment", args);
        }

        private void mnuFees_PaymentDetails_Click(object sender, EventArgs e)
        {
            object[] args = { "OLD" };
            ShowControl<ucFeesPayment>("PaymentDetails", args);
        }

        #endregion

        #region Staff Menu

        private void mnuStaff_AddNew_Click(object sender, EventArgs e)
        {
            ShowControl<ManageStaff>();
        }

        private void mnuStaff_Payroll_Click(object sender, EventArgs e)
        {
            new Staff_payRoll().ShowDialog(this);
        }

        private void mnuStaff_Leave_Click(object sender, EventArgs e)
        {
            new Staff_Leave().ShowDialog(this);
        }

        private void mnuStaff_Allowances_Click(object sender, EventArgs e)
        {
            new StaffAllowances().ShowDialog(this);
        }

        private void mnuStaff_HOD_TeachingDepartment_Click(object sender, EventArgs e)
        {
            new TeachingStaff_leaders().ShowDialog(this);
        }

        private void mnuStaff_HOD_NonTeachingDepartment_Click(object sender, EventArgs e)
        {
            new Nonteaching_Staffleaders().ShowDialog(this);
        }

        private void mnuStaff_Teaching_Click(object sender, EventArgs e)
        {
            ShowControl<SearchTeacher>();
        }

        private void mnuStaff_NonTeaching_Click(object sender, EventArgs e)
        {
            ShowControl<SearchStaff>();
        }

        private void mnuStaff_ContactsDB_Click(object sender, EventArgs e)
        {
            ShowControl<StaffContacts>();
        }

        private void mnuStaff_EndContract_Click(object sender, EventArgs e)
        {
            new EndStaffContract().ShowDialog(this);
        }

        private void mnuStaff_ICard_Click(object sender, EventArgs e)
        {
            ShowControl<StaffIDCrad>();
        }

        #endregion

        #region User Menu

        private void mnuUser_AddNew_Click(object sender, EventArgs e)
        {
            ShowControl<NewUser>();
        }

        private void mnuUser_UserActions_Click(object sender, EventArgs e)
        {
            ShowControl<UseEntry>();
        }

        #endregion

        #region Exam Menu

        private void mnuExam_New_Click(object sender, EventArgs e)
        {
            new NewExam().ShowDialog(this);
        }

        private void mnuExam_MEStudentWise_OL_Click(object sender, EventArgs e)
        {
            ShowControl<ResultsStudentWiseOlevel>();
        }

        private void mnuExam_MEStudentWise_AL_Click(object sender, EventArgs e)
        {
            ShowControl<ResultsStudentWiseAlevel>();
        }

        private void mnuExam_MEClassWise_OL_Click(object sender, EventArgs e)
        {
            ShowControl<ResultsClassWiseOlevel>();
        }

        private void mnuExam_MEClassWise_AL_Click(object sender, EventArgs e)
        {
            ShowControl<ResultsClassWiseAlevel>();
        }

       
        #endregion

        #region Attendance Menu

        private void mnuAttendance_New_Student_Click(object sender, EventArgs e)
        {
            ShowControl<StudentAttendances>();
        }

        private void mnuAttendance_New_Staff_Click(object sender, EventArgs e)
        {
            ShowControl<StaffAttendance>();
        }

        private void mnuAttendance_Staff_Rep_All_Click(object sender, EventArgs e)
        {
            ShowControl<StaffAttendanceReport>();
        }

        private void mnuAttendance_Staff_Rep_Ind_Click(object sender, EventArgs e)
        {
            ShowControl<IndividualStaffAttendance>();
        }

        private void mnuAttendance_Student_Rep_Ind_Click(object sender, EventArgs e)
        {
            ShowControl<IndividualStudentsAttendance>();
        }

        private void mnuAttendance_Student_Rep_Class_Click(object sender, EventArgs e)
        {
            ShowControl<AllStudentsAttendanceReport>();
        }

        #endregion

        #region Library Menu

        private void mnuLibrary_Manage_AddBook_Click(object sender, EventArgs e)
        {
            ShowControl<NewBook>();
        }

        private void mnuLibrary_Manage_Issue_Student_Click(object sender, EventArgs e)
        {
            ShowControl<IssueBookOutStud>();
        }

        private void mnuLibrary_Manage_Issue_Staff_Click(object sender, EventArgs e)
        {
            ShowControl<IssueBookOutStaff>();
        }

        private void mnuLibrary_Manage_ReturnBook_Click(object sender, EventArgs e)
        {
            ShowControl<ReturningAbook>();
        }

        private void mnuLibrary_Report_BookList_Click(object sender, EventArgs e)
        {
            ShowControl<AvailableBooks>();
        }

        private void mnuLibrary_Report_BookHired_Click(object sender, EventArgs e)
        {
            ShowControl<HiredBooks>();
        }

        #endregion

        #region Timetable Menu

        private void mnuTimetable_Lessons_Click(object sender, EventArgs e)
        {
            ShowControl<LessonsTimetable>();
        }

        private void mnuTimetable_Exam_Click(object sender, EventArgs e)
        {
            ShowControl<ExamTimeTable>();
        }

        private void mnuTimetable_Activity_Click(object sender, EventArgs e)
        {
            ShowControl<ActivitiesTimeTable>();
        }

        private void mnuTimetable_View_Class_Click(object sender, EventArgs e)
        {
            ShowControl<ClassWiseTimetable>();
        }

        private void mnuTimetable_View_Teacher_Click(object sender, EventArgs e)
        {
            ShowControl<TeacherWise_TimeTable>();
        }

        private void mnuTimetable_View_Activity_Click(object sender, EventArgs e)
        {
            ShowControl<ActivityTimetable_view>();
        }

        private void mnuTimetable_View_General_Click(object sender, EventArgs e)
        {
            ShowControl<GeneralSchoolTimeTable>();
        }

        #endregion

        #region Alert Menu

        private void mnuAlert_Email_ConfigMsg_Click(object sender, EventArgs e)
        {
            new EmailMessageTemplate().ShowDialog(this);
        }

        private void mnuAlert_SMS_ConfigMsg_Click(object sender, EventArgs e)
        {
            new SmsMessageTemplatess().ShowDialog(this);
        }

        #endregion

        #region Configure Menu

        private void mnuConfig_Level_Click(object sender, EventArgs e)
        {
            new NewLevel().ShowDialog(this);
        }

        private void mnuConfig_Subject_OL_Click(object sender, EventArgs e)
        {
            new NewSubjects().ShowDialog(this);
        }

        private void mnuConfig_Subject_AL_Click(object sender, EventArgs e)
        {
            new Alevel_subjects().ShowDialog(this);
        }

        private void mnuConfig_Subject_Paper_OL_Click(object sender, EventArgs e)
        {
            new OlevelPaper_config().ShowDialog(this);
        }

        private void mnuConfig_Subject_Paper_AL_Click(object sender, EventArgs e)
        {
            new AlevelPaperConfiguration().ShowDialog(this);
        }

        private void mnuConfig_School_Dept_Click(object sender, EventArgs e)
        {
            new NewDepartment().ShowDialog(this);
        }

        private void mnuConfig_Class_New_Click(object sender, EventArgs e)
        {
            new NewClass().ShowDialog(this);
        }

        private void mnuConfig_Class_Streams_Click(object sender, EventArgs e)
        {
            new ClassStreams().ShowDialog(this);
        }

        private void mnuConfig_Class_AllocTeacher_Click(object sender, EventArgs e)
        {
            new AllocateTeachers().ShowDialog(this);
        }

        private void mnuConfig_Class_AllocClassTeacher_Click(object sender, EventArgs e)
        {
            new ClassTeachers().ShowDialog(this);
        }

        private void mnuConfig_Dormitory_Add_Click(object sender, EventArgs e)
        {
            new NewDomitry().ShowDialog(this);
        }

        private void mnuConfig_StudentAct_Clubs_Click(object sender, EventArgs e)
        {
            new StudentsClubs().ShowDialog(this);
        }

        private void mnuConfig_StudentAct_Athletics_Click(object sender, EventArgs e)
        {
            new StudentAthletics().ShowDialog(this);
        }

        private void mnuConfig_StudentAct_MDD_Click(object sender, EventArgs e)
        {
            new StudentsMdd().ShowDialog(this);
        }

        private void mnuConfig_Exam_Session_Click(object sender, EventArgs e)
        {
            new Exam_sessionControl().ShowDialog(this);
        }

        private void mnuConfig_Exam_GradeConfig_OL_Click(object sender, EventArgs e)
        {
            new Olevel_gradesSettings().ShowDialog(this);
        }

        private void mnuConfig_Exam_GradeConfig_AL_Click(object sender, EventArgs e)
        {
            new Alevel_gradesSettings().ShowDialog(this);
        }

        private void mnuConfig_TimeTable_Click(object sender, EventArgs e)
        {
            new Time_SchdulesController().ShowDialog(this);
        }

        private void mnuConfig_NextTermBegin_Click(object sender, EventArgs e)
        {
            new NextTermBeginsOn().ShowDialog(this);
        }

        #endregion

        #region Report Menu


        private void mnuReport_Academic_Progress_OL_Click(object sender, EventArgs e)
        {
            ShowControl<OLevelReportCard>();
        }

        private void mnuReport_Academic_Progress_AL_Click(object sender, EventArgs e)
        {
            ShowControl<ALevelReportCard>();
        }

        private void mnuReport_Academic_CWMS_Click(object sender, EventArgs e)
        {
            ShowControl<ClassWiseReportCard>();
        }

        private void mnuReport_Academic_SWMS_Click(object sender, EventArgs e)
        {
            ShowControl<SubjectWiseReportCard>();
        }

        private void mnuReport_Academic_PerfAnalysis_Click(object sender, EventArgs e)
        {
            ShowControl<PerformanceAnalysis>();
        }


        

        #endregion

        #region Setting Menu

        private void mnuSettings_AccessLevel_Click(object sender, EventArgs e)
        {
            new AccessLevels().ShowDialog(this);
        }

        private void mnuSettings_Access_Click(object sender, EventArgs e)
        {
            new RoleFeature().ShowDialog(this);
        }

        private void mnuSettings_DaysOfWeek_Click(object sender, EventArgs e)
        {
            new Week_daysController().ShowDialog(this);
        }

        #endregion

        #region Tool Menu

        #endregion

        #region Help Menu

        #endregion


        private void ShowControl<T>(string conName = null, object[] args = null)
        {
            try
            {
                string controlName = conName;
                if (string.IsNullOrEmpty(controlName))
                {
                    controlName = typeof(T).Name;
                }
                var existingControl = DataViewPanel.Controls.Find(controlName, true).FirstOrDefault();
                if (existingControl != null)
                {
                    existingControl.BringToFront();
                    return;
                }
                Control new_control = (Control)Activator.CreateInstance(typeof(T), args);
                new_control.Name = controlName;
                new_control.Dock = DockStyle.Fill;
                DataViewPanel.Controls.Add(new_control);
                new_control.BringToFront();
            }
            catch { }
        }

        #endregion

        #region Form Events

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form rf in Application.OpenForms)
            {
                if (rf.Name == "LoginForm")
                {
                    ((LoginForm)rf).Show();
                }
            }
        }


        #endregion
        #region CustomDesign
        private void customDesign()
        {
            CurrentUserLbl.Text = AppHelper.user_name;
            try {
                using (var db = new schulex_dbEntities())
                {
                    var myschool = db.school_details.FirstOrDefault();
                    SchName = myschool.school_name;
                    school_logo = myschool.logo;
                    moto = myschool.motto;
                    SchAdd = myschool.PhysicalAddress;
                    pNumber = myschool.Telephone;

                }
                ShowControl<UcDashboardSummary>();
                ImageHelper.SetImage(SchLogopbx, school_logo);
                schNameLbl.Text = SchName.ToUpper();
                SchMottoLbl.Text = moto;
                LblAdress.Text = SchAdd +","+pNumber;
                DateTime now = DateTime.Now;
                CalLabel.Text = now.ToLongDateString();
                Timelabel.Text = now.ToShortTimeString();
                Termlabel.Text = "Term One /" + now.Year;
                InnerCalendarLbl.Text = now.Day.ToString();
                
            }
            catch { }
        }
        #endregion

        private void BtnMaximizeFrm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizeFrm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void schoolDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewDepartment().ShowDialog(this);
        }

        private void schoolDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SchoolDetails().ShowDialog(this);
        }

        private void studySectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StudySections().ShowDialog(this);
        }

        private void levelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewLevel().ShowDialog(this);
        }

        private void dashboardSummaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowControl<UcDashboardSummary>();
        }
        private void OpenBrowserLink(string mylink)
        {
            try
            {
                Process.Start(mylink);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void mnuHelp_VisitWebsite_Click(object sender, EventArgs e)
        {

            OpenBrowserLink("https://schulex.com/");
            
        }

        private void mnuHelp_Adviser_Click(object sender, EventArgs e)
        {
            OpenBrowserLink("https://izocomsystems.com//contact");
        }

        private void videoTutorialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBrowserLink("https://schulex.com/videos");
        }

        private void staffRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UcStaffBulkImportXLui>();
        }

        private void studentsRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UcStudentsBulkImportXLui>();
        }

        private void parentsRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UcParentsBulkImportXLui>();
        }

        private void marksEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UcMarksEntryBulkImportXLui>();
        }

        private void bulkUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBulkStudentsUpdate().ShowDialog(this);
        }

        private void generateAdmissionLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UcStudentAdmissionLetters>();
        }

        private void admissionLettersHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UCstudentsAdmissionsHistory>();
        }

        private void createIdentityCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UcCreateStudentID>();
        }

        private void viewIdentityCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UcIdentityCardHistory>();
        }

        private void studentsPhotoTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UcStudentsPhotos>();
        }

        private void listOfActiveStudentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowControl<UcListOfActiveStudents>();

        }

        private void listOfArchivedStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UcListOfArchivedStudents>();
        }

        private void activeStudentsPopulationSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UcStudPopSumary>();
        }


        private void oLevelToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new FrmClassSubjectsOL().ShowDialog(this);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClassStreams().ShowDialog();
        }

        private void mergeStreamToClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClassStreamsConfig().ShowDialog();
        }

        private void assignStudentsToStreamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UcStudentStreamAssign>();
        }

        private void transferStudentsFromOneStreamToAnotherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TransferStudsFromStreamToStream().ShowDialog();
        }


        private void nextTermBeginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NextTermBeginsOn().ShowDialog(this);
        }

        private void aLevelToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new FrmClassSubjectsAL().ShowDialog(this);
        }

        private void transferStudentsFromOneClassToAnotherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StudentTransfer().ShowDialog(this);
        }

        private void transferStudentsToArchiveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmArchiveStudents().ShowDialog();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewClass().ShowDialog(this);
        }

        private void schoolJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSchoolJobs().ShowDialog(this);
        }

        private void paymentModesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPaymodes().ShowDialog(this);
        }

        private void defaultSystemCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDefaultCurrency().ShowDialog();
        }

        private void oLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OlevelPaper_config().ShowDialog(this);
        }

        private void aLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AlevelPaperConfiguration().ShowDialog(this);
        }

        private void createAccessLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AccessLevels().ShowDialog(this);
        }

        private void managaeAccessLevelsSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RoleFeature().ShowDialog(this);
        }

        private void createStudyTermToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StudyTerms().ShowDialog(this);
        }

        private void createManageOperationalStudyTermToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CurrentTermAndAcademicYear().ShowDialog(this);
        }

        private void continentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmContinents().ShowDialog(this);
        }

        private void countriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCountries().ShowDialog(this);
        }

        private void regionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRegions().ShowDialog(this);
        }

        private void districtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDistricts().ShowDialog(this);
        }

        private void tribesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTribes().ShowDialog(this);
        }

        private void guardianRelationshipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGuardianRelationships().ShowDialog(this);
        }

        private void createMessageCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMessageCategories().ShowDialog(this);
        }

        private void scheduleMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UCscheduleSms>();
        }

        private void sendMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UCsendSMS>();
        }

        private void messageReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UCsmsReports>();
        }

        private void assignStudentLeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StudentLeadership().ShowDialog(this);
        }

        private void createLeadershipCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UCstudentCertificates>();
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewDomitry().ShowDialog(this);
        }

        private void allocateStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Student_dormitry().ShowDialog(this);
        }


        private void chooseStudentLeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DormStudLeaders().ShowDialog(this);
        }

        private void createOffenseCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmOffensesCategories().ShowDialog(this);
        }

        private void passoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<StudentsPassouts>();
        }

        private void suspensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<StudentsSuspensions>();
        }

        private void expulsionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<StudentsExpulsions>();
        }

        private void examSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Exam_sessionControl().ShowDialog(this);
        }

        private void aLevelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Alevel_gradesSettings().ShowDialog(this);
        }

        private void oLevelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Olevel_gradesSettings().ShowDialog(this);
        }

        private void addExaminingBodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmExternalexaminingBodies().ShowDialog(this);
        }

        private void addExternalExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewExternalExam().ShowDialog(this);
        }

        private void oLevelToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ShowControl<UCExternalExamsMarkEntryOL>();
        }

        private void aLevelToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ShowControl<UCExternalExamsMarkEntryAL>();
        }

        private void createManageContactListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmContactGroup().ShowDialog(this);
        }

        private void addContactsToListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UC_ManageContactList>();
        }

        private void createLeadershipPostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmStudLeadershipTitles().ShowDialog(this);
        }

        private void createIdentityCardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowControl<UcCreateParentsID>();
        }

        private void viewIdentiyCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UCParentsIdHistory>();
        }

        private void createNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowControl<UCparentVisitsEntry>();
        }

        private void viewParentsVisitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UCparentsVisitsHistory>();
        }

        private void directorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<ManageSchoolDirectors>();
        }

        private void operatingAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmOperatingSchAdmins().ShowDialog(this);
        }

        private void createNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowControl<Uc_createStaffID>();
        }

        private void viewManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<UC_StaffIDHistory>();
        }

        private void listOfActiveStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl<Uc_activeStaffList>();
        }

        private void assignClassTeachersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ClassTeachers().ShowDialog(this);
        }

        private void allocateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AllocateTeachers().ShowDialog(this);
        }

        private void oLevelToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ShowControl<PerfCommentsOlevel>();
        }

        private void aLevelToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ShowControl<PerfCommentsALevel>();
        }






    }
}

