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
    class Classes
    {
        private int _class_id;
        public int class_id
        {
            get
            {
                return _class_id;
            }
            set
            {
                _class_id = value;
            }
        }

        private string _full_name;
        public string full_name
        {
            get
            {
                return _full_name;
            }
            set
            {
                _full_name = value;
            }
        }

        private string _cname;
        public string cname
        {
            get
            {
                return _cname;
            }
            set
            {
                _cname = value;
            }
        }

        private int _level_id;
        public int level_id
        {
            get
            {
                return _level_id;
            }
            set
            {
                _level_id = value;
            }
        }
        private int _class_position;
        public int class_position
        {
            get
            {
                return _class_position;
            }
            set
            {
                _class_position = value;
            }
        }
    }
}
