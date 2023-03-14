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
    public class Subjects
    {
        private int _subject_id;
        public int subject_id
        {
            get
            {
                return _subject_id;
            }
            set
            {
                _subject_id = value;
            }
        }

        private int _category_id;
        public int category_id
        {
            get
            {
                return _category_id;
            }
            set
            {
                _category_id = value;
            }
        }

        private int _subject_code;
        public int subject_code
        {
            get
            {
                return _subject_code;
            }
            set
            {
                _subject_code = value;
            }
        }

        private string _sname;
        public string sname
        {
            get
            {
                return _sname;
            }
            set
            {
                _sname = value;
            }
        }

        private string _sub_short;
        public string sub_short
        {
            get
            {
                return _sub_short;
            }
            set
            {
                _sub_short = value;
            }
        }

        private string _compulsory;
        public string compulsory
        {
            get
            {
                return _compulsory;
            }
            set
            {
                _compulsory = value;
            }
        }
    }
}
