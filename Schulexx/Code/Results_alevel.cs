using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    public class Results_alevel
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

        private int _students_id;
        public int students_id
        {
            get
            {
                return _students_id;
            }
            set
            {
                _students_id = value;
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

        private string _ExamSession;
        public string ExamSession
        {
            get
            {
                return _ExamSession;
            }
            set
            {
                _ExamSession = value;
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
        private int _paper_number;
        public int paper_number
        {
            get
            {
                return _paper_number;
            }
            set
            {
                _paper_number = value;
            }
        }

        private int _mark_Obtained;
        public int mark_Obtained
        {
            get
            {
                return _mark_Obtained;
            }
            set
            {
                _mark_Obtained = value;
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
