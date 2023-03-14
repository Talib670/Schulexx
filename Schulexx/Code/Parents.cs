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
    class Parents
    {

        private int _parent_id;
        public int parent_id
        {
            get
            {
                return _parent_id;
            }
            set
            {
                _parent_id = value;
            }
        }
        private string _pnumber;
        public string pnumber
        {
            get
            {
                return _pnumber;
            }
            set
            {
                _pnumber = value;
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

        private string _genda;
        public string genda
        {
            get
            {
                return _genda;
            }
            set
            {
                _genda = value;
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

        private string _phone;
        public string phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }

        }

        private string _Email;
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }

        }

        private string _WorkAddress;
        public string WorkAddress
        {
            get
            {
                return _WorkAddress;
            }
            set
            {
                _WorkAddress = value;
            }

        }

        private string _HomeAddress;
        public string HomeAddress
        {
            get
            {
                return _HomeAddress;
            }
            set
            {
                _HomeAddress = value;
            }

        }

        private string _occupation;
        public string occupation
        {
            get
            {
                return _occupation;
            }
            set
            {
                _occupation = value;
            }

        }

        private byte[] _par_pic;
        public byte[] par_pic
        {
            get
            {
                return _par_pic;
            }
            set
            {
                _par_pic = value;
            }

        }

    }
}
