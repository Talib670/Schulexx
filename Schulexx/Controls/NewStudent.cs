using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Model;
using Schulexx.Code;
using Schulexx.Data;
using Schulexx.Forms;
using Schulexx.Utility;

namespace Schulexx.Controls
{
    public partial class NewStudent : UserControl
    {
        public NewStudent()
        {
            InitializeComponent();
        }
        Students Local_Student = new Students();
        StudentsDataAdapter Process_Student = new StudentsDataAdapter();
        int get_id = 0;
        Class_enrollments LocalClass_enroll = new Class_enrollments();
        ClassEnrollmentsDataAdapter ProcessClass_enroll = new ClassEnrollmentsDataAdapter();
        Admissions local_admission = new Admissions();
        AdmissionsDataAdapter Process_admission = new AdmissionsDataAdapter();
        public string GenerateNumber()
        {
            using (var db = new schulex_dbEntities())
            {
                var school = db.school_details.FirstOrDefault();
                if(school == null || string.IsNullOrEmpty(school.Abbreviation))
                {
                    throw new Exception("School Abbreviation not found");
                }
                string prefix = school.Abbreviation + " /" + DateTime.Today.ToString("yy") + " / ";
                int lastNo = 0;
                var lastStudent = db.students.Where(x => x.reg_number.StartsWith(prefix)).OrderByDescending(x => x.reg_number).FirstOrDefault();
                if(lastStudent != null)
                {
                    lastNo = int.Parse(lastStudent.reg_number.Replace(prefix, ""));
                }
                return prefix + (lastNo + 1).ToString().PadLeft(3, '0');
            }
            /*Random random = new Random();
            string r = "TML /" + DateTime.Today.ToString("yy") + " / ";
            string y = DateTime.Today.ToString("yy");
            int i;
            for (i = 1; i < 4; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;*/
        }



        public void insert_update()
        {
            if (!new Connectoperations().validate_string(FnameTxt.Text))
            {
                MessageBox.Show("Please provide only letters\ntry again", "Invalid Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                FnameTxt.Select();
            }
            else if (!new Connectoperations().validate_string(SnameTxt.Text))
            {
                MessageBox.Show("Please provide only letters\ntry again", "Invalid Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                SnameTxt.Select();
            }

            else if (Gender_CBx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Student's Gender", "Empty Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            else if (Class_cbx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Class for student", "Empty Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            else if (streamCbx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Stream for student", "Empty Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            else
            {
                Local_Student.student_id = get_id;
                Local_Student.reg_number = new Connectoperations().validate_All_Data(GenerateNumber());
                Local_Student.fname = new Connectoperations().validate_All_Data(FnameTxt.Text);
                Local_Student.lname = new Connectoperations().validate_All_Data(SnameTxt.Text);
                Local_Student.gender = new Connectoperations().validate_All_Data(Gender_CBx.Text);
                Local_Student.Religion = new Connectoperations().validate_All_Data(Religion_CBx.Text);
                Local_Student.BirthDate = dateTimePicker1.Value;
                Local_Student.homeContact = new Connectoperations().validate_All_Data(HomCTextBx.Text);
                Local_Student.homedistrict = new Connectoperations().validate_All_Data(DistictTextBox.Text);
                Local_Student.homeVillage = new Connectoperations().validate_All_Data(HomeVilTxt.Text);
                Local_Student.nationality = new Connectoperations().validate_All_Data(Nationality_txt.Text);
                Local_Student.study_section_id = int.Parse(new Connectoperations().singleval("study_section", "study_section_id", "where study_section_name='" + Study_secCbx.Text + "'"));
                Local_Student.admission_year = mtbYearFilter.Text.ToString();
                if (pictureBox3.Image == null)
                {
                    op = Application.StartupPath + @"\Defult_Staff.png";
                    Local_Student.stud_pic = ImageHelper.GetByteArrayFromImage(op);
                }
                else
                {
                    Local_Student.stud_pic = sfellow;
                }

                if (get_id == 0)
                {
                    Process_Student.Insert(Local_Student, Local_Student.stud_pic);
                    LocalClass_enroll.id = get_id;
                    LocalClass_enroll.student_id = int.Parse(new Connectoperations().singleval("students", "MAX(student_id)", ""));
                    LocalClass_enroll.class_id = int.Parse(new Connectoperations().singleval("classes", "class_id", "where cname='" + Class_cbx.Text + "'"));
                    LocalClass_enroll.stream_id = int.Parse(new Connectoperations().singleval("class_streams", "id", "where stream_label='" + streamCbx.Text + "'"));
                    LocalClass_enroll.year = int.Parse(mtbYearFilter.Text);
                    ProcessClass_enroll.Insert(LocalClass_enroll);
                    Process_admission.Insert(local_admission);
                    clear();
                }

                else
                {
                    LocalClass_enroll.student_id = get_id;
                    LocalClass_enroll.class_id = int.Parse(new Connectoperations().singleval("classes", "class_id", "where cname='" + Class_cbx.Text + "'"));
                    LocalClass_enroll.stream_id = int.Parse(new Connectoperations().singleval("class_streams", "id", "where stream_label='" + streamCbx.Text + "'"));
                    Process_Student.Update(Local_Student, Local_Student.stud_pic);
                    ProcessClass_enroll.Update(LocalClass_enroll);
                    clear();

                }

            }
        }

        public void clear()
        {
            pictureBox3.Image = null;
            FnameTxt.Clear();
            SnameTxt.Clear();
            HomCTextBx.Clear();
            Gender_CBx.SelectedIndex = -1;
            Religion_CBx.SelectedIndex = -1;
            Study_secCbx.SelectedIndex = -1;
            Class_cbx.SelectedIndex = -1;
            streamCbx.SelectedIndex = -1;
            Nationality_txt.Clear();
            DistictTextBox.Clear();
            HomeVilTxt.Clear();
            DistictTextBox.Clear();
            FnameTxt.Select();
            button5.Enabled = false;
            Save_button.Text = "Save";
            Del_button.Visible = false;
            get_id = 0;
            load_list();
            //calculate_aggregate();
        }

        List<Classes> Load_Class = new List<Classes>();
        ClassesDataAdapter Process_class = new ClassesDataAdapter();

        public void load_class_list()
        {
            try
            {
                Class_cbx.Items.Clear();

                Load_Class = Process_class.GetClassesList("ORDER BY class_position ASC");

                foreach (Classes c in Load_Class)
                {
                    Class_cbx.Items.Add(c.cname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        List<Class_streams> Load_Stream = new List<Class_streams>();
        Class_streamsDataAdapters Process_stream = new Class_streamsDataAdapters();

        public void load_stream_list()
        {
            try
            {
                streamCbx.Items.Clear();

                Load_Stream = Process_stream.GetClass_streamsList("");

                foreach (Class_streams sc in Load_Stream)
                {
                    streamCbx.Items.Add(sc.stream_label);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        List<Students> load_Students = new List<Students>();
        List<byte[]> PhotesIn = new List<byte[]>();

        private void load_list()
        {
            try
            {
                listView1.Items.Clear();
                PhotesIn.Clear();
                load_Students = Process_Student.GetStudentsList("ORDER BY student_id DESC");

                foreach (Students c in load_Students)
                {
                    PhotesIn.Add(c.stud_pic);

                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.student_id.ToString();
                    pp.SubItems.Add(c.reg_number);
                    pp.SubItems.Add(c.fname);

                    pp.SubItems.Add(c.lname);
                    pp.SubItems.Add(c.gender); ;

                    pp.SubItems.Add(new Connectoperations().singleval("classes", "cname", "where class_id='" + new Connectoperations().singleval("class_enrollments", "class_id", "where student_id='" + c.student_id + "'") + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("class_streams", "stream_label", "where id='" + new Connectoperations().singleval("class_enrollments", "stream_id	", "where student_id='" + c.student_id + "'") + "'"));

                    pp.SubItems.Add(c.homeVillage);
                    pp.SubItems.Add(c.nationality);
                    pp.SubItems.Add(c.BirthDate.ToShortDateString());
                    pp.SubItems.Add(c.Religion);
                    pp.SubItems.Add(new Connectoperations().singleval("study_section", "study_section_name", "where study_section_id='" + c.study_section_id + "'"));
                    pp.SubItems.Add(c.admission_year.ToString());
                    pp.SubItems.Add(c.homeContact);
                    pp.SubItems.Add(c.homedistrict);
                    listView1.Items.Add(pp);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            mtbYearFilter.Text = DateTime.Today.ToString("yyyy");
            load_class_list();
            load_stream_list();
            Add_signChk.Visible = false;
            Del_button.Visible = false;
            button5.Visible = false;
            load_list();
        }

        byte[] sfellow;
        string op = "";

        private void button1_Click(object sender, EventArgs e)
        {
            UploadImage();
        }

        private void UploadImage()
        {
            try
            {
                //openFileDialog1.Filter = "(*.jpg)|*.jpg";
                openFileDialog1.Filter = "All Files|*.*|png|*.png|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                openFileDialog1.Title = "Schulexx";
                openFileDialog1.FileName = "Schulexx";
                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                    return;

                string fileloc = openFileDialog1.FileName;
                //pictureBox3.Load(fileloc);

                using (FileStream myStream = new FileStream(fileloc, FileMode.Open, FileAccess.Read))
                {
                    byte[] myImageBuffer = new byte[myStream.Length];
                    // Read the bytes from this stream and put it into the image buffer
                    myStream.Read(myImageBuffer, 0, (int)myStream.Length);
                    byte[] sfel = myImageBuffer;
                    if (sfel.Length > 0)
                    {
                        Bitmap mk = new Bitmap(myStream);
                        if (mk.Width > 200 && mk.Height > 100)
                        {
                            Bitmap sd = new Bitmap(mk, new Size(217, 151));
                            NewImag.Image = sd;
                        }
                        else
                        {
                            NewImag.Image = mk;
                        }
                        op = Application.StartupPath + @"\" + openFileDialog1.SafeFileName + "_2_6_09";
                        Bitmap bmp1 = new Bitmap(NewImag.Image);
                        bmp1.Save(op);
                    }
                }

                sfellow = ImageHelper.GetByteArrayFromImage(op);
                File.Delete(op);

            }
            catch (Exception ex)
            {
                if (ex.Message == "Parameter is not valid.")
                    MessageBox.Show(ex.Message + " [ Select an image !]", "Schulexx.");
            }
        }



        private void Save_button_Click(object sender, EventArgs e)
        {
            insert_update();
            clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (Add_signChk.Checked == true)
            {
                button5.Visible = true;
            }
            else
            {
                button5.Visible = false;
            }

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                Save_button.Text = "Update";
                Del_button.Visible = true;
                //class_enrolBtn.Visible = true;
                //Admission_btn.Visible = true;
                get_id = int.Parse(e.Item.SubItems[0].Text);
                FnameTxt.Text = e.Item.SubItems[2].Text;
                SnameTxt.Text = e.Item.SubItems[3].Text;
                Gender_CBx.Text = e.Item.SubItems[4].Text;
                Class_cbx.Text = e.Item.SubItems[5].Text;
                streamCbx.Text = e.Item.SubItems[6].Text;
                HomeVilTxt.Text = e.Item.SubItems[7].Text;
                Nationality_txt.Text = e.Item.SubItems[8].Text;
                dateTimePicker1.Text = e.Item.SubItems[9].Text;
                Religion_CBx.Text = e.Item.SubItems[10].Text;
                Study_secCbx.Text = e.Item.SubItems[11].Text;
                mtbYearFilter.Text = e.Item.SubItems[12].Text;
                HomCTextBx.Text = e.Item.SubItems[13].Text;
                DistictTextBox.Text = e.Item.SubItems[14].Text;
                int x = e.Item.Index;
                sfellow = PhotesIn[x];
                using (MemoryStream mem = new MemoryStream(sfellow, true))
                {
                    mem.Write(sfellow, 0, sfellow.Length);
                    pictureBox3.Image = new Bitmap(mem, true);
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UploadImage();
        }

        ClassesDataAdapter Process_HC = new ClassesDataAdapter();
        List<Classes> Load_Classes = new List<Classes>();


        private void Del_button_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {

                    Process_Student.deletestudents("where 	student_id =" + get_id + "");
                    load_list();
                    clear();
                }
                else
                {
                    return;
                }
            }
            catch { }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void class_enrolBtn_Click(object sender, EventArgs e)
        {
            new ClassEnrollment(get_id).ShowDialog();
        }

        private void Admission_btn_Click(object sender, EventArgs e)
        {
            new AddingStudentsAdmission(get_id).ShowDialog();
        }

    }
}
