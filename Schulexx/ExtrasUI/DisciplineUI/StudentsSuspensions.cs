using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Code;
using Schulexx.Data;
using Schulexx.Model;

namespace Schulexx.StudentsUI
{
    public partial class StudentsSuspensions : UserControl
    {
        public StudentsSuspensions()
        {
            InitializeComponent();
        }
        Suspensions local_susp = new Suspensions();
        SuspensionsDataAdapter Process_susp = new SuspensionsDataAdapter();
        int get_id = 0;
        public void insert_update()
        {

            string[] mm = student_cbx.Text.Split(' ');
            local_susp.id = get_id;
            local_susp.student_id = int.Parse(new Connectoperations().singleval("students", "student_id", "where fname='" + mm[0] + "' and lname='" + mm[1] + "'"));
            local_susp.date_of_suspension = dateTimePicker1.Value;
            //local_susp.return_date = dateTimePicker6.Value;
            local_susp.suspension_reasons = new Connectoperations().validate_All_Data(reason_txt.Text);
            if (get_id == 0)
            {
                Process_susp.Insert(local_susp);
                clear();
                list_load();
            }
            else
            {
                Process_susp.Update(local_susp);
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
            //dateTimePicker6.Value = DateTime.Now;
            btn_delete.Visible = false;
            btn_send.Visible = false;
            btn_print.Visible = false;
            btn_save.Text = "Save";

        }
        List<Suspensions> Load_sus = new List<Suspensions>();
        public void list_load()
        {
            listView1.Items.Clear();
            Load_sus = Process_susp.GetSuspensionsList("");
            foreach (Suspensions c in Load_sus)
            {
                ListViewItem pp = new ListViewItem();
                pp.Text = c.id.ToString();
                pp.SubItems.Add(new Connectoperations().singleval("students", "reg_number", "where student_id='" + c.student_id + "'"));
                pp.SubItems.Add(new Connectoperations().singleval("Students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                pp.SubItems.Add(c.date_of_suspension.ToShortDateString());
                pp.SubItems.Add(c.return_date.ToShortDateString());
                pp.SubItems.Add(c.suspension_reasons);
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
        private void StudentsSuspensions_Load(object sender, EventArgs e)
        {
            load_classes();
            list_load();
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }
            
        private void btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void stClass_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_students();
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
            //dateTimePicker6.Text = e.Item.SubItems[4].Text;
            reason_txt.Text = e.Item.SubItems[5].Text;
            stClass_cbx.Text = e.Item.SubItems[6].Text;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {

                    Process_susp.deletesupsensions("where id='"+get_id+"'");
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
