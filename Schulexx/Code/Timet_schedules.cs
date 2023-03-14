using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Timet_schedules
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

        private string _schedule_name;
        public string schedule_name
        {
            get
            {
                return _schedule_name;
            }
            set
            {
                _schedule_name = value;
            }
        }

        private DateTime _start_time;
        public DateTime start_time
        {
            get
            {
                return _start_time;
            }
            set
            {
                _start_time = value;
            }
        }

        private DateTime _End_time;
        public DateTime End_time
        {
            get
            {
                return _End_time;
            }
            set
            {
                _End_time = value;
            }
        }

        private string _time_mode;
        public string time_mode
        {
            get
            {
                return _time_mode;
            }
            set
            {
                _time_mode = value;
            }
        }
    }
}
