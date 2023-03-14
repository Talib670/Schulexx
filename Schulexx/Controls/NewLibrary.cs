using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Forms;

namespace Schulexx.Controls
{
    public partial class NewLibrary : UserControl
    {
        public NewLibrary()
        {
            InitializeComponent();
        }

        private void RetunBook_Click(object sender, EventArgs e)
        {
            new ReturnBook().ShowDialog();
        }

        private void Btn_Bkdetails_Click(object sender, EventArgs e)
        {
            new BookDetails().ShowDialog();
        }
    }
}
