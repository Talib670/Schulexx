using System;
using System.IO;
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
    public partial class SchoolDetails : Form
    {
        public SchoolDetails()
        {
            InitializeComponent();
        }
        School_details Local_school = new School_details();
        School_detailsDataAdapter Process_school = new School_detailsDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            Local_school.id = get_id;
            Local_school.school_name = new Connectoperations().validate_All_Data(sch_nametxt.Text);
            Local_school.motto = new Connectoperations().validate_All_Data(Mottotxt.Text);
            Local_school.PhysicalAddress = new Connectoperations().validate_All_Data(phy_addtxt.Text);
            Local_school.Telephone = new Connectoperations().validate_All_Data(Tel1_txt.Text);
            Local_school.email_address = new Connectoperations().validate_All_Data(emailTxt.Text);
            Local_school.website = new Connectoperations().validate_All_Data(webtxt.Text);
            Local_school.Abbreviation = new Connectoperations().validate_All_Data(tbAbbreviation.Text);
            if (SchoolLogoPbx.Image == null)
            {
                
            }
            else
            {
            }
            if(get_id==0){

                Process_school.Insert(Local_school, Local_school.logo);
                clear();
                Load_List();
            }
            else
            {
                Process_school.Update(Local_school, Local_school.logo);
                clear();
                Load_List();
            }
        }

        private void SchoolDetails_Load(object sender, EventArgs e)
        {
            //Delete_btn.Visible = false;
            Load_List();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        public void clear()
        {
            get_id = 0;
            BtnSave.Text = "Save";
            SchoolLogoPbx.Image = null;
            sch_nametxt.Clear();
            webtxt.Clear();
            Mottotxt.Clear();
            emailTxt.Clear();
            phy_addtxt.Clear();
            Tel1_txt.Clear();
            tbAbbreviation.Clear();
        }

        List<School_details> Load_Sch = new List<School_details>();
        Dictionary<int, byte[]> PhotesIn = new Dictionary<int, byte[]>();
        private void Load_List()
        {
            try
            {
                //listView1.Items.Clear();
                PhotesIn.Clear();
                Load_Sch = Process_school.GetSchool_detailsList();


                foreach (School_details c in Load_Sch)
                {
                    PhotesIn.Add(c.id, c.logo);

                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(c.school_name);
                    pp.SubItems.Add(c.motto);
                    pp.SubItems.Add(c.PhysicalAddress);
                    pp.SubItems.Add(c.Telephone);
                    pp.SubItems.Add(c.email_address);
                    pp.SubItems.Add(c.website);
                    pp.SubItems.Add(c.Abbreviation);

                    //listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                BtnSave.Text = "Update";
                get_id = int.Parse(e.Item.SubItems[0].Text);
                sch_nametxt.Text = e.Item.SubItems[1].Text;
                Mottotxt.Text = e.Item.SubItems[2].Text;
                phy_addtxt.Text = e.Item.SubItems[3].Text;
                Tel1_txt.Text = e.Item.SubItems[4].Text;
                emailTxt.Text = e.Item.SubItems[5].Text;
                webtxt.Text = e.Item.SubItems[6].Text;
                tbAbbreviation.Text = e.Item.SubItems[7].Text;

                //int x = e.Item.Index;
            }
            catch { }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }
    }

