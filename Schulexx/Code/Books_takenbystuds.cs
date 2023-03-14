using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Books_takenbystuds
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

        private int _student_id;
        public int student_id
        {
            get
            {
                return _student_id;
            }
            set
            {
                _student_id = value;
            }
        }

        private int _bookCopy_id;
        public int bookCopy_id
        {
            get
            {
                return _bookCopy_id;
            }
            set
            {
                _bookCopy_id = value;
            }
        }

        private DateTime _date_hired;
        public DateTime date_hired
        {
            get
            {
                return _date_hired;
            }
            set
            {
                _date_hired = value;
            }
        }

        private DateTime _date_of_return;
        public DateTime date_of_return
        {
            get
            {
                return _date_of_return;
            }
            set
            {
                _date_of_return = value;
            }
        }
    }
}
