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
    public partial class NewAdmission : UserControl
    {
        public NewAdmission(int get_id)
        {
            InitializeComponent();
            get_id1 = get_id;
        }
        int get_id1;
        Admissions local_admission = new Admissions();
        AdmissionsDataAdapter Process_admission = new AdmissionsDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            local_admission.admission_id = get_id;
            local_admission.student_id = get_id1;
            local_admission.admission_year = int.Parse (new Connectoperations().validate_All_Data(dateTimePicker1.Value.ToString()));
            if(get_id==0){
                Process_admission.Insert(local_admission);
            }
                else{
                    Process_admission.Update(local_admission);
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void NewAdmission_Load(object sender, EventArgs e)
        {
            label1.Text = "Submitting" + ' ' + new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + get_id1 + "'")+"'s " +' '+"Admission";
        }

    }
}
