using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Forms;
using System.Diagnostics;
using System.IO;
using Schulexx.CommonUI;
using Schulexx.Model;
using Schulexx.StudentsUI;

namespace Schulexx
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!CheckLicense())
            {
                //License file not found
                Application.Run(new frmLicense(false));
                return;
            }
            //License File Found
            DateTime? ExpDate = ValidateLicense();
            if (!ExpDate.HasValue)
            {
                //Validation Failed
                Application.Run(new frmLicense(true));
                return;
            }

            //Valid License Found
            //Validate Date
            Tuple<bool, string> res = IsValidLicense(ExpDate.Value);

            //if (!res.Item1)
            //{
            //    if (string.IsNullOrEmpty(res.Item2))
            //    {
            //        MessageBox.Show("Trial Period is Over. Please contact product vendor.", "SchulEX License Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error occured validating license. Pl. try again." +
            //            Environment.NewLine + "Error Details - " + res.Item2);
            //    }
                
            //}

            Application.Run(new AssignMdd());
        }

        private static Tuple<bool, string> IsValidLicense(DateTime lastDate)
        {

            if (DateTime.Now > lastDate) return new Tuple<bool, string>(false, string.Empty);

            try
            {
                using (var db = new schulex_dbEntities())
                {
                    var lc = db.license_check.FirstOrDefault();
                    if (lc == null)
                    {
                        db.license_check.Add(new license_check() { last_run = DateTime.Now });
                        db.SaveChanges();
                        return new Tuple<bool, string>(true, string.Empty);
                    }

                    if (lc.last_run.HasValue && DateTime.Now < lc.last_run.Value)
                    {
                        return new Tuple<bool, string>(false, string.Empty);
                    }

                    lc.last_run = DateTime.Now;
                    db.SaveChanges();
                    return new Tuple<bool, string>(true, string.Empty);
                }
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
            }
        }

        private static bool CheckLicense()
        {
            var LicFileName = Path.Combine(Application.StartupPath, "Schulex.lic");
            try
            {
                if (!File.Exists(LicFileName))
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static DateTime? ValidateLicense()
        {
            var LicFileName = Path.Combine(Application.StartupPath, "Schulex.lic");
            string encStr = File.ReadAllText(LicFileName);
            return CryptoLib.LicenseHelper.ValidateLicense(encStr, CryptoLib.FingerPrint.Value());
        }
    }
}
