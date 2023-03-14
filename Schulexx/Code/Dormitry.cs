using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Dormitry
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

        private string _dormitry_name;
        public string dormitry_name
        {
            get
            {
                return _dormitry_name;
            }
            set
            {
                _dormitry_name = value;
            }
        }

        private int _dormitry_leader;
        public int dormitry_leader
        {
            get
            {
                return _dormitry_leader;
            }
            set
            {
                _dormitry_leader = value;
            }
        }
    }
}
