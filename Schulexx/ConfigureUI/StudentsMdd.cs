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
    public partial class StudentsMdd : Form
    {
        public StudentsMdd()
        {
            InitializeComponent();
        }
        Mdd local_mmd = new Mdd();
        MddDataAdapter process_mdd = new MddDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            string[] mm = chl_cbx.Text.Split(' ');
            string[] pp = chp_cbx.Text.Split(' ');
            local_mmd.id = get_id;
            local_mmd.ch_name = new Connectoperations().validate_All_Data(chname_txt.Text);
            local_mmd.ch_leader = int.Parse(new Connectoperations().singleval("students", "student_id", "where fname='" + mm[0] + "'and lname='" + mm[1] + "'"));
            local_mmd.ch_patron = int.Parse(new Connectoperations().singleval("staff", "id", "where fname='" + pp[0] + "'and lname='" + pp[1] + "'"));
            local_mmd.ch_type = new Connectoperations().validate_All_Data(Ctype);
            if (get_id == 0)
            {
                process_mdd.Insert(local_mmd);
                load_list();
                clear();
            }
            else
            {
                process_mdd.Update(local_mmd);
                load_list();
                clear();
            }
        }

        
        public void clear()
        {
            get_id = 0;
            chname_txt.Clear();
            chl_cbx.SelectedIndex = -1;
            chp_cbx.SelectedIndex = -1;
            radioButton1.Checked = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        List<Students> load_students = new List<Students>();
        StudentsDataAdapter process_students = new StudentsDataAdapter();
        public void stud_combo()
        {
            chl_cbx.Items.Clear();
            load_students = process_students.GetStudentsList("");
            foreach (Students c in load_students)
            {
                chl_cbx.Items.Add(c.fname + ' ' + c.lname);
            }
        }
        List<Staff> staff_load = new List<Staff>();
        StaffDataAdapter process_staff = new StaffDataAdapter();
        public void load_patrons()
        {
            chp_cbx.Items.Clear();
            staff_load = process_staff.GetStaffList();
            foreach (Staff c in staff_load)
            {
                chp_cbx.Items.Add(c.fname + ' ' + c.lname);
            }
        }
        List<Mdd> Load_mdd = new List<Mdd>();
        public void load_list()
        {
            listView1.Items.Clear();
            Load_mdd = process_mdd.GetMddList("");
            foreach (Mdd c in Load_mdd)
            {
                ListViewItem pp = new ListViewItem();
                pp.Text = c.id.ToString();
                pp.SubItems.Add(c.ch_name);
                pp.SubItems.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + c.ch_leader + "'"));
                pp.SubItems.Add(new Connectoperations().singleval("staff", "concat(fname,' ',lname)", "where id='" + c.ch_patron + "'"));
                pp.SubItems.Add(c.ch_type);

                listView1.Items.Add(pp);
            }

        }

        private void StudentsMdd_Load(object sender, EventArgs e)
        {
            stud_combo();
            load_patrons();
            load_list();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
        string Ctype = "Music";
        private void radioButton1_Click(object sender, EventArgs e)
        {
            Ctype = ((RadioButton)sender).Text;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            Ctype = ((RadioButton)sender).Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Ctype = ((RadioButton)sender).Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
