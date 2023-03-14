using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Data;
using Schulexx.Code;
using Schulexx.Model;
using Schulexx.Forms;

namespace Schulexx.Controls
{
    public partial class ViewEditstudents : UserControl
    {
        public ViewEditstudents()
        {
            InitializeComponent();
        }
        int get_id=0;
        private void clear()
        {
            class_combo.SelectedIndex = -1;
            student_txt.Clear();
            Subject_assign.Visible = false;
        }
        LevelsDataAdapter Process_levels = new LevelsDataAdapter();
        List<Levels> Load_levels = new List<Levels>();
        public void Levels_load()
        {
            try
            {
                Levels_cbx.Items.Clear();
                Load_levels = Process_levels.GetLevelsList("");
                foreach (Levels dd in Load_levels)
                {
                    Levels_cbx.Items.Add(dd.name);
                }

            }
            catch { }
        }
        ClassesDataAdapter Process_class = new ClassesDataAdapter();
        List<Classes> Load_class = new List<Classes>();
        public void load_class()
        {
            try {
                class_combo.Items.Clear();
                Load_class = Process_class.GetClassesList("where level_id=" + new Connectoperations().singleval("levels", "id", "where name= '" + Levels_cbx.Text + "'"));
                foreach(Classes dd in Load_class){
                    class_combo.Items.Add(dd.cname);
                }
            
            }
            catch { }
        }
        StudentsDataAdapter Process_student = new StudentsDataAdapter();
        ClassEnrollmentsDataAdapter process_enrol = new ClassEnrollmentsDataAdapter();
        List<Class_enrollments> load_students = new List<Class_enrollments>();
        public void load_list()
        {
            try {
                listView1.Items.Clear();
                load_students = process_enrol.GetClass_enrollmentsList("where class_id='" + new Connectoperations().singleval("classes", "class_id", "where cname='"+class_combo.Text+"'") + "'");
                foreach(Class_enrollments c in load_students){
                    ListViewItem pp = new ListViewItem();

                    pp.Text = c.student_id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("students","reg_number","where student_id='"+c.student_id+"'"));
                    pp.SubItems.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                    //pp.SubItems.Add(c.class_id.ToString());
                    pp.SubItems.Add(new Connectoperations().singleval("students", "gender", "where student_id='" + c.student_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("parents", "concat(fname,' ',lname)", "where parent_id='" + new Connectoperations().singleval("ps_relations", "parents_id", "where students_id='"+c.student_id+"'") + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("study_section", "study_section_name", "where study_section_id='" + new Connectoperations().singleval("students", "study_section_id", "where student_id='"+c.student_id+"'") + "'"));
                    pp.SubItems.Add( DateTime.Parse(new Connectoperations().singleval("students", "BirthDate", "where student_id='" + c.student_id + "'")).ToShortDateString());
                    pp.SubItems.Add(new Connectoperations().singleval("students", "homedistrict", "where student_id='" + c.student_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("students", "homeVillage", "where student_id='" + c.student_id + "'"));

                    listView1.Items.Add(pp);

                }
            
            }
            catch { }
        }

        private void ViewEditstudents_Load(object sender, EventArgs e)
        {
            Subject_assign.Visible = false;
            label1.Text = "Select Class first to perform any action on Students";
            Levels_load();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Subject_assign.Visible = true;
            get_id = int.Parse(e.Item.SubItems[0].Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void class_combo_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
                label1.Text = class_combo.Text+" "+"Student list";
                load_list();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Subject_assign_Click(object sender, EventArgs e)
        {
            if (Levels_cbx.Text == "Advanced Level")
            {
                new AssignSubjectsAlevel(get_id).ShowDialog();
            }
            else
            {
                new AssignSubjects(get_id).ShowDialog();
            }
            Subject_assign.Visible = false;
        }

        private void Levels_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            class_combo.SelectedIndex = -1;
            load_class();
        }
    }
}
