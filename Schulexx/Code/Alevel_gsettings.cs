using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Alevel_gsettings
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

        private int _from_mark;
        public int from_mark	
        {
            get
            {
                return _from_mark;
            }
            set
            {
                _from_mark = value;
            }
        }

        private int _upto_mark;
        public int upto_mark
        {
            get
            {
                return _upto_mark;
            }
            set
            {
                _upto_mark = value;
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

    }
}
