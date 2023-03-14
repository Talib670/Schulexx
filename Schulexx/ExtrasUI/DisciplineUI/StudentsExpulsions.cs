using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Data;
using Schulexx.Code;
using Schulexx.Model;

namespace Schulexx.StudentsUI
{
    public partial class StudentsExpulsions : UserControl
    {
        public StudentsExpulsions()
        {
            InitializeComponent();
        }
        Expulsion local_exp = new Expulsion();
        ExpulsionsDataAdapter process_exp = new ExpulsionsDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            string[] mm = student_cbx.Text.Split(' ');
            local_exp.id = get_id;
            local_exp.student_id = int.Parse(new Connectoperations().singleval("students", "student_id", "where fname='" + mm[0] + "' and lname='" + mm[1] + "'"));
            local_exp.DateIssued = dateTimePicker1.Value;
            local_exp.Reason = new Connectoperations().validate_All_Data(reason_txt.Text);
            if (get_id == 0)
            {
                process_exp.Insert(local_exp);
                clear();
                list_load();
            }
            else
            {
                process_exp.Update(local_exp);
                clear();
                list_load();
            }
        }

        public void clear()
        {
            get_id = 0;
            stClass_cbx.SelectedIndex = -1;
            student_cbx.SelectedIndex = -1;
            reason_txt.Clear();
            dateTimePicker1.Value = DateTime.Now;
            btn_delete.Visible = false;
            btn_send.Visible = false;
            btn_print.Visible = false;
            btn_save.Text = "Save";

        }
        List<Expulsion> Load_exp = new List<Expulsion>();
        public void list_load()
        {
            listView1.Items.Clear();
            Load_exp = process_exp.GetExpulsionList("");
            foreach (Expulsion c in Load_exp)
            {
                ListViewItem pp = new ListViewItem();
                pp.Text = c.id.ToString();
                pp.SubItems.Add(new Connectoperations().singleval("students", "reg_number", "where student_id='" + c.student_id + "'"));
                pp.SubItems.Add(new Connectoperations().singleval("Students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                pp.SubItems.Add(c.DateIssued.ToShortDateString());
                pp.SubItems.Add(c.Reason);
                pp.SubItems.Add(new Connectoperations().singleval("classes", "cname", "where class_id='" + new Connectoperations().singleval("class_enrollments", "class_id", "where student_id='" + c.student_id + "'") + "'"));
                listView1.Items.Add(pp);
            }
        }
        List<Classes> class_lod = new List<Classes>();
        ClassesDataAdapter process_class = new ClassesDataAdapter();
        public void load_classes()
        {
            stClass_cbx.Items.Clear();
            class_lod = process_class.GetClassesList("");
            foreach (Classes F in class_lod)
            {
                stClass_cbx.Items.Add(F.cname);
            }

        }
        ClassEnrollmentsDataAdapter process_enrol = new ClassEnrollmentsDataAdapter();
        List<Class_enrollments> load_stud = new List<Class_enrollments>();
        public void load_students()
        {
            student_cbx.Items.Clear();
            load_stud = process_enrol.GetClass_enrollmentsList("where class_id='" + new Connectoperations().singleval("classes", "class_id", "where cname='" + stClass_cbx.Text + "'") + "'");
            foreach (Class_enrollments J in load_stud)
            {
                student_cbx.Items.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + J.student_id + "'"));
            }
        }
        private void StudentsExpulsions_Load(object sender, EventArgs e)
        {
            list_load();
            load_classes();
            btn_delete.Visible = false;
            btn_print.Visible = false;
            btn_send.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void stClass_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_students();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btn_save.Text = "Update";
            btn_delete.Visible = true;
            btn_print.Visible = true;
            btn_send.Visible = true;
            get_id = int.Parse(e.Item.SubItems[0].Text);
            student_cbx.Text = e.Item.SubItems[2].Text;
            dateTimePicker1.Text = e.Item.SubItems[3].Text;
            reason_txt.Text = e.Item.SubItems[4].Text;
            stClass_cbx.Text = e.Item.SubItems[5].Text;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {

                    process_exp.deleteexpulsion("where id ='" + get_id + "'");
                    list_load();
                    clear();
                }
                else
                {
                    return;
                }
            }
            catch { }
        }

    }
}
