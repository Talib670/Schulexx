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
    class Books_returned
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

        private DateTime _date_returned;
        public DateTime date_returned	
        {
            get
            {
                return _date_returned;
            }
            set
            {
                _date_returned = value;
            }
        }
    }
}
