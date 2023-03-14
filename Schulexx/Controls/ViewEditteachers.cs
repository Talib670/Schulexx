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

namespace Schulexx.Controls
{
    public partial class ViewEditteachers : UserControl
    {
        public ViewEditteachers()
        {
            InitializeComponent();
        }
        StaffDataAdapter Process_staff = new StaffDataAdapter();
        List<Staff> load_staff = new List<Staff>();
        public void load_list()
        {

            listView1.Items.Clear();

            load_staff = Process_staff.GetStaffList("where staff_type='Teaching Staff'");
            foreach (Staff c in load_staff)
            {

                ListViewItem pp = new ListViewItem();
                pp.Text = c.id.ToString();
                pp.SubItems.Add(c.staffNo);
                pp.SubItems.Add(c.fname+' '+c.lname);
                pp.SubItems.Add(c.Gender);
                pp.SubItems.Add(c.maritalStatus);
                pp.SubItems.Add(c.phoneNumber);
                pp.SubItems.Add(c.district);
                pp.SubItems.Add(c.currentResidence);
                pp.SubItems.Add(c.nationality);
                pp.SubItems.Add(c.staff_type);
                pp.SubItems.Add(c.DOB.ToShortDateString());
                pp.SubItems.Add(c.Staff_initials);
                pp.SubItems.Add(c.EmailAddress);

                listView1.Items.Add(pp);
            }
        }

        private void ViewEditteachers_Load(object sender, EventArgs e)
        {
            load_list();
            BtnAsgnStud.Visible = false;
            BtnAsgnCls.Visible = false;
            BtnAsgnSub.Visible = false;
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            BtnAsgnStud.Visible = true;
            BtnAsgnCls.Visible = true;
            BtnAsgnSub.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_list();
            BtnAsgnStud.Visible = false;
            BtnAsgnCls.Visible = false;
            BtnAsgnSub.Visible = false;
            TeacherTbx.Clear();
        }
    }
}
