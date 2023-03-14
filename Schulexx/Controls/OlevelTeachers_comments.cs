using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Data;
using Schulexx.Model;
using Schulexx.Code;

namespace Schulexx.Controls
{
    public partial class OlevelMarks_sheet : UserControl
    {
        public OlevelMarks_sheet()
        {
            InitializeComponent();
        }

        ClassesDataAdapter process_class = new ClassesDataAdapter();
        List<Classes> load_classes = new List<Classes>();

        public void load_class()
        {

            try
            {
                class_cbx.Items.Clear();
                load_classes = process_class.GetClassesList("where level_id=" + new Connectoperations().singleval("levels", "id", "where name= 'Ordinary Level'"));

                foreach (Classes ee in load_classes)
                {

                    class_cbx.Items.Add(ee.cname);

                }
            }
            catch { }

        }

        private void OlevelMarks_sheet_Load(object sender, EventArgs e)
        {
            load_class();
        }
    }
}
