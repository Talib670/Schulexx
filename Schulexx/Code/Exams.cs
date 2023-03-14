using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Exams
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

        private int _exam_session;
        public int exam_session	
        {
            get
            {
                return _exam_session;
            }
            set
            {
                _exam_session = value;
            }
        }

        private string _term;
        public string term
        {
            get
            {
                return _term;
            }
            set
            {
                _term = value;
            }
        }

        private DateTime _start_date;
        public DateTime start_date
        {
            get
            {
                return _start_date;
            }
            set
            {
                _start_date = value;
            }
        }
        private DateTime _end_date;
        public DateTime end_date
        {
            get
            {
                return _end_date;
            }
            set
            {
                _end_date = value;
            }
        }
        private string _year;
        public string year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        private int _set_out_of;
        public int set_out_of
        {
            get
            {
                return _set_out_of;
            }
            set
            {
                _set_out_of = value;
            }
        }
    }
}
