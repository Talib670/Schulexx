using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Schulexx.Code
{
    class Time_tables
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

        private int _year;
        public int year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        private int _class_id;
        public int class_id
        {
            get
            {
                return _class_id;
            }
            set
            {
                _class_id = value;
            }
        }

        private int _subject_id;
        public int subject_id
        {
            get
            {
                return _subject_id;
            }
            set
            {
                _subject_id = value;
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

        private int _weekDay_id;
        public int weekDay_id
        {
            get
            {
                return _weekDay_id;
            }
            set
            {
                _weekDay_id = value;
            }
        }

        private string _TimeTable_type;
        public string TimeTable_type
        {
            get
            {
                return _TimeTable_type;
            }
            set
            {
                _TimeTable_type = value;
            }
        }
    }
}
