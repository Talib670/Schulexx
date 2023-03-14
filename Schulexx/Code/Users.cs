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
    class Users
    {

        private int _user_id;
        public int user_id
        {
            get
            {
                return _user_id;
            }
            set
            {
                _user_id = value;
            }
        }

        private int _staff_id;
        public int staff_id
        {
            get
            {
                return _staff_id;
            }
            set
            {
                _staff_id = value;
            }
        }

        private string _username;
        public string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        private string _password;
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        private string _userStatus;
        public string userStatus
        {
            get
            {
                return _userStatus;
            }
            set
            {
                _userStatus = value;
            }
        }
        private int _access_level_id;
        public int access_level_id
        {
            get
            {
                return _access_level_id;
            }
            set
            {
                _access_level_id = value;
            }
        }
        private DateTime _dateCreated;
        public DateTime dateCreated
        {
            get
            {
                return _dateCreated;
            }
            set
            {
                _dateCreated = value;
            }
        }

    }
}
