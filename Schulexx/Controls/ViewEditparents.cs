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
    public partial class ViewEditparents : UserControl
    {
        public ViewEditparents()
        {
            InitializeComponent();
        }
        Parents Local_parent = new Parents();
        ParentsDataAdapter Process_parent = new ParentsDataAdapter();
        List<Parents> load_Parents = new List<Parents>();
        private void load_list()
        {
            try
            {
                listView1.Items.Clear();

                load_Parents = Process_parent.GetParentsList("");

                foreach (Parents c in load_Parents)
                {

                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.parent_id.ToString();
                    pp.SubItems.Add(c.fname+' '+ c.lname);
                    pp.SubItems.Add(c.genda);
                    pp.SubItems.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + new Connectoperations().singleval("ps_relations", "students_id", "where parents_id='" + c.parent_id+ "'") + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("ps_relations", "Relationtostudents", "where parents_id='"+c.parent_id+"'"));
                    pp.SubItems.Add(c.phone);
                    pp.SubItems.Add(c.occupation);
                    pp.SubItems.Add(c.HomeAddress);
                    pp.SubItems.Add(c.WorkAddress);
                    pp.SubItems.Add(new Connectoperations().singleval("ps_relations", "COUNT(students_id)", "where parents_id='"+c.parent_id+"'"));
                    pp.SubItems.Add(c.DOB.ToShortDateString());
                    pp.SubItems.Add(c.Email);

                    listView1.Items.Add(pp);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ViewEditparents_Load(object sender, EventArgs e)
        {
            load_list();
            btn_assign.Visible = false;
            Btn_cont.Visible = false;
        }
    }
}
