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
    class Staff_attendances
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

        private int _staffID;
        public int staffID
        {
            get
            {
                return _staffID;
            }
            set
            {
                _staffID = value;
            }
        }

        private string _Astatus;
        public string Astatus
        {
            get
            {
                return _Astatus;
            }
            set
            {
                _Astatus = value;
            }
        }

        private DateTime _Date;
        public DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                _Date = value;
            }
        }


    }
}
