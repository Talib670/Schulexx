using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    public class Subjects_alevel
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
        private string _subj_name;
        public string subj_name
        {
            get
            {
                return _subj_name;
            }
            set
            {
                _subj_name = value;
            }
        }

        private int _subj_code;
        public int subj_code
        {
            get
            {
                return _subj_code;
            }
            set
            {
                _subj_code = value;
            }
        }

        private string _subj_short;
        public string subj_short
        {
            get
            {
                return _subj_short;
            }
            set
            {
                _subj_short = value;
            }
        }

        private string _subj_type;
        public string subj_type
        {
            get
            {
                return _subj_type;
            }
            set
            {
                _subj_type = value;
            }
        }

    }
}
