using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx
{
    class holdme_Class
    {

        public static string regCo()
        {
            //return ("Data Source=" + Schulexx.Properties.Settings.Default.server + ";Database=schulex_db ;User ID=" + Schulexx.Properties.Settings.Default.user + ";Password=" + Schulexx.Properties.Settings.Default.password + ";" + "Protocol=TCP;");
            return Properties.Settings.Default.schulex_dbConnectionString; 
        }

        public void stry()
        {
            try
            {
                Schulexx.Properties.Settings.Default["SchulexxConnectionString"] = regCo();
                Schulexx.Properties.Settings.Default.Save();
            }
            catch { }

        }

    }
}
