using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Model;
using Schulexx.Code;
using Schulexx.Data;


namespace Schulexx.ConfigureUI
{
    public partial class OlevelPaper_config : Form
    {
        public OlevelPaper_config()
        {
            InitializeComponent();
        }
        Subject_class_papers Local_classP = new Subject_class_papers();
        Subject_class_papersDataAdapter Process_ClassP = new Subject_class_papersDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            Local_classP.paper_id = get_id;
            Local_classP.subject_id = int.Parse(new Connectoperations().singleval("subjects", "subject_id", "where sname='"+subjCbx.Text+"'"));
            Local_classP.class_id = int.Parse(new Connectoperations().singleval("classes", "class_id", "where cname='"+classCbx.Text+"'"));
            Local_classP.paper_number = int.Parse(new Connectoperations().validate_All_Data(pnCbx.Text));
            Local_classP.description = new Connectoperations().validate_All_Data(DescTbx.Text);
            if (get_id == 0)
            {
                Process_ClassP.Insert(Local_classP);
                clear();
                load_list();
            }
            else
            {
                Process_ClassP.Update(Local_classP);
                clear();
                load_list();
            }
        }

        public void clear()
        {
            get_id = 0;
            subjCbx.SelectedIndex = -1;
            Btn_Delete.Visible = false;
            Btn_save.Text = "Save";
            classCbx.SelectedIndex = -1;
            pnCbx.SelectedIndex = -1;
            DescTbx.Clear();
        }

        List<Subject_class_papers> Cpaper_Load = new List<Subject_class_papers>();

        public void load_list()
        {
            try {
                listView1.Items.Clear();
                Cpaper_Load = Process_ClassP.GetSubject_class_papersList("");
                foreach (Subject_class_papers c in Cpaper_Load)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.paper_id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("classes", "cname", "where class_id='"+c.class_id+"'"));
                    pp.SubItems.Add(new Connectoperations().singleval("subjects", "sname", "where subject_id='"+c.subject_id+"'"));
                    pp.SubItems.Add(c.paper_number.ToString());
                    pp.SubItems.Add(c.description);
                    listView1.Items.Add(pp);
                }
            }
            catch
            {

            }
        }

        List<Subjects> Load_subjects = new List<Subjects>();
        SubjectsDataAdapter Process_subjects = new SubjectsDataAdapter();
        public void load_subjects()
        {
            try
            {
                subjCbx.Items.Clear();
                Load_subjects = Process_subjects.GetSubjectsList("");
                foreach(Subjects c in Load_subjects){
                    subjCbx.Items.Add(c.sname);
                }
            }
            catch
            {

            }
        }

        List<Classes> Load_classes = new List<Classes>();
        ClassesDataAdapter Process_class = new ClassesDataAdapter();
        public void load_class()
        {
            try {
                classCbx.Items.Clear();
                Load_classes = Process_class.GetClassesList("where level_id='" + new Connectoperations().singleval("levels", "id", "where Abbrev='O'") + "'");
                foreach(Classes c in Load_classes){
                    classCbx.Items.Add(c.cname);
                }
            }
            catch
            {

            }
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    Process_ClassP.deletesubject_class_papers("where paper_id='"+get_id+"'");
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

        private void OlevelPaper_config_Load(object sender, EventArgs e)
        {
            Btn_Delete.Visible = false;
            load_list();
            load_subjects();
            load_class();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Btn_save.Text = "Update";
            Btn_Delete.Visible = true;
            get_id = int.Parse(e.Item.SubItems[0].Text);
            classCbx.Text = e.Item.SubItems[1].Text;
            subjCbx.Text = e.Item.SubItems[2].Text;
            pnCbx.Text = e.Item.SubItems[3].Text;
            DescTbx.Text = e.Item.SubItems[4].Text;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
