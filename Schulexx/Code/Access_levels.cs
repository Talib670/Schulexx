using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Access_levels
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

        private int _user_id;
        public int user_id
        {
            get
            {
                return _user_id;
            }
            set
            {
                _user_id = value;
            }
        }

        private string _access_level;
        public string access_level
        {
            get
            {
                return _access_level;
            }
            set
            {
                _access_level = value;
            }
        }
    }
}
