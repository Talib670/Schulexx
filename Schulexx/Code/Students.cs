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
    class Students
    {

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

        private string _reg_number;
        public string reg_number
        {
            get
            {
                return _reg_number;
            }
            set
            {
                _reg_number = value;
            }
        }

        private string _fname;
        public string fname
        {
            get
            {
                return _fname;
            }
            set
            {
                _fname = value;
            }
        }

        private string _lname;
        public string lname
        {
            get
            {
                return _lname;
            }
            set
            {
                _lname = value;
            }
        }

        private string _gender;
        public string gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        private string _Religion;
        public string Religion
        {
            get
            {
                return _Religion;
            }
            set
            {
                _Religion = value;
            }
        }

        private DateTime _BirthDate;
        public DateTime BirthDate
        {
            get
            {
                return _BirthDate;
            }
            set
            {
                _BirthDate = value;
            }
        }


        private string _homeContact;
        public string homeContact
        {
            get
            {
                return _homeContact;
            }
            set
            {
                _homeContact = value;
            }
        }

        private string _homedistrict;
        public string homedistrict
        {
            get
            {
                return _homedistrict;
            }
            set
            {
                _homedistrict = value;
            }
        }

        private string _homeVillage;
        public string homeVillage
        {
            get
            {
                return _homeVillage;
            }
            set
            {
                _homeVillage = value;
            }
        }

        private string _nationality;
        public string nationality
        {
            get
            {
                return _nationality;
            }
            set
            {
                _nationality = value;
            }
        }
        private int _study_section_id;
        public int study_section_id
        {
            get
            {
                return _study_section_id;
            }
            set
            {
                _study_section_id = value;
            }
        }
        private string _admission_year;
        public string admission_year
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
        private byte[] _stud_pic;
        public byte[] stud_pic
        {
            get
            {
                return _stud_pic;
            }
            set
            {
                _stud_pic = value;
            }
        }


    }
}
