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
    public partial class SchoolFees : UserControl
    {
        public SchoolFees()
        {
            InitializeComponent();
        }
        Fees_payments LocalFee_pay = new Fees_payments();
        Fees_paymentsDataAdapter ProcessFee_pay = new Fees_paymentsDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            string[] mm = Student_combo.Text.Split(' ');
            LocalFee_pay.id = get_id;
            LocalFee_pay.term = new Connectoperations().validate_All_Data(TermCbx.Text);
            LocalFee_pay.feestructureID = int.Parse(new Connectoperations().singleval("fees_structure", "id", "where Fee_type='"+ FeesCbx.Text + "'"));
            LocalFee_pay.amount = decimal.Parse(new Connectoperations().validate_All_Data(AmountTbx.Text));
            LocalFee_pay.date_paid = dateTimePicker1.Value;
            LocalFee_pay.student_id = int.Parse(new Connectoperations().singleval("students", "student_id", "where fname='"+mm[0]+"' and lname='"+mm[1]+"'"));
            LocalFee_pay.class_id = int.Parse(new Connectoperations().singleval("classes", "class_id", "where cname='" + ClassCbx.Text+ "'"));
            LocalFee_pay.pay_mode = new Connectoperations().validate_All_Data(PaytypeCbx.Text);
            if (get_id == 0)
            {
                ProcessFee_pay.Insert(LocalFee_pay);
                clear();
                Load_List();
            }
            else
            {
                ProcessFee_pay.Update(LocalFee_pay);
                clear();
                Load_List();
            }
        }

        public void clear()
        {
            get_id = 0;
            Btn_delete.Visible = false;
            Btn_save.Text = "Save";
            TermCbx.SelectedIndex = -1;
            level_cbx.SelectedIndex = -1;
            ClassCbx.SelectedIndex = -1;
            Student_combo.SelectedIndex = -1;
            FeesCbx.SelectedIndex = -1;
            PaytypeCbx.SelectedIndex = -1;
            AmountTbx.Clear();

        }

        List<Fees_payments> Fee_Load = new List<Fees_payments>();
        public void Load_List()
        {
            try
            {
                listView1.Items.Clear();
                Fee_Load = ProcessFee_pay.GetFees_paymentsList("");
                foreach (Fees_payments c in Fee_Load)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("students", "reg_number", "where student_id='" + c.student_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                    pp.SubItems.Add(c.term);
                    pp.SubItems.Add(new Connectoperations().singleval("classes", "cname", "where class_id='" + c.class_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("fees_structure", "Fee_type", "where id='" + c.feestructureID + "'"));
                    pp.SubItems.Add(c.amount.ToString());
                    pp.SubItems.Add(c.date_paid.ToShortDateString());

                    load_Fees = process_Fees.GetFees_structureList("where id='" + c.feestructureID + "'");
                    string balance = "";
                    decimal Diff;
                    foreach (Fees_structure ee in load_Fees)
                    {
                        Diff = ee.suggestedAmount - c.amount;
                        balance = Diff.ToString();
                    }
                    pp.SubItems.Add(balance);
                    pp.SubItems.Add(c.pay_mode);

                    listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SchoolFees_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            Btn_delete.Visible = false;
            load_level();
            load_FeesStruct();
            Load_List();
        }

        LevelsDataAdapter process_levels = new LevelsDataAdapter();
        List<Levels> load_levels = new List<Levels>();
        public void load_level()
        {

            try
            {
                level_cbx.Items.Clear();
                load_levels = process_levels.GetLevelsList("");

                foreach (Levels ee in load_levels)
                {

                    level_cbx.Items.Add(ee.name);

                }
            }
            catch { }

        }

        ClassesDataAdapter process_class = new ClassesDataAdapter();
        List<Classes> load_classes = new List<Classes>();

        public void load_class()
        {

            try
            {
                ClassCbx.Items.Clear();
                load_classes = process_class.GetClassesList("where level_id=" + new Connectoperations().singleval("levels", "id", "where name= '" + level_cbx.Text + "'"));

                foreach (Classes ee in load_classes)
                {

                    ClassCbx.Items.Add(ee.cname);

                }
            }
            catch { }
        }

        StudentsDataAdapter Process_student = new StudentsDataAdapter();
        ClassEnrollmentsDataAdapter process_enrol = new ClassEnrollmentsDataAdapter();
        List<Class_enrollments> load_student = new List<Class_enrollments>();

        public void Load_Students()
        {
            try
            {
                Student_combo.Items.Clear();
                load_student = process_enrol.GetClass_enrollmentsList("where class_id='" + new Connectoperations().singleval("classes", "class_id", "where cname='" + ClassCbx.Text + "'") + "'");


                foreach (Class_enrollments c in load_student)
                {
                    Student_combo.Items.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        Fees_structureDataAdapter process_Fees = new Fees_structureDataAdapter();
        List<Fees_structure> load_Fees = new List<Fees_structure>();
        public void load_FeesStruct()
        {

            try
            {
                FeesCbx.Items.Clear();
                load_Fees = process_Fees.GetFees_structureList("");

                foreach (Fees_structure ee in load_Fees)
                {

                    FeesCbx.Items.Add(ee.Fee_type);

                }
            }
            catch { }

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
                    ProcessFee_pay.GetFees_paymentsList("");
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

        private void level_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_class();
        }

        private void ClassCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Students();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Btn_save.Text = "Update";
            Btn_delete.Visible = true;
            level_cbx.Text = new Connectoperations().singleval("levels", "name", "where id='" + new Connectoperations().singleval("classes", "level_id", "where cname='" + e.Item.SubItems[4].Text + "'") + "'");
            get_id = int.Parse(e.Item.SubItems[0].Text);
            Student_combo.Text = e.Item.SubItems[2].Text;
            TermCbx.Text = e.Item.SubItems[3].Text;
            ClassCbx.Text = e.Item.SubItems[4].Text;
            FeesCbx.Text = e.Item.SubItems[5].Text;
            AmountTbx.Text = e.Item.SubItems[6].Text;
            dateTimePicker1.Text = e.Item.SubItems[7].Text;
            PaytypeCbx.Text = e.Item.SubItems[9].Text;
        }
    }
}
