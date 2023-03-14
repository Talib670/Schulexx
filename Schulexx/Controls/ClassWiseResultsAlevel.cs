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
    public partial class ClassWiseResultsAlevel : UserControl
    {
        public ClassWiseResultsAlevel()
        {
            InitializeComponent();
        }

        private void ClassWiseResultsAlevel_Load(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
        }
    }
}
