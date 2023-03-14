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
    class Book_copies
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

        private int _Mainbook_id;
        public int Mainbook_id
        {
            get
            {
                return _Mainbook_id;
            }
            set
            {
                _Mainbook_id = value;
            }
        }
        private string _book_number;
        public string book_number
        {
            get
            {
                return _book_number;
            }
            set
            {
                _book_number = value;
            }
        }

        private string _availability_status;
        public string availability_status
        {
            get
            {
                return _availability_status;
            }
            set
            {
                _availability_status = value;
            }
        }
    }
}
