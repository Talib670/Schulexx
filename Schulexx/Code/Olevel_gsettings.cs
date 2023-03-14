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
    class Olevel_gsettings
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

        private int _marks_from;
        public int marks_from
        {
            get
            {
                return _marks_from;
            }
            set
            {
                _marks_from = value;
            }
        }

        private int _marks_upto;
        public int marks_upto
        {
            get
            {
                return _marks_upto;
            }
            set
            {
                _marks_upto = value;
            }
        }

        private string _grade;
        public string grade
        {
            get
            {
                return _grade;
            }
            set
            {
                _grade = value;
            }
        }

        private int _points;
        public int points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
            }
        }

        private string _comment;
        public string comment	
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = value;
            }
        }
    }
}
