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
    class Student_attendances
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

        private int _class_id;
        public int class_id
        {
            get
            {
                return _class_id;
            }
            set
            {
                _class_id = value;
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

        private int _approved_by;
        public int approved_by
        {
            get
            {
                return _approved_by;
            }
            set
            {
                _approved_by = value;
            }
        }

    }
}
