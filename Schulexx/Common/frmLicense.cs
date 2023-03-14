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
    public partial class frmLicense : Form
    {
        public frmLicense(bool IsLicFound)
        {
            InitializeComponent();
            if (!IsLicFound)
                label2.Text = "SchulEX License Not Found.";
            else
                label2.Text = "Invalid SchulEX License.";
        }

        private void frmLicense_Load(object sender, EventArgs e)
        {
            textBox1.Text = CryptoLib.FingerPrint.Value();
        }
    }
}
