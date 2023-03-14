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
    class School_heads
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

        private string _position;
        public string position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
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

        private string _head_type;
        public string head_type
        {
            get
            {
                return _head_type;
            }
            set
            {
                _head_type = value;
            }
        }
    }
}
