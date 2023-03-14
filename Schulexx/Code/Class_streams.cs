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
    class Class_streams
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
        private string _stream_label;
        public string stream_label
        {
            get
            {
                return _stream_label;
            }
            set
            {
                _stream_label = value;
            }
        }

        private string _stream_desc;
        public string stream_desc
        {
            get
            {
                return _stream_desc;
            }
            set
            {
                _stream_desc = value;
            }
        }

    }

}