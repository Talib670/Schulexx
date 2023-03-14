using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Schulexx.Code
{
    class System_settings
    {
        private int _id;
        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        private int _current_year;
        public int current_year
        {
            get
            {
                return _current_year;
            }
            set
            {
                _current_year = value;
            }
        }

        private string _subscriptions;
        public string subscriptions
        {
            get
            {
                return _subscriptions;
            }
            set
            {
                _subscriptions = value;
            }
        }

    }
}
