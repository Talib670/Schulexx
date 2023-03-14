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
using Schulexx.Data;
using Schulexx.Model;

namespace Schulexx.Controls
{
    public partial class SubjectAssign : UserControl
    {
        public SubjectAssign(int get_id)
        {
            InitializeComponent();
            get_id1 = get_id;
        }
        int get_id1;
        Subject_enrolments Local_subject = new Subject_enrolments();
        Subject_enrolmentsDataAdapter process_subject = new Subject_enrolmentsDataAdapter();
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
                Local_subject.student_id = get_id1;
                Local_subject.subject_id = sub_id;
                Local_subject.year = int.Parse(new Connectoperations().validate_All_Data(yearCbx.Text));
                if (get_id == 0)
                {
                    process_subject.Insert(Local_subject);
                    Load_List();
                    clear();
                }
                else
                {
                    Local_subject.subject_id = int.Parse(new Connectoperations().singleval("subjects", "subject_id", "where sname='" + Subj_cbx.Text + "'"));
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
        
        
        SubjectsDataAdapter subj_process = new SubjectsDataAdapter();
        List<Subjects> subjectsLoad = new List<Subjects>();
        public void Load_subjects()
        {
            if (radioButton1.Checked)
            {
                try
                {
                    listView2.Items.Clear();
                    subjectsLoad = subj_process.GetSubjectsList("where compulsory='Yes'");
                    foreach (Subjects c in subjectsLoad)
                    {

                        ListViewItem pp = new ListViewItem();
                        pp.Text = c.subject_id.ToString();
                        pp.SubItems.Add(c.subject_code.ToString());
                        pp.SubItems.Add(c.sname);


                        listView2.Items.Add(pp);

                    }
                }
                catch { }
          }
            else if(radioButton2.Checked){
                try
                {
                    listView2.Items.Clear();
                    subjectsLoad = subj_process.GetSubjectsList("where compulsory='No'");
                    foreach (Subjects c in subjectsLoad)
                    {

                        ListViewItem pp = new ListViewItem();
                        pp.Text = c.subject_id.ToString();
                        pp.SubItems.Add(c.subject_code.ToString());
                        pp.SubItems.Add(c.sname);


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
                    subjectsLoad = subj_process.GetSubjectsList("");
                    foreach (Subjects c in subjectsLoad)
                    {

                        ListViewItem pp = new ListViewItem();
                        pp.Text = c.subject_id.ToString();
                        pp.SubItems.Add(c.subject_code.ToString());
                        pp.SubItems.Add(c.sname);


                        listView2.Items.Add(pp);

                    }
                }
                catch { }
            }
        }
        public void subj_combo()
        {
            try
            {
                Subj_cbx.Items.Clear();
                subjectsLoad = subj_process.GetSubjectsList("");
                foreach (Subjects c in subjectsLoad)
                {
                    Subj_cbx.Items.Add(c.sname);
                }
            }
            catch { }
        }

        List<Subject_enrolments> Load_subj_enroll = new List<Subject_enrolments>();

        public void Load_List()
        {
            try
            {
                listView1.Items.Clear();
                Load_subj_enroll = process_subject.GetSubject_enrolmentsList("where student_id='" + get_id1 + "'");


                foreach (Subject_enrolments c in Load_subj_enroll)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("subjects", "subject_code", "where subject_id='" + c.subject_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("subjects", "sname", "where subject_id='" + c.subject_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("subjects", "sub_short", "where subject_id='" + c.subject_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("subject_category", "category", "where id='" + new Connectoperations().singleval("subjects", "category_id	", "where subject_id='" + c.subject_id + "'") + "'"));
                    pp.SubItems.Add(c.year.ToString());


                    listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubjectAssign_Load(object sender, EventArgs e)
        {
            subj_combo();
            groupBox5.Visible = false;
            Load_List();
            Load_subjects();
            Btn_delete.Visible = false;
            label1.Text = "ASSIGNING SUBJECTS TO" + ' ' + new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + get_id1 + "'") + ' ' +" - "+ "REG No: " + new Connectoperations().singleval("students", "reg_number", "where student_id='" + get_id1 + "'");
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
                    process_subject.deletesubject_enrolments("where id = '"+get_id+"'");
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
            groupBox5.Visible = true;
            Btn_save.Text = "Update";
            get_id = int.Parse(e.Item.SubItems[0].Text);
            Subj_cbx.Text = e.Item.SubItems[2].Text;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            sub_id = int.Parse(e.Item.SubItems[0].Text);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            Load_subjects();
            groupBox3.Text = "Compulsory Subjects";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            Load_subjects();
            groupBox3.Text = "Optional Subjects";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            Load_subjects();
            groupBox3.Text = "All Subjects";
        }
    }
}
