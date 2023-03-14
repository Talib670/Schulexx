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
    public partial class NewDepartment : Form
    {
        public NewDepartment()
        {
            InitializeComponent();
        }
        Departments local_department = new Departments();
        DepartmentsDataAdapter process_depart = new DepartmentsDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            local_department.Dep_id = get_id;
            local_department.DepName = new Connectoperations().validate_All_Data(depNametxt.Text);
            local_department.dep_type = new Connectoperations().validate_All_Data(DeptypeCbx.Text);
            local_department.Description = new Connectoperations().validate_All_Data(descr_txt.Text); 
            if(get_id==0){
                process_depart.Insert(local_department);
                clear();
                Load_List();
            }
            else
            {
                process_depart.Update(local_department);
                clear();
                Load_List();
            }
        }
        public void clear()
        {
            get_id = 0;
            btn_delete.Visible = false;
            btn_save.Text = "save";
            depNametxt.Clear();
            descr_txt.Clear();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        List<Departments> load_deps = new List<Departments>();
        public void Load_List()
        {
            listView1.Items.Clear();
            load_deps = process_depart.GetDepartmentsList("");
            foreach(Departments c in load_deps){
                ListViewItem pp = new ListViewItem();
                pp.Text = c.Dep_id.ToString();
                pp.SubItems.Add(c.DepName);
                pp.SubItems.Add(c.dep_type);
                pp.SubItems.Add(c.Description);
                listView1.Items.Add(pp);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    process_depart.deletedepartments("where id=" + get_id + "");
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

        private void NewDepartment_Load(object sender, EventArgs e)
        {
            Load_List();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btn_delete.Visible = true;
            btn_save.Text = "Update";
            get_id = int.Parse(e.Item.SubItems[0].Text);
            depNametxt.Text = e.Item.SubItems[1].Text;
            DeptypeCbx.Text = e.Item.SubItems[2].Text;
            descr_txt.Text = e.Item.SubItems[3].Text;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
