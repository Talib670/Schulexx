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
    class Suspensions
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

        private DateTime _date_of_suspension;
        public DateTime date_of_suspension
        {
            get
            {
                return _date_of_suspension;
            }
            set
            {
                _date_of_suspension = value;
            }
        }


        private DateTime _return_date;
        public DateTime return_date	
        {
            get
            {
                return _return_date;
            }
            set
            {
                _return_date = value;
            }
        }


        private string _suspension_reasons;
        public string suspension_reasons
        {
            get
            {
                return _suspension_reasons;
            }
            set
            {
                _suspension_reasons = value;
            }
        }

    }
}
