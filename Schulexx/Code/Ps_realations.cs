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
    class Ps_realations
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

        private int _parents_id;
        public int parents_id
        {
            get
            {
                return _parents_id;
            }
            set
            {
                _parents_id = value;
            }
        }

        private int _students_id;
        public int students_id
        {
            get
            {
                return _students_id;
            }
            set
            {
                _students_id = value;
            }
        }

        private string _Relationtostudents;
        public string Relationtostudents
        {
            get
            {
                return _Relationtostudents;
            }
            set
            {
                _Relationtostudents = value;
            }
        }
    }
}
