using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class User_activity_log
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

        private DateTime _time;
        public DateTime time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }

        private string _ActionPerformed;
        public string ActionPerformed
        {
            get
            {
                return _ActionPerformed;
            }
            set
            {
                _ActionPerformed = value;
            }
        }

        private string _log_ip;
        public string log_ip
        {
            get
            {
                return _log_ip;
            }
            set
            {
                _log_ip = value;
            }
        }
        private string _computerName;
        public string computerName
        {
            get
            {
                return _computerName;
            }
            set
            {
                _computerName = value;
            }
        }
    }
}
