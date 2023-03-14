using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Model;
using Schulexx.Code;
using Schulexx.Data;

namespace Schulexx.AttendanceUI
{
    public partial class StudentAttendances : UserControl
    {
        public StudentAttendances()
        {
            InitializeComponent();
        }
        Student_attendances Local_studAtt = new Student_attendances();
        Student_attendancesDataAdpter Process_studAtt = new Student_attendancesDataAdpter();
        int get_id = 0;
        int stud_id;
        public void insert_update(){
            Local_studAtt.id = get_id;
            Local_studAtt.class_id = int.Parse(new Connectoperations().singleval("classes", "class_id", "where cname='"+class_combo.Text+"'"));
            Local_studAtt.Astatus = Att_status;
            Local_studAtt.date = dateTimePicker1.Value;
            Local_studAtt.student_id = stud_id;
            if(get_id==0){
                Process_studAtt.Insert(Local_studAtt);
                load_list();
                load_list2();
            }
            else
            {
                Btn_save.Text = "Change Status";
                Process_studAtt.Update(Local_studAtt);
                load_list();
                load_list2();
            }
        }
        ClassesDataAdapter Process_class = new ClassesDataAdapter();
        List<Classes> Load_class = new List<Classes>();
        public void load_class()
        {
            try
            {
                class_combo.Items.Clear();
                Load_class = Process_class.GetClassesList("");
                foreach (Classes dd in Load_class)
                {
                    class_combo.Items.Add(dd.cname);
                }

            }
            catch { }
        }

        ClassEnrollmentsDataAdapter process_enrol = new ClassEnrollmentsDataAdapter();
        List<Class_enrollments> load_students = new List<Class_enrollments>();
        public void load_list()
        {
            try
            {
                listView1.Items.Clear();
                load_students = process_enrol.GetClass_enrollmentsList("where class_id='" + new Connectoperations().singleval("classes", "class_id", "where cname='" + class_combo.Text + "'") + "'");
                foreach (Class_enrollments c in load_students)
                {
                           ListViewItem pp = new ListViewItem();
                           pp.Text = c.student_id.ToString();
                           pp.SubItems.Add(new Connectoperations().singleval("students", "reg_number", "where student_id='" + c.student_id + "'"));
                           pp.SubItems.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                           pp.SubItems.Add(new Connectoperations().singleval("students", "Study_section", "where student_id='" + c.student_id + "'"));

                           listView1.Items.Add(pp);   
                }

            }
            catch { }
        }


        List<Student_attendances> load_studAttd = new List<Student_attendances>();
        public void load_list2()
        {
            
                listView2.Items.Clear();
                load_studAttd = Process_studAtt.GetStudent_attendancesList("where class_id='" + new Connectoperations().singleval("classes", "class_id", "where cname='" + class_combo.Text + "'") + "' and date='" + new Connectoperations().mysqldate_only(dateTimePicker1.Value) + "'");
                
                foreach (Student_attendances c in load_studAttd)
                {
                    ListViewItem pp = new ListViewItem();

                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("students", "gender", "where student_id='" + c.student_id + "'"));
                    pp.SubItems.Add(c.date.ToShortDateString());
                    pp.SubItems.Add(new Connectoperations().singleval("student_attendances", "Astatus", "where student_id='" + c.student_id + "' and date='" + new Connectoperations().mysqldate_only(dateTimePicker1.Value) + "'"));

                    listView2.Items.Add(pp);


            }
        }
        
        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            load_class();
        }

        private void class_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_list();
            load_list2();
            groupBox2.Text = "Attendance List For" + ' ' + class_combo.Text + ' ' + "at" + ' ' + dateTimePicker1.Text;
           
        }
        string Att_status = "Present";
        private void PresentRbtn_Click(object sender, EventArgs e)
        {
            Att_status= ((RadioButton)sender).Text;
        }

        private void AbsentRbtn_Click(object sender, EventArgs e)
        {
            Att_status = ((RadioButton)sender).Text;
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            stud_id = int.Parse(e.Item.SubItems[0].Text);
            //if (e.Item.SubItems[5].Text == "Present")
            //{
            //    PresentRbtn.Checked = true;
            //}
            //else if (e.Item.SubItems[5].Text == "Absent")
            //{
            //    AbsentRbtn.Checked = true;
            //}
            //else
            //{
            //    PresentRbtn.Checked = false;
            //    PresentRbtn.Checked = false;
            //}

        }
        
        private void Btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            load_list2();
            groupBox2.Text = "Attendance List For" + ' ' + class_combo.Text + ' ' + "at" + ' ' + dateTimePicker1.Text;
        }

    }
}
