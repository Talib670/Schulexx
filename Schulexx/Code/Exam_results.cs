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
    class Exam_results
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

        private int _exam_id;
        public int exam_id
        {
            get
            {
                return _exam_id;
            }
            set
            {
                _exam_id = value;
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

        private string _teacher_comment;
        public string teacher_comment
        {
            get
            {
                return _teacher_comment;
            }
            set
            {
                _teacher_comment = value;
            }
        }

      
    }
}
