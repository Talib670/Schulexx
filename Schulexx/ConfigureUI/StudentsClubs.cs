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
    public partial class StudentsClubs : Form
    {
        public StudentsClubs()
        {
            InitializeComponent();
        }
        Studentclubs local_club = new Studentclubs();
        StudentclubsDataAdapter Process_club = new StudentclubsDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            string[] mm = leader_cbx.Text.Split(' ');
            string[] pp = patron_cbx.Text.Split(' ');
            local_club.id = get_id;
            local_club.club_name = new Connectoperations().validate_All_Data(textBox_cname.Text);
            local_club.club_type = new Connectoperations().validate_All_Data(cBox_ctype.Text);
            local_club.stLeader_id = int.Parse(new Connectoperations().singleval("students", "student_id", "where fname='"+mm[0]+"'and lname='"+mm[1]+"'"));
            local_club.stfpatron_id = int.Parse(new Connectoperations().singleval("staff", "id", "where fname='" + pp[0] + "'and lname='" + pp[1] + "'"));
            local_club.status = Cstatus;
            local_club.activities_descr = new Connectoperations().validate_All_Data(activity_txt.Text);
            if (get_id == 0)
            {
                Process_club.Insert(local_club);
                load_list();
                clear();
            }
            else
            {
                Process_club.Update(local_club);
                load_list();
                clear();
            }
        }
        public void clear()
        {
            get_id = 0;
            textBox_cname.Clear();
            cBox_ctype.SelectedIndex = -1;
            leader_cbx.SelectedIndex = -1;
            patron_cbx.SelectedIndex = -1;
            radioButton1.Checked = true;
        }
        List<Students> load_students = new List<Students>();
        StudentsDataAdapter process_students = new StudentsDataAdapter();
        public void stud_combo()
        {
            leader_cbx.Items.Clear();
            load_students = process_students.GetStudentsList("");
            foreach(Students c in load_students){
                leader_cbx.Items.Add(c.fname + ' ' + c.lname);
            }
        }
        List<Staff> staff_load = new List<Staff>();
        StaffDataAdapter process_staff = new StaffDataAdapter();
        public void load_patrons()
        {
            patron_cbx.Items.Clear();
            staff_load = process_staff.GetStaffList();
            foreach(Staff c in staff_load){
                patron_cbx.Items.Add(c.fname + ' ' + c.lname);
            }
        }
        List<Studentclubs> Load_clubs = new List<Studentclubs>();
        public void load_list()
        {
            listView1.Items.Clear();
            Load_clubs = Process_club.GetStudentclubsList("");
            foreach (Studentclubs c in Load_clubs)
            {
                ListViewItem pp = new ListViewItem();
                pp.Text = c.id.ToString();
                pp.SubItems.Add(c.club_name);
                pp.SubItems.Add(c.club_type);
                pp.SubItems.Add(new Connectoperations().singleval("students","concat(fname,' ',lname)","where student_id='"+c.stLeader_id+"'"));
                pp.SubItems.Add(new Connectoperations().singleval("staff", "concat(fname,' ',lname)", "where id='" + c.stfpatron_id + "'"));
                pp.SubItems.Add(c.status);
                pp.SubItems.Add(c.activities_descr);

                listView1.Items.Add(pp);
            }
            
        }
        private void StudentsClubs_Load(object sender, EventArgs e)
        {
            stud_combo();
            load_patrons();
            load_list();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        string Cstatus = "Active";
        private void radioButton1_Click(object sender, EventArgs e)
        {
            Cstatus = ((RadioButton)sender).Text;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            Cstatus = ((RadioButton)sender).Text;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    Process_club.deletestudentclubs("where id=" + get_id + "");
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

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btn_delete.Visible = false;
            btn_save.Text = "Update";
            get_id = int.Parse(e.Item.SubItems[0].Text);
            textBox_cname.Text = e.Item.SubItems[1].Text;
            cBox_ctype.Text = e.Item.SubItems[2].Text;
            leader_cbx.Text = e.Item.SubItems[3].Text;
            patron_cbx.Text = e.Item.SubItems[4].Text;
            if (e.Item.SubItems[5].Text == "Active")
                radioButton1.Checked = true;
            else if (e.Item.SubItems[5].Text == "Inactive")
                radioButton2.Checked = true;
            activity_txt.Text = e.Item.SubItems[6].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
