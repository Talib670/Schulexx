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

namespace Schulexx.ConfigureUI
{
    public partial class Time_SchdulesController : Form
    {
        public Time_SchdulesController()
        {
            InitializeComponent();
        }
        Timet_schedules Local_schedule = new Timet_schedules();
        Timet_schedulesDataAdpter Process_schedules = new Timet_schedulesDataAdpter();
        int get_id = 0;
        public void insert_update()
        {
            Local_schedule.id = get_id;
            Local_schedule.schedule_name = new Connectoperations().validate_All_Data(SchTbx.Text);
            Local_schedule.start_time = dateTimePicker1.Value;
            Local_schedule.End_time = dateTimePicker2.Value;
            Local_schedule.time_mode = tmode;
            if(get_id==0){
                Process_schedules.Insert(Local_schedule);
                clear();
                Load_List();
            }
            else
            {
                Process_schedules.Update(Local_schedule);
                clear();
                Load_List();
            }
        }
        string tmode;

        private void Am_Click(object sender, EventArgs e)
        {
            tmode = ((RadioButton)sender).Text;
        }

        private void Pm_Click(object sender, EventArgs e)
        {
            tmode = ((RadioButton)sender).Text;
        }

        public void clear()
        {
            get_id = 0;
            SchTbx.Clear();
            Btn_delete.Visible = false;
        }

        List<Timet_schedules> Load_tschedules = new List<Timet_schedules>();

        public void Load_List()
        {
            try
            {
                listView1.Items.Clear();
                Load_tschedules = Process_schedules.GetTimet_schedulesList("");

                foreach (Timet_schedules c in Load_tschedules)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(c.schedule_name);
                    pp.SubItems.Add(c.start_time.ToShortTimeString());
                    pp.SubItems.Add(c.End_time.ToShortTimeString());
                    pp.SubItems.Add(c.time_mode);

                    listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            get_id = int.Parse(e.Item.SubItems[0].Text);
            SchTbx.Text = e.Item.SubItems[1].Text;
            dateTimePicker1.Text = e.Item.SubItems[2].Text;
            dateTimePicker2.Text = e.Item.SubItems[3].Text;
            if (e.Item.SubItems[4].Text == "Am")
            {
                AmRbtn.Checked = true;
            }
            if (e.Item.SubItems[4].Text == "PM")
            {
                PmRbtn.Checked = true;
            }
            Btn_delete.Visible = true;
            Btn_save.Text = "Update";
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    Process_schedules.deletetimet_schedules("where id=" + get_id + "");
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

        private void Time_SchdulesController_Load(object sender, EventArgs e)
        {
            Load_List();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
