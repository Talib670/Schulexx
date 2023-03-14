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

namespace Schulexx.StudentsUI
{
    public partial class StudentsPassouts : UserControl
    {
        public StudentsPassouts()
        {
            InitializeComponent();
        }
        Passouts Local_pass = new Passouts();
        PassoutsDataAdapter Process_pass = new PassoutsDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            string[] mm = student_cbx.Text.Split(' ');
            Local_pass.id = get_id;
            Local_pass.student_id = int.Parse(new Connectoperations().singleval("students", "student_id", "where fname='"+ mm[0]+"' and lname='"+ mm[1] +"'"));
            Local_pass.date_issued = dateTimePicker1.Value;
            //Local_pass.returned_date = dateTimePicker6.Value;
            Local_pass.reason = new Connectoperations().validate_All_Data(reason_txt.Text);
            if (get_id == 0)
            {
                Process_pass.Insert(Local_pass);
                clear();
                list_load();
            }
            else
            {
                Process_pass.Update(Local_pass);
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
            //snd_btn.Visible = false;
            btn_print.Visible = false;
            btn_save.Text = "Save";

        }
        List<Passouts> Load_pass = new List<Passouts>();
        public void list_load()
        {
            listView1.Items.Clear();
            Load_pass=Process_pass.GetPassoutsList("");
            foreach(Passouts c in Load_pass){
                ListViewItem pp = new ListViewItem();
                pp.Text = c.id.ToString();
                pp.SubItems.Add(new Connectoperations().singleval("students", "reg_number", "where student_id='"+c.student_id+"'"));
                pp.SubItems.Add(new Connectoperations().singleval("Students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                pp.SubItems.Add(c.date_issued.ToShortDateString());
                pp.SubItems.Add(c.returned_date.ToShortDateString());
                pp.SubItems.Add(c.reason);
                pp.SubItems.Add(new Connectoperations().singleval("classes", "cname", "where class_id='" + new Connectoperations().singleval("class_enrollments", "class_id", "where student_id='" + c.student_id + "'") + "'"));

                listView1.Items.Add(pp);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

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
        List<Students> stud_lod = new List<Students>();
        StudentsDataAdapter process_stud = new StudentsDataAdapter();
        public void stud_info()
        {
            string[] mm = student_cbx.Text.Split(' ');
            stud_lod = process_stud.GetStudentsList("where fname ='"+mm[0]+"' and lname='"+mm[1]+"'");
            foreach(Students h in stud_lod){

            }
        }
        private void StudentsPassouts_Load(object sender, EventArgs e)
        {
            list_load();
            load_classes();
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            btn_delete.Visible = false;
            //snd_btn.Visible = false;
            btn_print.Visible = false;
        }

        private void student_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stClass_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_students();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            get_id = int.Parse(e.Item.SubItems[0].Text);
            student_cbx.Text = e.Item.SubItems[2].Text;
            dateTimePicker1.Text = e.Item.SubItems[3].Text;
            //dateTimePicker6.Text = e.Item.SubItems[4].Text;
            reason_txt.Text = e.Item.SubItems[5].Text;
            stClass_cbx.Text = e.Item.SubItems[6].Text;
            btn_delete.Visible = true;
            btn_save.Text = "Update";
            btn_print.Visible = true;
            //snd_btn.Visible = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    Process_pass.deletepassouts("where get_id='"+get_id+"'");
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
