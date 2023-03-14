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
    class Suppliers
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

        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _category;
        public string category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
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

        private string _physical_address;
        public string physical_address
        {
            get
            {
                return _physical_address;
            }
            set
            {
                _physical_address = value;
            }
        }

        private string _country;
        public string country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }

    }
}
