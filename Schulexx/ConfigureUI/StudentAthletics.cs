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
    public partial class StudentAthletics : Form
    {
        public StudentAthletics()
        {
            InitializeComponent();
        }
        Studentathletics local_athletics = new Studentathletics();
        Student_athleticsDataAdapters process_athletics = new Student_athleticsDataAdapters();
        int get_id = 0;
        public void insert_update()
        {
            string[] pp = patron_cbx.Text.Split(' ');
            local_athletics.id = get_id;
            local_athletics.sp_name = new Connectoperations().validate_All_Data(Spname_txt.Text);
            local_athletics.stf_patronId = int.Parse(new Connectoperations().singleval("staff", "id", "where fname='" + pp[0] + "'and lname='" + pp[1] + "'"));
            local_athletics.designed_for = SpGender;
            if (get_id == 0)
            {
                process_athletics.Insert(local_athletics);
                load_list();
                clear();
            }
            else
            {
                process_athletics.Update(local_athletics);
                load_list();
                clear();
            }
        }
        string SpGender = "Girls";

        private void radioButton1_Click(object sender, EventArgs e)
        {
            SpGender = ((RadioButton)sender).Text;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            SpGender = ((RadioButton)sender).Text;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            SpGender = ((RadioButton)sender).Text;
        }
        public void clear()
        {
            get_id = 0;
            Spname_txt.Clear();
            patron_cbx.SelectedIndex = -1;
            radioButton1.Checked = true;
            button2.Text = "Save";
        }

        List<Studentathletics> Load_athletics = new List<Studentathletics>();
        public void load_list()
        {
            listView1.Items.Clear();
            Load_athletics = process_athletics.GetStudentathleticsList("");
            foreach (Studentathletics c in Load_athletics)
            {
                ListViewItem pp = new ListViewItem();
                pp.Text = c.id.ToString();
                pp.SubItems.Add(c.sp_name);
                pp.SubItems.Add(new Connectoperations().singleval("staff", "concat(fname,' ',lname)", "where id='" + c.stf_patronId + "'"));
                pp.SubItems.Add(c.designed_for);

                listView1.Items.Add(pp);
            }

        }
        List<Staff> staff_load = new List<Staff>();
        StaffDataAdapter process_staff = new StaffDataAdapter();
        public void load_patrons()
        {
            patron_cbx.Items.Clear();
            staff_load = process_staff.GetStaffList();
            foreach (Staff c in staff_load)
            {
                patron_cbx.Items.Add(c.fname + ' ' + c.lname);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void StudentAthletics_Load(object sender, EventArgs e)
        {
            load_patrons();
            load_list();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
