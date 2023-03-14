using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Dormitry_allocations
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

        private int _dormitry_id;
        public int dormitry_id
        {
            get
            {
                return _dormitry_id;
            }
            set
            {
                _dormitry_id = value;
            }
        }
    }
}
