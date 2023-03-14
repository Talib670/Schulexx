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
    class Admissions
    {
        private int _admission_id;
        public int admission_id
        {
            get
            {
                return _admission_id;
            }
            set
            {
                _admission_id = value;
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

        private int _admission_year;
        public int admission_year
        {
            get
            {
                return _admission_year;
            }
            set
            {
                _admission_year = value;
            }
        }
    }
}
