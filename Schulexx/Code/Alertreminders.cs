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
    class Alertreminders
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

        private string _rbody;
        public string rbody
        {
            get
            {
                return _rbody;
            }
            set
            {
                _rbody = value;
            }
        }

        private string _title;
        public string title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        private string _message_type;
        public string message_type
        {
            get
            {
                return _message_type;
            }
            set
            {
                _message_type = value;
            }
        }
    }
}
