using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Department_allocations
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

        private int _staff_id;
        public int staff_id
        {
            get
            {
                return _staff_id;
            }
            set
            {
                _staff_id = value;
            }
        }

        private int _dep_id;
        public int dep_id
        {
            get
            {
                return _dep_id;
            }
            set
            {
                _dep_id = value;
            }
        }
    }
}
