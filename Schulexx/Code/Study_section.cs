using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Study_section
    {
        private int _study_section_id;
        public int study_section_id
        {
            get
            {
                return _study_section_id;
            }
            set
            {
                _study_section_id = value;
            }
        }

        private string _study_section_name;
        public string study_section_name
        {
            get
            {
                return _study_section_name;
            }
            set
            {
                _study_section_name = value;
            }
        }

    }
}
