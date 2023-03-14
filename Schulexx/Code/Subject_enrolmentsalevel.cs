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
    class Subject_enrolmentsalevel
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

        private int _stud_id;
        public int stud_id
        {
            get
            {
                return _stud_id;
            }
            set
            {
                _stud_id = value;
            }
        }
        private int _subj_id;
        public int subj_id	
        {
            get
            {
                return _subj_id;
            }
            set
            {
                _subj_id = value;
            }
        }
        private int _year;
        public int year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
    }
}
