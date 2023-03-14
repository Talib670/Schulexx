using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Subject_class_papers
    {
        private int _paper_id;
        public int paper_id
        {
            get
            {
                return _paper_id;
            }
            set
            {
                _paper_id = value;
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

        private string _description;
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

    }
}
