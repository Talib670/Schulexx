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
    class Mdd
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

        private string _ch_name;
        public string ch_name
        {
            get
            {
                return _ch_name;
            }
            set
            {
                _ch_name = value;
            }
        }

        private int _ch_leader;
        public int ch_leader
        {
            get
            {
                return _ch_leader;
            }
            set
            {
                _ch_leader = value;
            }
        }

        private int _ch_patron;
        public int ch_patron
        {
            get
            {
                return _ch_patron;
            }
            set
            {
                _ch_patron = value;
            }
        }

        private string _ch_type;
        public string ch_type
        {
            get
            {
                return _ch_type;
            }
            set
            {
                _ch_type = value;
            }
        }

    }
}
