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
    class Staff
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

        private string _staffNo;
        public string staffNo
        {
            get
            {
                return _staffNo;
            }
            set
            {
                _staffNo = value;
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
        private string _Staff_initials;
        public string Staff_initials
        {
            get
            {
                return _Staff_initials;
            }
            set
            {
                _Staff_initials = value;
            }
        }


        private string _maritalStatus;
        public string maritalStatus
        {
            get
            {
                return _maritalStatus;
            }
            set
            {
                _maritalStatus = value;
            }
        }

        private string _Gender;
        public string Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
            }
        }

        private DateTime _DOB;
        public DateTime DOB
        {
            get
            {
                return _DOB;
            }
            set
            {
                _DOB = value;
            }
        }

        private string _phoneNumber;
        public string phoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }

        }

        private string _EmailAddress;
        public string EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                _EmailAddress = value;
            }

        }

        private string _currentResidence;
        public string currentResidence
        {
            get
            {
                return _currentResidence;
            }
            set
            {
                _currentResidence = value;
            }

        }

        private string _district;
        public string district
        {
            get
            {
                return _district;
            }
            set
            {
                _district = value;
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

        private string _staff_type;
        public string staff_type
        {
            get
            {
                return _staff_type;
            }
            set
            {
                _staff_type = value;
            }

        }
        private byte[] _staff_pic;
        public byte[] staff_pic
        {
            get
            {
                return _staff_pic;
            }
            set
            {
                _staff_pic = value;
            }

        }

    }
}
