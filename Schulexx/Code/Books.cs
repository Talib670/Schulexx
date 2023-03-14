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
    class Books
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

        private string _bookName;
        public string bookName
        {
            get
            {
                return _bookName;
            }
            set
            {
                _bookName = value;
            }
        }

        private string _Author;
        public string Author
        {
            get
            {
                return _Author;
            }
            set
            {
                _Author = value;
            }
        }


        private string _Publisher;
        public string Publisher
        {
            get
            {
                return _Publisher;
            }
            set
            {
                _Publisher = value;
            }
        }

        private int _level_id;
        public int level_id
        {
            get
            {
                return _level_id;
            }
            set
            {
                _level_id = value;
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

        private string _Book_descritpion;
        public string Book_descritpion	
        {
            get
            {
                return _Book_descritpion;
            }
            set
            {
                _Book_descritpion = value;
            }
        }

    }
}
