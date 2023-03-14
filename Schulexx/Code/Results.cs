using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    public class Results
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

        private int _Exam_id;
        public int Exam_id
        {
            get
            {
                return _Exam_id;
            }
            set
            {
                _Exam_id = value;
            }
        }

        private int _mark;
        public int mark
        {
            get
            {
                return _mark;
            }
            set
            {
                _mark = value;
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

        private string _teachers_comment;
        public string teachers_comment
        {
            get
            {
                return _teachers_comment;
            }
            set
            {
                _teachers_comment = value;
            }
        }

        private int _updated_by;
        public int updated_by
        {
            get
            {
                return _updated_by;
            }
            set
            {
                _updated_by = value;
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

        private string _exam_session;
        public string exam_session
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
    }
}
