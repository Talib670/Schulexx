using Schulexx.ErrorHandling;
using Schulexx.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schulexx.ConfigureUI
{
    public partial class NextTermBeginsOn : Form
    {
        public NextTermBeginsOn()
        {
            InitializeComponent();
        }

        private void NextTermBeginsOn_Load(object sender, EventArgs e)
        {
        }

        private void NextTermBeginsOn_Shown(object sender, EventArgs e)
        {
            using (var db = new schulex_dbEntities())
            {
                var nextTerm = db.next_term.FirstOrDefault();
                if (nextTerm == null)
                {
                    dtpStart.Value = DateTime.Today;
                    //dtpEnd.Value = DateTime.Today;
                }
                else
                {
                    dtpStart.Value = nextTerm.start_date;
                    //dtpEnd.Value = nextTerm.end_date;
                }
            }
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            //if(dtpEnd.Value.Date < dtpStart.Value.Date)
            if (DateTime.Today < dtpStart.Value.Date)
            {
                ErrorHelper.ShowError(this, "Next Term start date cannot be less today.");
                return;
            }
            try
            {
                using (var db = new schulex_dbEntities())
                {
                    var nextTerm = db.next_term.FirstOrDefault();
                    if (nextTerm == null)
                    {
                        nextTerm = new next_term();
                        nextTerm.start_date = dtpStart.Value.Date;
                        //nextTerm.end_date = dtpEnd.Value.Date;
                        db.next_term.Add(nextTerm);
                    }
                    else
                    {
                        nextTerm.start_date = dtpStart.Value.Date;
                        //nextTerm.end_date = dtpEnd.Value.Date;
                    }
                    db.SaveChanges();
                    ErrorHelper.ShowSuccess(this, "Updated Next Term Dates");
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.ShowError(this, "Failed. Details - " + ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
