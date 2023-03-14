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
    class Studentathletics
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

        private string _sp_name;
        public string sp_name
        {
            get
            {
                return _sp_name;
            }
            set
            {
                _sp_name = value;
            }
        }

        private int _stf_patronId;
        public int stf_patronId
        {
            get
            {
                return _stf_patronId;
            }
            set
            {
                _stf_patronId = value;
            }
        }

        private string _designed_for;
        public string designed_for
        {
            get
            {
                return _designed_for;
            }
            set
            {
                _designed_for = value;
            }
        }
    }
}
