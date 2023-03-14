using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Subject_category
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

        private string _category;
        public string category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
    }
}
