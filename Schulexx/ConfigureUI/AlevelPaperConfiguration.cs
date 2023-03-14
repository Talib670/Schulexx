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
    public partial class AlevelPaperConfiguration : Form
    {
        public AlevelPaperConfiguration()
        {
            InitializeComponent();
        }

        Subject_papers_alevel Local_Apapers = new Subject_papers_alevel();
        Subject_papers_alevelDataAdapter Process_Apaper = new Subject_papers_alevelDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            Local_Apapers.paper_id = get_id;
            Local_Apapers.subject_id = int.Parse(new Connectoperations().singleval("subjects_alevel", "id", "where subj_name='" + subjCbx.Text + "'"));
            Local_Apapers.paper_number = int.Parse(new Connectoperations().validate_All_Data(pnCbx.Text));
            Local_Apapers.description = new Connectoperations().validate_All_Data(DescTbx.Text);
            if (get_id == 0)
            {
                Process_Apaper.Insert(Local_Apapers);
                clear();
                load_list();
            }
            else
            {
                Process_Apaper.Update(Local_Apapers);
                clear();
                load_list();
            }
        }

        public void clear()
        {
            get_id = 0;
            subjCbx.SelectedIndex = -1;
            Btn_delete.Visible = false;
            SaveBtn.Text = "Save";
            pnCbx.SelectedIndex = -1;
            DescTbx.Clear();
        }

        List<Subject_papers_alevel> Cpaper_Load = new List<Subject_papers_alevel>();

        public void load_list()
        {
            try
            {
                listView1.Items.Clear();
                Cpaper_Load = Process_Apaper.GetSubject_papers_alevelList("");
                foreach (Subject_papers_alevel c in Cpaper_Load)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.paper_id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("subjects_alevel", "subj_name", "where id='" + c.subject_id + "'"));
                    pp.SubItems.Add(c.paper_number.ToString());
                    pp.SubItems.Add(c.description);
                    listView1.Items.Add(pp);
                }
            }
            catch
            {

            }
        }

        List<Subjects_alevel> Load_subjects = new List<Subjects_alevel>();
        Subjects_alevelDataAdapter Process_Asubj = new Subjects_alevelDataAdapter();
        public void load_subjects()
        {
            try
            {
                subjCbx.Items.Clear();
                Load_subjects = Process_Asubj.GetSubjects_alevelList("");
                foreach (Subjects_alevel c in Load_subjects)
                {
                    subjCbx.Items.Add(c.subj_name);
                }
            }
            catch
            {

            }
        }

        private void AlevelPaperConfiguration_Load(object sender, EventArgs e)
        {
            load_list();
            Btn_delete.Visible = false;
            load_subjects();
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
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
                    Process_Apaper.deletesubject_papers_alevel("where paper_id='" + get_id + "'");
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

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            SaveBtn.Text = "Update";
            Btn_delete.Visible = true;
            get_id = int.Parse(e.Item.SubItems[0].Text);
            subjCbx.Text = e.Item.SubItems[1].Text;
            pnCbx.Text = e.Item.SubItems[2].Text;
            DescTbx.Text = e.Item.SubItems[3].Text;
        }
    }
}
