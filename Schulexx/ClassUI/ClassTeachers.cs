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
    public partial class ClassTeachers : Form
    {
        public ClassTeachers()
        {
            InitializeComponent();
        }
        Class_heads Local_class_head = new Class_heads();
        ClassheadsDataAdpters Process_class_head = new ClassheadsDataAdpters();
        int get_id = 0;
        public void insert_update()
        {
            string[] mm = TeacherCbx.Text.Split(' ');
            Local_class_head.id = get_id;
            Local_class_head.class_id = int.Parse(new Connectoperations().singleval("classes", "class_id", "where cname='" + ClassCbx.Text + "'"));
            Local_class_head.class_teacherId = int.Parse(new Connectoperations().singleval("staff", "id", "where fname='" + mm[0] + "' and 	lname='" + mm[1] + "'"));

            if (get_id == 0)
            {
                Process_class_head.Insert(Local_class_head);
                clear();
                Load_List();
            }
            else
            {
                Process_class_head.Update(Local_class_head);
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

                Load_class = Process_class.GetClassesList("");

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

        List<Class_heads> Load_class_heads = new List<Class_heads>();

        public void Load_List()
        {
            try
            {
                //listView1.Items.Clear();
                Load_class_heads = Process_class_head.GetClass_headsList("");

                foreach (Class_heads c in Load_class_heads)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("classes", "cname", "where class_id='" + c.class_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("staff", "concat(fname,' ',lname)", "where id='" + c.class_teacherId + "'"));
                    //listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClassTeachers_Load(object sender, EventArgs e)
        {
            Load_List();
            load_class_list();
            load_staff_list();
            Btn_delete.Visible = false;
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            get_id = int.Parse(e.Item.SubItems[0].Text);
            ClassCbx.Text = e.Item.SubItems[1].Text;
            TeacherCbx.Text = e.Item.SubItems[2].Text;
            Btn_delete.Visible = true;
            Btn_save.Text = "Update";
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

                    Process_class_head.deleteclass_heads("where  id =" + get_id + "");
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}