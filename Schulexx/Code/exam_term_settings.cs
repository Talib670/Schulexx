using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Exam_term_settings
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

        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _Abbreviation;
        public string Abbreviation
        {
            get
            {
                return _Abbreviation;
            }
            set
            {
                _Abbreviation = value;
            }
        }
    }
}
