using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Time_tableactivity
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

        private int _day_id;
        public int day_id
        {
            get
            {
                return _day_id;
            }
            set
            {
                _day_id = value;
            }
        }

        private string _activity;
        public string activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
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

        private DateTime _end_time;
        public DateTime end_time
        {
            get
            {
                return _end_time;
            }
            set
            {
                _end_time = value;
            }
        }
    }
}
