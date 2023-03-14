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
    class Department_heads
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

        private int _dep_id;
        public int dep_id
        {
            get
            {
                return _dep_id;
            }
            set
            {
                _dep_id = value;
            }
        }

        private int _head_id;
        public int head_id
        {
            get
            {
                return _head_id;
            }
            set
            {
                _head_id = value;
            }
        }

        private string _leader_type;
        public string leader_type	
        {
            get
            {
                return _leader_type;
            }
            set
            {
                _leader_type = value;
            }
        }

    }
}
