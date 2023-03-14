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
    class Books_takenbystaff
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

        private DateTime _date_due_return;
        public DateTime date_due_return
        {
            get
            {
                return _date_due_return;
            }
            set
            {
                _date_due_return = value;
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

        private int _bookCopy_id;
        public int bookCopy_id
        {
            get
            {
                return _bookCopy_id;
            }
            set
            {
                _bookCopy_id = value;
            }
        }
    }
}
