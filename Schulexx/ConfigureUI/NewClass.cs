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
    public partial class NewClass : Form
    {
        public NewClass()
        {
            InitializeComponent();
        }
        Classes Local_Class = new Classes();
        ClassesDataAdapter Process_Class = new ClassesDataAdapter();
        int get_id=0;

        public void insert_update()
        {
           try
            {
                Local_Class.class_id = get_id;
                Local_Class.full_name = Class_NameTbx.Text;
                Local_Class.cname = ShNameTbx.Text;
                Local_Class.level_id = int.Parse(new Connectoperations().singleval("levels", "id", "where Abbrev='" + Level_Cbx.Text + "'"));
                Local_Class.class_position = int.Parse(new Connectoperations().validate_All_Data(numericUpDown1.Text));

                if (get_id == 0)
                {
                    Process_Class.Insert(Local_Class);
                    clear();
                    Load_List();
                }
                else
                {
                    Process_Class.Update(Local_Class);
                    clear();
                    Load_List();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error - "+ex.Message,"Empty Fields",MessageBoxButtons.RetryCancel);
            }
        }
       
        LevelsDataAdapter Process_Levels = new LevelsDataAdapter();
        List<Levels> Load_Level = new List<Levels>();

        public void Load_List3()
        {
            try
            {
                Level_Cbx.Items.Clear();
                Load_Level = Process_Levels.GetLevelsList("");


                foreach (Levels c in Load_Level)
                {
                    Level_Cbx.Items.Add(c.Abbrev);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
        private void NewClass_Load(object sender, EventArgs e)
        {
            Load_List3();
            btn_delete.Visible = false;
            Load_List();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert_update();
            clear();
        }
        public void clear()
        {
            get_id = 0;
            Level_Cbx.SelectedIndex = -1;
            Class_NameTbx.Clear();
            button1.Text = "Save";

        }

        List<Classes> Load_Class = new List<Classes>();

        public void Load_List()
        {
            try
            {
                listView1.Items.Clear();
                Load_Class = Process_Class.GetClassesList("ORDER BY class_position ASC");


                foreach (Classes c in Load_Class)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.class_id.ToString();
                    pp.SubItems.Add(c.full_name);
                    pp.SubItems.Add(c.cname);
                    pp.SubItems.Add(new Connectoperations().singleval("levels", "Abbrev", "where id='" + c.level_id + "'"));
                    pp.SubItems.Add(c.class_position.ToString());
                    listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            get_id = int.Parse(e.Item.SubItems[0].Text);
            Class_NameTbx.Text = e.Item.SubItems[1].Text;
            ShNameTbx.Text = e.Item.SubItems[2].Text;
            Level_Cbx.Text = e.Item.SubItems[3].Text;
            numericUpDown1.Value = int.Parse(e.Item.SubItems[4].Text);
            btn_delete.Visible = true;
            button1.Text = "Update";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    Process_Class.deleteclasses("where class_id	='" + get_id + "'");
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


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        }
    }

