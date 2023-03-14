using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Stclub_allocations
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

        private int _club_id;
        public int club_id
        {
            get
            {
                return _club_id;
            }
            set
            {
                _club_id = value;
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
    }
}
