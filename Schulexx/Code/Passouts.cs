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
    class Passouts
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

        private int _student_id;
        public int student_id
        {
            get
            {
                return _student_id;
            }
            set
            {
                _student_id = value;
            }
        }

        private DateTime _date_issued;
        public DateTime date_issued
        {
            get
            {
                return _date_issued;
            }
            set
            {
                _date_issued = value;
            }
        }

        private DateTime _returned_date;
        public DateTime returned_date
        {
            get
            {
                return _returned_date;
            }
            set
            {
                _returned_date = value;
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
    }
}
