using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Week_days
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

        private string _day_name;
        public string day_name
        {
            get
            {
                return _day_name;
            }
            set
            {
                _day_name = value;
            }
        }

        private string _day_abbrev;
        public string day_abbrev
        {
            get
            {
                return _day_abbrev;
            }
            set
            {
                _day_abbrev = value;
            }
        }

        private int _position;
        public int position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }
    }
}
