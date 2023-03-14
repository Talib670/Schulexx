using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Stathletics_allocation
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

        private int _athletics_id;
        public int athletics_id
        {
            get
            {
                return _athletics_id;
            }
            set
            {
                _athletics_id = value;
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
    }
}
