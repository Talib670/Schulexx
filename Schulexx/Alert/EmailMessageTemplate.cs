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
using Schulexx.Data;
using Schulexx.Model;

namespace Schulexx.AlertUI
{
    public partial class EmailMessageTemplate : Form
    {
        public EmailMessageTemplate()
        {
            InitializeComponent();
        }
        Alertreminders Local_aRsms = new Alertreminders();
        AlertremindersDataAdapter Process_aRsms = new AlertremindersDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            Local_aRsms.id = get_id;
            Local_aRsms.rbody = new Connectoperations().validate_All_Data(msgTbx.Text);
            Local_aRsms.title = new Connectoperations().validate_All_Data(Email_Tbx.Text);
            Local_aRsms.message_type = "email";
            if (get_id == 0)
            {
                Process_aRsms.Insert(Local_aRsms);
                clear();
                Load_List();
            }
            else
            {
                Process_aRsms.Update(Local_aRsms);
                clear();
                Load_List();
            }
        }

        public void clear()
        {
            get_id = 0;
            Btn_delete.Visible = false;
            Btn_save.Text = "Save";
            Email_Tbx.Clear();
            msgTbx.Clear();

        }

        List<Alertreminders> Load_aRsms = new List<Alertreminders>();

        public void Load_List()
        {
            try
            {
                listView1.Items.Clear();
                Load_aRsms = Process_aRsms.GetAlertremindersList("where message_type='email'");

                foreach (Alertreminders c in Load_aRsms)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(c.title);
                    pp.SubItems.Add(c.rbody);

                    listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    Process_aRsms.deletealertreminders("where id='" + get_id + "'");
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
            get_id = int.Parse(e.Item.SubItems[0].Text);
            Email_Tbx.Text = e.Item.SubItems[1].Text;
            msgTbx.Text = e.Item.SubItems[2].Text;
            Btn_delete.Visible = true;
            Btn_save.Text = "Update";
        }

        private void EmailMessageTemplate_Load(object sender, EventArgs e)
        {
            Btn_delete.Visible = false;
            Load_List();
        }
    }
}
