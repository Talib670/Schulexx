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
    class Studentleaders
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

        private string _leadership_type;
        public string leadership_type
        {
            get
            {
                return _leadership_type;
            }
            set
            {
                _leadership_type = value;
            }
        }

        private string _positon;
        public string positon
        {
            get
            {
                return _positon;
            }
            set
            {
                _positon = value;
            }
        }

        private string _position_type;
        public string position_type
        {
            get
            {
                return _position_type;
            }
            set
            {
                _position_type = value;
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

    }
}
