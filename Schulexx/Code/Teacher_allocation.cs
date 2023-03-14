using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Teacher_allocation
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

        private int _teacher_id	;
        public int teacher_id
        {
            get
            {
                return _teacher_id;
            }
            set
            {
                _teacher_id = value;
            }
        }

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

        private int _year;
        public int year
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
    }
}
