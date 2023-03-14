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
    class Studentclubs
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

        private string _club_name;
        public string club_name
        {
            get
            {
                return _club_name;
            }
            set
            {
                _club_name = value;
            }
        }

        private string _club_type;
        public string club_type
        {
            get
            {
                return _club_type;
            }
            set
            {
                _club_type = value;
            }
        }

        private int _stLeader_id;
        public int stLeader_id
        {
            get
            {
                return _stLeader_id;
            }
            set
            {
                _stLeader_id = value;
            }
        }

        private int _stfpatron_id;
        public int stfpatron_id
        {
            get
            {
                return _stfpatron_id;
            }
            set
            {
                _stfpatron_id = value;
            }
        }

        private string _status;
        public string status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        private string _activities_descr;
        public string activities_descr
        {
            get
            {
                return _activities_descr;
            }
            set
            {
                _activities_descr = value;
            }
        }
    }
}
