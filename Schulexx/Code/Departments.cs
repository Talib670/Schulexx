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
    class Departments
    {
        private int _Dep_id;
        public int Dep_id
        {
            get
            {
                return _Dep_id;
            }
            set
            {
                _Dep_id = value;
            }
        }

        private string _DepName;
        public string DepName
        {
            get
            {
                return _DepName;
            }
            set
            {
                _DepName = value;
            }
        }

        private string _dep_type;
        public string dep_type
        {
            get
            {
                return _dep_type;
            }
            set
            {
                _dep_type = value;
            }
        }

        private string _Description;
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }
    }
}
