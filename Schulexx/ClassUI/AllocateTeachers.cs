using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Code;
using Schulexx.Model;
using Schulexx.Data;

namespace Schulexx.ConfigureUI
{
    public partial class AllocateTeachers : Form
    {
        public AllocateTeachers()
        {
            InitializeComponent();
        }
        Teacher_allocation Local_teacher = new Teacher_allocation();
        Teacher_allocationDataAdapter Process_teacher = new Teacher_allocationDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            
            string[] mm = TeacherCbx.Text.Split(' ');
            Local_teacher.id = get_id;
            Local_teacher.class_id = int.Parse(new Connectoperations().singleval("classes", "class_id", "where cname='" + ClassCbx.Text + "'"));
            Local_teacher.teacher_id = int.Parse(new Connectoperations().singleval("staff", "id", "where fname='" + mm[0] + "' and 	lname='" + mm[1] + "'"));
            Local_teacher.subject_id = int.Parse(new Connectoperations().singleval("subjects", "subject_id", "where sname='" + SubjectCbx.Text + "'"));
            Local_teacher.year = int.Parse(YearFilter.Text);
            if(YearFilter.Text==""){
                MessageBox.Show("Year cannot be empty");
            }
            if (get_id == 0)
            {
                Process_teacher.Insert(Local_teacher);
                clear();
                Load_List();
            }
            else
            {
                Process_teacher.Update(Local_teacher);
                clear();
                Load_List();
            }
        }

        public void clear()
        {
            get_id = 0;
            Btn_delete.Visible = false;
            Btn_save.Text = "Save";
            ClassCbx.SelectedIndex = -1;
            TeacherCbx.SelectedIndex = -1;
            SubjectCbx.SelectedIndex = -1;

        }

        List<Staff> Load_teachers = new List<Staff>();
        StaffDataAdapter Process_teachers = new StaffDataAdapter();

        public void load_staff_list()
        {
            try
            {
                TeacherCbx.Items.Clear();

                Load_teachers = Process_teachers.GetStaffList("where staff_type= 'Teaching Staff' ");

                foreach (Staff c in Load_teachers)
                {
                    TeacherCbx.Items.Add(c.fname + " " + c.lname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        List<Classes> Load_class = new List<Classes>();
        ClassesDataAdapter Process_class = new ClassesDataAdapter();

        public void load_class_list()
        {
            try
            {
                ClassCbx.Items.Clear();

                Load_class = Process_class.GetClassesList("where level_id=" + new Connectoperations().singleval("levels", "id", "where name= 'Ordinary Level'"));

                foreach (Classes c in Load_class)
                {
                    ClassCbx.Items.Add(c.cname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        List<Subjects> Load_subjects = new List<Subjects>();
        SubjectsDataAdapter Process_subjects = new SubjectsDataAdapter();

        public void load_subject_list()
        {
            try
            {
                SubjectCbx.Items.Clear();

                Load_subjects = Process_subjects.GetSubjectsList("");

                foreach (Subjects c in Load_subjects)
                {
                    SubjectCbx.Items.Add(c.sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        List<Teacher_allocation> Load_teacher = new List<Teacher_allocation>();

        public void Load_List()
        {
            try
            {
                //listView1.Items.Clear();
                Load_teacher = Process_teacher.GetTeacher_allocationList("");

                foreach (Teacher_allocation c in Load_teacher)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("classes", "cname", "where class_id='" + c.class_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("staff", "concat(fname,' ',lname)", "where id='" + c.teacher_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("subjects", "sname", "where subject_id='" + c.subject_id + "'"));
                    pp.SubItems.Add(c.year.ToString());

                    //listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AllocateTeachers_Load(object sender, EventArgs e)
        {
            YearFilter.Text = DateTime.Today.ToString("yyyy");
            //AlYearFilter.Text = DateTime.Today.ToString("yyyy");
            Load_List();
            load_subject_list();
            load_class_list();
            load_staff_list();
            Btn_delete.Visible = false;
            //DeleteBtn.Visible = false;
            //load_Alsubject_list();
            //Load_List_alevel();
            //load_staff_listALevel();
            //load_Alclass_list();


        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            get_id = int.Parse(e.Item.SubItems[0].Text);
            ClassCbx.Text = e.Item.SubItems[1].Text;
            TeacherCbx.Text = e.Item.SubItems[2].Text;
            SubjectCbx.Text = e.Item.SubItems[3].Text;
            YearFilter.Text = e.Item.SubItems[4].Text;
            Btn_delete.Visible = true;
            Btn_save.Text = "Update";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Teacher_allocation_alevel Local_teacher_Alevel = new Teacher_allocation_alevel();
        Teacher_allocation_alevelDataAdapter Process_teacherAlevel = new Teacher_allocation_alevelDataAdapter();
        int get_id1 = 0;
        //public void insert_updateAlevel()
        //{
        //    string[] mm = TeacherFilter.Text.Split(' ');
        //    Local_teacher_Alevel.id = get_id1;
        //    Local_teacher_Alevel.class_id = int.Parse(new Connectoperations().singleval("classes", "class_id", "where cname='" + AlClassfilter.Text + "'"));
        //    Local_teacher_Alevel.teacher_id = int.Parse(new Connectoperations().singleval("staff", "id", "where fname='" + mm[0] + "' and 	lname='" + mm[1] + "'"));
        //    Local_teacher_Alevel.subject_id = int.Parse(new Connectoperations().singleval("subjects_alevel", "id", "where subj_name ='" + SubjectFilter.Text + "'"));
        //    Local_teacher_Alevel.year = int.Parse(AlYearFilter.Text);
        //    if (AlYearFilter.Text == "")
        //    {
        //        MessageBox.Show("Year cannot be empty");
        //    }
        //    if (get_id == 0)
        //    {
        //        Process_teacherAlevel.Insert(Local_teacher_Alevel);
        //        Alclear();
        //        Load_List_alevel();
        //    }
        //    else
        //    {
        //        Process_teacherAlevel.Update(Local_teacher_Alevel);
        //        Alclear();
        //        Load_List_alevel();
        //    }
        //}

        //public void Alclear()
        //{
        //    get_id1 = 0;
        //    DeleteBtn.Visible = false;
        //    SaveBtn.Text = "Save";
        //    AlClassfilter.SelectedIndex = -1;
        //    TeacherFilter.SelectedIndex = -1;
        //    SubjectFilter.SelectedIndex = -1;

        //}

        List<Teacher_allocation_alevel> AL_Load_teacher = new List<Teacher_allocation_alevel>();

        //public void Load_List_alevel()
        //{
        //    try
        //    {
        //        listView2.Items.Clear();
        //        AL_Load_teacher = Process_teacherAlevel.GetTeacher_allocation_alevelList("");

        //        foreach (Teacher_allocation_alevel c in AL_Load_teacher)
        //        {
        //            ListViewItem pp = new ListViewItem();
        //            pp.Text = c.id.ToString();
        //            pp.SubItems.Add(new Connectoperations().singleval("classes", "cname", "where class_id='" + c.class_id + "'"));
        //            pp.SubItems.Add(new Connectoperations().singleval("staff", "concat(fname,' ',lname)", "where id='" + c.teacher_id + "'"));
        //            pp.SubItems.Add(new Connectoperations().singleval("subjects_alevel", "subj_name", "where id='" + c.subject_id + "'"));
        //            pp.SubItems.Add(c.year.ToString());

        //            listView2.Items.Add(pp);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        //public void load_staff_listALevel()
        //{
        //    try
        //    {
        //        TeacherFilter.Items.Clear();

        //        Load_teachers = Process_teachers.GetStaffList("where staff_type= 'Teaching Staff' ");

        //        foreach (Staff c in Load_teachers)
        //        {
        //            TeacherFilter.Items.Add(c.fname + " " + c.lname);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        //public void load_Alclass_list()
        //{
        //    try
        //    {
        //        AlClassfilter.Items.Clear();

        //        Load_class = Process_class.GetClassesList("where level_id=" + new Connectoperations().singleval("levels", "id", "where name= 'Advanced Level'"));

        //        foreach (Classes c in Load_class)
        //        {
        //            AlClassfilter.Items.Add(c.cname);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        List<Subjects_alevel> Load_Alsubjects = new List<Subjects_alevel>();
        Subjects_alevelDataAdapter Process_Alsubjects = new Subjects_alevelDataAdapter();

        //public void load_Alsubject_list()
        //{
        //    try
        //    {
        //        SubjectFilter.Items.Clear();

        //        Load_Alsubjects = Process_Alsubjects.GetSubjects_alevelList(" ");

        //        foreach (Subjects_alevel c in Load_Alsubjects)
        //        {
        //            SubjectFilter.Items.Add(c.subj_name);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        //private void Newbtn_Click(object sender, EventArgs e)
        //{
        //    Alclear();
        //}

        //private void SaveBtn_Click(object sender, EventArgs e)
        //{
        //    insert_updateAlevel();
        //}

        //private void DeleteBtn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DialogResult ret;
        //        ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        //        if (ret == DialogResult.Yes)
        //        {

        //            Process_teacherAlevel.deleteteacher_allocation_alevel("where id =" + get_id1 + "");
        //            Alclear();
        //            Load_List_alevel();
        //        }
        //        else
        //        {
        //            return;
        //        }
        //    }
        //    catch { }
        //}

        private void listView1_ItemSelectionChanged_1(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Btn_save.Text = "Update";
            Btn_delete.Visible = true;
            get_id = int.Parse(e.Item.SubItems[0].Text);
            ClassCbx.Text = e.Item.SubItems[1].Text;
            TeacherCbx.Text = e.Item.SubItems[2].Text;
            SubjectCbx.Text = e.Item.SubItems[3].Text;
            YearFilter.Text = e.Item.SubItems[4].Text;
        }

        private void Btn_delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {

                    Process_teacher.deleteteacher_allocation("where id =" + get_id + "");
                    clear();
                    Load_List();
                }
                else
                {
                    return;
                }
            }
            catch { }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
