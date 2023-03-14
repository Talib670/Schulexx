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
using Schulexx.Controls;
using Schulexx.Data;
using Schulexx.Model;

namespace Schulexx.ConfigureUI
{
    public partial class NewLevel : Form
    {
        public NewLevel()
        {
            InitializeComponent();
        }
        Levels Local_Level = new Levels();
        LevelsDataAdapter Process_Level = new LevelsDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            Local_Level.id = get_id;
            Local_Level.name = new Connectoperations().validate_All_Data(LeveL_Txt.Text);
            Local_Level.Abbrev = new Connectoperations().validate_All_Data(Initial_txt.Text);

            if (get_id == 0){
                Process_Level.Insert(Local_Level);
                clear();
                load_list();
            }

            else
            {
                Process_Level.Update(Local_Level);
                clear();
                load_list();
            }
                
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewLevel_Load(object sender, EventArgs e)
        {
            Delete_Button.Visible = false;
            load_list();
        }

        public void clear()
        {
            get_id = 0;
            LeveL_Txt.Clear();
            Initial_txt.Clear();
            Save_Button.Text = "Save";
            Delete_Button.Visible = false;
        }

        List<Levels> Load_levels = new List<Levels>();
        public void load_list()
        {
            try { 
            
            listView1.Items.Clear();
                Load_levels = Process_Level.GetLevelsList("");


                foreach (Levels c in Load_levels)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(c.name);
                    pp.SubItems.Add(c.Abbrev);
                    listView1.Items.Add(pp);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        private void Save_Button_Click(object sender, EventArgs e)
        {
            insert_update();
            clear();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Delete_Button.Visible = true;
            Save_Button.Text = "Update";
            get_id = int.Parse(e.Item.SubItems[0].Text);
            LeveL_Txt.Text = e.Item.SubItems[1].Text;
            Initial_txt.Text = e.Item.SubItems[2].Text;
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {

                    Process_Level.deletelevels("where id=" + get_id + "");
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


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
