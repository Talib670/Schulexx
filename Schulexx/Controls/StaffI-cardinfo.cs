using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schulexx.Controls
{
    public partial class StaffI_cardinfo : UserControl
    {
        public StaffI_cardinfo()
        {
            InitializeComponent();
        }

        private void Chk_sort_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_sort.Checked == true)
            {
                Staff_type.Visible = true;

            }
            else
            {
                Staff_type.Visible = false;
                Btn_generate.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_generate.Visible = true;
        }

        private void StaffI_cardinfo_Load(object sender, EventArgs e)
        {
            Staff_type.Visible = false;
            Btn_generate.Visible = false;
        }
    }
}
