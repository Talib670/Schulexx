using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Model;
using Schulexx.Data;
using Schulexx.Code;

namespace Schulexx.Controls
{
    public partial class StudentClass_enroll : UserControl
    {
        public StudentClass_enroll(int get_id)
        {
            InitializeComponent();
            get_id1 = get_id;
        }
        int get_id1;
        Class_enrollments LocalClass_enroll = new Class_enrollments();
        ClassEnrollmentsDataAdapter ProcessClass_enroll = new ClassEnrollmentsDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            LocalClass_enroll.id = get_id;
            LocalClass_enroll.student_id = get_id1;
            LocalClass_enroll.class_id = int.Parse(new Connectoperations().singleval("classes", "class_id", "where cname='" + class_Cbx.Text + "'"));
            LocalClass_enroll.stream_id = int.Parse(new Connectoperations().singleval("class_streams", "id", "where stream_label='" + streamCbx.Text + "'"));
            if (get_id == 0)
            {
                ProcessClass_enroll.Insert(LocalClass_enroll);
                clear();
                Load_List();
            }
            else
            {
                ProcessClass_enroll.Update(LocalClass_enroll);
                clear();
                Load_List();
            }
        }

        List<Classes> Load_Class = new List<Classes>();
        ClassesDataAdapter Process_class = new ClassesDataAdapter();

        public void load_class_list()
        {
            try
            {
                class_Cbx.Items.Clear();

                Load_Class = Process_class.GetClassesList("");

                foreach (Classes c in Load_Class)
                {
                    class_Cbx.Items.Add(c.cname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        List<Class_streams> Load_Stream = new List<Class_streams>();
        Class_streamsDataAdapters Process_stream = new Class_streamsDataAdapters();

        public void load_stream_list()
        {
            try
            {
                streamCbx.Items.Clear();

                Load_Stream = Process_stream.GetClass_streamsList("");

                foreach (Class_streams sc in Load_Stream)
                {
                    streamCbx.Items.Add(sc.stream_label);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void clear()
        {
            get_id = 0;
            streamCbx.SelectedIndex = -1;
            class_Cbx.SelectedIndex = -1;
            Btn_delete.Visible = false;
            Btn_save.Text = "Save";
             

        }

        List<Class_enrollments> Load_class_enroll = new List<Class_enrollments>();

        public void Load_List()
        {
            try
            {
                listView1.Items.Clear();
                Load_class_enroll = ProcessClass_enroll.GetClass_enrollmentsList("where student_id='" + get_id1 + "'");


                foreach (Class_enrollments c in Load_class_enroll)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("classes", "cname", "where class_id='" + c.class_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("class_streams", "stream_label", "where id='" + c.stream_id + "'"));
                    

                    listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (Btn_save.Text == "Save")
            {
                try
                {
                    DialogResult ret;
                    ret = MessageBox.Show("Are you sure you want to Save", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (ret == DialogResult.Yes)
                    {
                        insert_update();
                        Load_List();
                    }
                    else
                    {
                        return;
                    }
                }
                catch { }
            }
            else if (Btn_save.Text == "Update")
            {
                try
                {
                    DialogResult ret;
                    ret = MessageBox.Show("Are you sure you want to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (ret == DialogResult.Yes)
                    {
                        insert_update();
                        Load_List();
                    }
                    else
                    {
                        return;
                    }
                }
                catch { }
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    ProcessClass_enroll.deleteclass_enrollments("where id=" + get_id + "");
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
            get_id = int.Parse(e.Item.SubItems[0].Text);
            get_id1 = int.Parse(e.Item.SubItems[1].Text);
            streamCbx.Text = new Connectoperations().singleval("class_streams", "stream_label", "where id='" + e.Item.SubItems[2].Text + "'");
            class_Cbx.Text = new Connectoperations().singleval("classes", "cname", "where id='" + e.Item.SubItems[3].Text + "'");
            Btn_delete.Enabled = true;
            Btn_save.Text = "Update";
        }

        private void StudentClass_enroll_Load(object sender, EventArgs e)
        {
            load_class_list();
            load_stream_list();
            Load_List();
        }
    }
}
