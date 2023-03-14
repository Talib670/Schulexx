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

namespace Schulexx.AttendanceUI
{
    public partial class StaffAttendance : UserControl
    {
        public StaffAttendance()
        {
            InitializeComponent();
        }
        Staff_attendances Local_stfAtt = new Staff_attendances();
        Staff_attendancesDataAdapter Process_stfAtt = new Staff_attendancesDataAdapter();
        int get_id = 0;
        int stf_id;
        public void insert_update()
        {
            Local_stfAtt.id = get_id;
            Local_stfAtt.staffID = stf_id;
            Local_stfAtt.Astatus = Att_status;
            Local_stfAtt.Date = dateTimePicker1.Value;
            if (get_id == 0)
            {
                Process_stfAtt.Insert(Local_stfAtt);
                load_list();
                load_list2();
            }
            else
            {
                Btn_save.Text = "Change Status";
                Process_stfAtt.Update(Local_stfAtt);
                load_list();
                load_list2();
            }
        }

        StaffDataAdapter Process_Staff = new StaffDataAdapter();
        List<Staff> Staff_load = new List<Staff>();
        public void load_list()
        {
            try
            {
                listView1.Items.Clear();
                Staff_load = Process_Staff.GetStaffList("where staff_type='" + StaffTypeCbx.Text + "'");
                foreach (Staff c in Staff_load)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(c.staffNo);
                    pp.SubItems.Add(c.fname+' '+c.lname);
                    pp.SubItems.Add(c.currentResidence);

                    listView1.Items.Add(pp);
                }

            }
            catch { }

        }

        List<Staff_attendances> load_stfAttd = new List<Staff_attendances>();
        public void load_list2()
        {

            listView2.Items.Clear();
            load_stfAttd = Process_stfAtt.GetStaff_attendancesList("where staffID ='" + new Connectoperations().singleval("staff", "id", "where staff_type='" + StaffTypeCbx.Text + "'") + "' and Date='" + new Connectoperations().mysqldate_only(dateTimePicker1.Value) + "'");

            foreach (Staff_attendances c in load_stfAttd)
            {
                ListViewItem pp = new ListViewItem();

                pp.Text = c.id.ToString();
                pp.SubItems.Add(new Connectoperations().singleval("staff", "concat(fname,' ',lname)", "where id='" + c.staffID + "'"));
                pp.SubItems.Add(new Connectoperations().singleval("staff", "Gender", "where id='" + c.staffID + "'"));
                pp.SubItems.Add(c.Date.ToShortDateString());
                pp.SubItems.Add(new Connectoperations().singleval("staff_attendances", "Astatus", "where staffID='" + c.staffID + "' and date='" + new Connectoperations().mysqldate_only(dateTimePicker1.Value) + "'"));

                listView2.Items.Add(pp);


            }
        }

        private void StaffTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_list();
            load_list2();
            groupBox2.Text = "Attendance List For" + ' ' + StaffTypeCbx.Text + ' ' + "at" + ' ' + dateTimePicker1.Text;
        }
        string Att_status = "Present";

        private void PresentRbtn_Click(object sender, EventArgs e)
        {
            Att_status = ((RadioButton)sender).Text;
        }

        private void AbsentRbtn_Click(object sender, EventArgs e)
        {
            Att_status = ((RadioButton)sender).Text;
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            stf_id = int.Parse(e.Item.SubItems[0].Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            load_list2();
            groupBox2.Text = "Attendance List For" + ' ' + StaffTypeCbx.Text + ' ' + "at" + ' ' + dateTimePicker1.Text;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

    }
}
