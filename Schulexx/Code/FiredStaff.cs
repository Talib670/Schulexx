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
    class FiredStaff
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

        private int _staff_id;
        public int staff_id
        {
            get
            {
                return _staff_id;
            }
            set
            {
                _staff_id = value;
            }
        }

        private string _reason;
        public string reason
        {
            get
            {
                return _reason;
            }
            set
            {
                _reason = value;
            }
        }

        private DateTime _date;
        public DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
    }
}
