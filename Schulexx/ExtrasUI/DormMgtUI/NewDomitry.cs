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
    public partial class NewDomitry : Form
    {
        public NewDomitry()
        {
            InitializeComponent();
        }
        Dormitry Local_dormitry = new Dormitry();
        DormitryDataAdapter Process_dormitry = new DormitryDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            string[] mm = PatronTxt.Text.Split(' ');
            Local_dormitry.id = get_id;
            Local_dormitry.dormitry_name = new Connectoperations().validate_All_Data(DnameTxt.Text);
            Local_dormitry.dormitry_leader = int.Parse(new Connectoperations().singleval("staff", "id", "where fname='" + mm[0] + "' and 	lname='" + mm[1] + "'"));
            if (get_id == 0)
            {
                Process_dormitry.Insert(Local_dormitry);
                clear();
                Load_List();
            }
            else
            {
                Process_dormitry.Update(Local_dormitry);
                clear();
                Load_List();
            }
        }

        public void clear()
        {
            Btn_delete.Visible = false;
            Btn_save.Text = "Save";
            DnameTxt.Clear();
            PatronTxt.SelectedIndex = -1;
        }

        List<Staff> Load_staff = new List<Staff>();
        StaffDataAdapter Process_staff = new StaffDataAdapter();

        public void load_staff_list()
        {
            try
            {
                PatronTxt.Items.Clear();

                Load_staff = Process_staff.GetStaffList("where staff_type= 'Non Teaching Staff' ");

                foreach (Staff c in Load_staff)
                {
                    PatronTxt.Items.Add(c.fname + " " + c.lname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        List<Dormitry> Load_dormitry = new List<Dormitry>();

        public void Load_List()
        {
            try
            {
                listView1.Items.Clear();
                Load_dormitry = Process_dormitry.GetDormitryList("");

                foreach (Dormitry c in Load_dormitry)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(c.dormitry_name);
                    pp.SubItems.Add(new Connectoperations().singleval("staff", "concat(fname,' ',lname)", "where id='" + c.dormitry_leader + "'"));

                    listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void NewDomitry_Load(object sender, EventArgs e)
        {
            load_staff_list();
            Load_List();
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
                    Process_dormitry.deletedormitry("where id='" + get_id + "'");
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
            Btn_delete.Visible = true;
            Btn_save.Text = "Update";
            get_id = int.Parse(e.Item.SubItems[0].Text);
            DnameTxt.Text = e.Item.SubItems[1].Text;
            PatronTxt.Text = e.Item.SubItems[2].Text;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
