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
    public partial class NewSubjects : Form
    {
        public NewSubjects()
        {
            InitializeComponent();
        }
        Subjects Local_subject = new Subjects();
        SubjectsDataAdapter Process_subject = new SubjectsDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            Local_subject.subject_id = get_id;
            Local_subject.subject_code = int.Parse(new Connectoperations().validate_All_Data(subjCodeTbx.Text));
            Local_subject.sname = new Connectoperations().validate_All_Data(subjectName_txt.Text);
            Local_subject.sub_short = new Connectoperations().validate_All_Data(abbrevTbx.Text);
            Local_subject.category_id = int.Parse(new Connectoperations().singleval("subject_category", "id", "where category='"+category_cbx.Text+"'"));
            Local_subject.compulsory = Scomp;
            if(get_id==0){
                Process_subject.Insert(Local_subject);
                clear();
                Load_List();
            }
            else
            {
                Process_subject.Update(Local_subject);
                clear();
                Load_List();
            }
        }

        public void clear()
        {
            get_id = 0;
            Btn_delete.Visible = false;
            save_btn.Text = "Save";
            subjectName_txt.Clear();
            category_cbx.SelectedIndex = -1;
            subjCodeTbx.Clear();
            abbrevTbx.Clear();
            subjCodeTbx.Select();
            yesRbtn.Checked = true;
        }

        List<Subject_category> Load_SubCat = new List<Subject_category>();
        Subject_categoryDataAdapter Process_subcat = new Subject_categoryDataAdapter();
        public void Load_subcat()
        {
            category_cbx.Items.Clear();
            Load_SubCat = Process_subcat.GetSubject_categoryList("");
            foreach (Subject_category c in Load_SubCat)
            {
                category_cbx.Items.Add(c.category);
            }
        }

        List<Subjects> Load_Subject = new List<Subjects>();

        public void Load_List()
        {
            try
            {
                //listView1.Items.Clear();
                Load_Subject = Process_subject.GetSubjectsList("");


                foreach (Subjects c in Load_Subject)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.subject_id.ToString();
                    pp.SubItems.Add(c.subject_code.ToString());
                    pp.SubItems.Add(c.sname);
                    pp.SubItems.Add(new Connectoperations().singleval("subject_category", "category", "where id='"+c.category_id+"'"));
                    pp.SubItems.Add(c.compulsory);
                    pp.SubItems.Add(c.sub_short);
                    //listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void save_btn_Click(object sender, EventArgs e)
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

                    Process_subject.deletesubjects("where subject_id=" + get_id + "");
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
            save_btn.Text = "Update";
            get_id = int.Parse(e.Item.SubItems[0].Text);
            subjCodeTbx.Text = e.Item.SubItems[1].Text;
            subjectName_txt.Text = e.Item.SubItems[2].Text;
            category_cbx.Text = e.Item.SubItems[3].Text;
            if (e.Item.SubItems[4].Text == "Yes")
            {
                yesRbtn.Checked=true;
            }
            if (e.Item.SubItems[4].Text == "No")
            {
                NoRbtn.Checked = true;
            }

            abbrevTbx.Text = e.Item.SubItems[5].Text;
        }

        private void NewSubjects_Load(object sender, EventArgs e)
        {
            Btn_delete.Visible = false;
            Load_List();
            Load_subcat();
        }
        string Scomp;

        private void yesRbtn_Click(object sender, EventArgs e)
        {
            Scomp = ((RadioButton)sender).Text;
        }

        private void NoRbtn_Click(object sender, EventArgs e)
        {
            Scomp = ((RadioButton)sender).Text;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
