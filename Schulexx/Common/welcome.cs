using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schulexx.CommonUI
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }
        int z;
        private void welcome_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            z += 2;

            if (z > 100)
            {
                this.Hide();
                this.timer1.Enabled = false;
                new LoginForm().ShowDialog();
                return;

            }
            this.progressBar1.Value = z;
        }
       
    }
}
