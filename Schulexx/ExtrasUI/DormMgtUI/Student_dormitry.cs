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
using Schulexx.Data;
using Schulexx.Model;

namespace Schulexx.StudentsUI
{
    public partial class Student_dormitry : Form
    {
        public Student_dormitry()
        {
            InitializeComponent();
        }
        Dormitry_allocations Local_dormitry = new Dormitry_allocations();
        Dormitry_allocationsDataAdapter Process_dormitry = new Dormitry_allocationsDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            string[] mm = StudentCbx.Text.Split(' ');
            Local_dormitry.id = get_id;
            Local_dormitry.student_id = int.Parse(new Connectoperations().singleval("students","student_id","where fname='"+mm[0]+"' and lname='"+mm[1]+"'"));
            Local_dormitry.dormitry_id = int.Parse(new Connectoperations().singleval("dormitry", "id", "where dormitry_name='" + DormitryCbx.Text + "'"));
            if(get_id==0){
                Process_dormitry.Insert(Local_dormitry);
                clear();
                Load_List();
            }else{
                Process_dormitry.Update(Local_dormitry);
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
            StudentCbx.SelectedIndex = -1;
            DormitryCbx.SelectedIndex = -1;
        }

        List<Dormitry_allocations> Load_dorm = new List<Dormitry_allocations>();
        public void Load_List()
        {
            try
            {
                listView1.Items.Clear();
                Load_dorm = Process_dormitry.GetDormitry_allocationsList("");


                foreach (Dormitry_allocations c in Load_dorm)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("dormitry", "dormitry_name", "where id='" + c.dormitry_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("classes", "cname", "where class_id='" + new Connectoperations().singleval("class_enrollments", "class_id", "where student_id='" + c.student_id + "'") + "'"));
                    listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ClassesDataAdapter process_class = new ClassesDataAdapter();
        List<Classes> load_classes = new List<Classes>();
        public void load_class()
        {

            try
            {
                ClassCbx.Items.Clear();
                load_classes = process_class.GetClassesList("");

                foreach (Classes ee in load_classes)
                {

                    ClassCbx.Items.Add(ee.cname);

                }
            }
            catch { }

        }

        StudentsDataAdapter Process_student = new StudentsDataAdapter();
        ClassEnrollmentsDataAdapter process_enrol = new ClassEnrollmentsDataAdapter();
        List<Class_enrollments> load_student = new List<Class_enrollments>();

        public void Load_Students()
        {
            try
            {
                StudentCbx.Items.Clear();
                load_student = process_enrol.GetClass_enrollmentsList("where class_id='" + new Connectoperations().singleval("classes", "class_id", "where cname='" + ClassCbx.Text + "'") + "'");


                foreach (Class_enrollments c in load_student)
                {
                    StudentCbx.Items.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        DormitryDataAdapter process_dorm = new DormitryDataAdapter();
        List<Dormitry> load_dormitry = new List<Dormitry>();
        public void load_dorm()
        {

            try
            {
                DormitryCbx.Items.Clear();
                load_dormitry = process_dorm.GetDormitryList("");

                foreach (Dormitry ee in load_dormitry)
                {

                    DormitryCbx.Items.Add(ee.dormitry_name);

                }
            }
            catch { }

        }
        private void ClassCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Students();
        }

        private void Student_dormitry_Load(object sender, EventArgs e)
        {
            Load_List();
            load_class();
            load_dorm();
            Btn_delete.Visible = false;
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {

                    Process_dormitry.deletedormitry_allocations("where id='"+get_id+"'");
                    Load_List();
                    clear();
                }
                else
                {
                    return;
                }
            }
            catch { }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Btn_save.Text = "Update";
            Btn_delete.Visible = true;
            get_id = int.Parse(e.Item.SubItems[0].Text);
            StudentCbx.Text = e.Item.SubItems[1].Text;
            DormitryCbx.Text = e.Item.SubItems[2].Text;
            ClassCbx.Text = e.Item.SubItems[3].Text;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
