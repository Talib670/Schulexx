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
    public partial class Alevel_subjects : Form
    {
        public Alevel_subjects()
        {
            InitializeComponent();
        }
        Subjects_alevel Local_ALsubject = new Subjects_alevel();
        Subjects_alevelDataAdapter Process_ALsubject = new Subjects_alevelDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            Local_ALsubject.id = get_id;
            Local_ALsubject.subj_name = new Connectoperations().validate_All_Data(subjectName_txt.Text);
            Local_ALsubject.category_id = int.Parse(new Connectoperations().singleval("subject_category", "id", "where category='"+category_cbx.Text+"'"));
            Local_ALsubject.subj_code = int.Parse(new Connectoperations().validate_All_Data(subjCodeTbx.Text));
            Local_ALsubject.subj_short = new Connectoperations().validate_All_Data(abbrevTbx.Text);
            Local_ALsubject.subj_type = new Connectoperations().validate_All_Data(SubtypeCbx.Text);
            if(get_id==0){
                Process_ALsubject.Insert(Local_ALsubject);
                clear();
                Load_List();
            }else{
                Process_ALsubject.Update(Local_ALsubject);
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
            SubtypeCbx.SelectedIndex = -1;
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

        List<Subjects_alevel> Load_Subjects = new List<Subjects_alevel>();

        public void Load_List()
        {
            try
            {
                listView1.Items.Clear();
                Load_Subjects = Process_ALsubject.GetSubjects_alevelList("");


                foreach (Subjects_alevel c in Load_Subjects)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(c.subj_code.ToString());
                    pp.SubItems.Add(c.subj_name);
                    pp.SubItems.Add(new Connectoperations().singleval("subject_category", "category", "where id='" + c.category_id + "'"));
                    pp.SubItems.Add(c.subj_type);
                    pp.SubItems.Add(c.subj_short);
                    listView1.Items.Add(pp);
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

                    Process_ALsubject.deletesubjects_alevel("where id=" + get_id + "");
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
            SubtypeCbx.Text = e.Item.SubItems[4].Text;
            abbrevTbx.Text = e.Item.SubItems[5].Text;
        }

        private void Alevel_subjects_Load(object sender, EventArgs e)
        {
            Btn_delete.Visible = false;
            Load_List();
            Load_subcat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
