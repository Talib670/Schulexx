using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Model;

namespace Schulexx.Controls
{
    public partial class ClassWiseResults : UserControl
    {
        public ClassWiseResults()
        {
            InitializeComponent();
        }

        private void ClassWiseResults_Load(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            using (schulex_dbEntities db = new schulex_dbEntities())
            {
                //db.exam_terms.First().
                //db.levels.First().classes.First().exams.First().exam_sessions;
            }
        }
    }
}
