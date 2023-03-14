using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Controls;

namespace Schulexx.LibraryUI
{
    public partial class NewBook_Copy : Form
    {
        public NewBook_Copy(int get_id)
        {
            InitializeComponent();
            get_id1 = get_id;
        }
        int get_id1;

        private void NewBook_Copy_Load(object sender, EventArgs e)
        {
            BookNew_Copy Class_enroll = new BookNew_Copy(get_id1);
            panel1.Controls.Add(Class_enroll);
            Class_enroll.BringToFront();
            Class_enroll.Dock = DockStyle.Fill;
        }
    }
}
