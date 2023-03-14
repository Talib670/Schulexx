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
    class School_details
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

        private string _school_name;
        public string school_name
        {
            get
            {
                return _school_name;
            }
            set
            {
                _school_name = value;
            }
        }

        private string _motto;
        public string motto
        {
            get
            {
                return _motto;
            }
            set
            {
                _motto = value;
            }
        }

        private string _PhysicalAddress;
        public string PhysicalAddress	
        {
            get
            {
                return _PhysicalAddress;
            }
            set
            {
                _PhysicalAddress = value;
            }
        }

        private string _Telephone;
        public string Telephone
        {
            get
            {
                return _Telephone;
            }
            set
            {
                _Telephone = value;
            }
       
        }

        private string _email_address;
        public string email_address
        {
            get
            {
                return _email_address;
            }
            set
            {
                _email_address = value;
            }

        }

        private string _website;
        public string website
        {
            get
            {
                return _website;
            }
            set
            {
                _website = value;
            }

        }
        private byte[] _logo;
        public byte[] logo
        {
            get
            {
                return _logo;
            }
            set
            {
                _logo = value;
            }
        }

        public string Abbreviation { get; set; }
    }
}
