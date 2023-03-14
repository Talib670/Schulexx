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
    class Expulsion
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
        private string _Reason;
        public string Reason
        {
            get
            {
                return _Reason;
            }
            set
            {
                _Reason = value;
            }
        }

        private DateTime _DateIssued;
        public DateTime DateIssued
        {
            get
            {
                return _DateIssued;
            }
            set
            {
                _DateIssued = value;
            }
        }

        private int _IsuedBy;
        public int IsuedBy
        {
            get
            {
                return _IsuedBy;
            }
            set
            {
                _IsuedBy = value;
            }
        }
    }
}
