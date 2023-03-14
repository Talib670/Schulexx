using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Code;
using Schulexx.Model;
using Schulexx.Data;

namespace Schulexx.Controls
{
    public partial class SubjectsAssignAlevel : UserControl
    {
        public SubjectsAssignAlevel(int get_id)
        {
            InitializeComponent();
            get_id1 = get_id;
        }
        int get_id1;
        Subject_enrolmentsalevel Local_subject = new Subject_enrolmentsalevel();
        Subject_enrolmentsalevelDataAdapter process_subject = new Subject_enrolmentsalevelDataAdapter();
        int get_id = 0;
        int sub_id;

        public void insert_update()
        {

            if (yearCbx.Text == "")
            {
                MessageBox.Show("Error : Year can be empty!");
            }
            else
            {
                Local_subject.id = get_id;
                Local_subject.stud_id = get_id1;
                Local_subject.subj_id = sub_id;
                Local_subject.year = int.Parse(new Connectoperations().validate_All_Data(yearCbx.Text));
                if (get_id == 0)
                {
                    process_subject.Insert(Local_subject);
                    Load_List();
                    clear();
                }
                else
                {
                    Local_subject.subj_id = int.Parse(new Connectoperations().singleval("subjects_alevel", "id", "where subj_name='" + Subj_cbx.Text + "'"));
                    process_subject.Update(Local_subject);
                    clear();
                    Load_List();
                }
            }
           
        }

        public void clear()
        {
            get_id = 0;
            Btn_save.Text = "Assign";
            Btn_delete.Visible = false;
            groupBox5.Visible = false;
        }

        Subjects_alevelDataAdapter Asubj_process = new Subjects_alevelDataAdapter();
        List<Subjects_alevel> Load_Asubjects = new List<Subjects_alevel>();
        public void Load_subjects()
        {
            if (radioButton1.Checked)
            {
                try
                {
                    listView2.Items.Clear();
                    Load_Asubjects = Asubj_process.GetSubjects_alevelList("where subj_type='Principal'");
                    foreach (Subjects_alevel c in Load_Asubjects)
                    {

                        ListViewItem pp = new ListViewItem();
                        pp.Text = c.id.ToString();
                        pp.SubItems.Add(c.subj_code.ToString());
                        pp.SubItems.Add(c.subj_name);


                        listView2.Items.Add(pp);

                    }
                }
                catch { }
            }
            else if (radioButton2.Checked)
            {
                try
                {
                    listView2.Items.Clear();
                    Load_Asubjects = Asubj_process.GetSubjects_alevelList("where subj_type='Subsidiary'");
                    foreach (Subjects_alevel c in Load_Asubjects)
                    {

                        ListViewItem pp = new ListViewItem();
                        pp.Text = c.id.ToString();
                        pp.SubItems.Add(c.subj_code.ToString());
                        pp.SubItems.Add(c.subj_name);


                        listView2.Items.Add(pp);

                    }
                }
                catch { }
            }
            else
            {
                try
                {
                    listView2.Items.Clear();
                    Load_Asubjects = Asubj_process.GetSubjects_alevelList("");
                    foreach (Subjects_alevel c in Load_Asubjects)
                    {

                        ListViewItem pp = new ListViewItem();
                        pp.Text = c.id.ToString();
                        pp.SubItems.Add(c.subj_code.ToString());
                        pp.SubItems.Add(c.subj_name);


                        listView2.Items.Add(pp);

                    }
                }
                catch { }
            }
        }

        List<Subject_enrolmentsalevel> Load_subj_enroll = new List<Subject_enrolmentsalevel>();

        public void Load_List()
        {
            try
            {
                listView1.Items.Clear();
                Load_subj_enroll = process_subject.GetSubject_enrolmentsalevelList("where stud_id='" + get_id1 + "'");


                foreach (Subject_enrolmentsalevel c in Load_subj_enroll)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("subjects_alevel", "subj_code", "where id='" + c.subj_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("subjects_alevel", "subj_name", "where id='" + c.subj_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("subjects_alevel", "subj_short", "where id='" + c.subj_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("subject_category", "category", "where id='" + new Connectoperations().singleval("subjects_alevel", "category_id	", "where id='" + c.subj_id + "'") + "'"));
                    pp.SubItems.Add(c.year.ToString());
                    listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void subj_combo()
        {
            try
            {
                Subj_cbx.Items.Clear();
                Load_Asubjects = Asubj_process.GetSubjects_alevelList("");
                foreach (Subjects_alevel c in Load_Asubjects)
                {
                    Subj_cbx.Items.Add(c.subj_name);
                }
            }
            catch { }
        }

        private void SubjectsAssignAlevel_Load(object sender, EventArgs e)
        {
            subj_combo();
            groupBox5.Visible = false;
            Load_List();
            Load_subjects();
            Btn_delete.Visible = false;
            label1.Text = "ASSIGNING SUBJECTS TO" + ' ' + new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + get_id1 + "'") + ' ' + " - " + "REG No: " + new Connectoperations().singleval("students", "reg_number", "where student_id='" + get_id1 + "'");
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            Load_subjects();
            groupBox3.Text = "Principal Subjects";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            Load_subjects();
            groupBox3.Text = "Subsidiary Subjects";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            Load_subjects();
            groupBox3.Text = "All Subjects";
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void Btn_new_Click(object sender, EventArgs e)
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
                    process_subject.deletesubject_enrolmentsalevel("where id = '" + get_id + "'");
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

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            sub_id = int.Parse(e.Item.SubItems[0].Text);
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Btn_delete.Visible = true;
            groupBox5.Visible = true;
            Btn_save.Text = "Update";
            get_id = int.Parse(e.Item.SubItems[0].Text);
            Subj_cbx.Text = e.Item.SubItems[2].Text;
        }

    }
}
