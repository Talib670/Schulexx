using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schulexx.ClassUI
{
    public partial class UcStudentStreamAssign : UserControl
    {
        public UcStudentStreamAssign()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Clear();
        }
    }
}
