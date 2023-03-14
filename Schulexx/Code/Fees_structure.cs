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
    class Fees_structure
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

        private string _Fee_type;
        public string Fee_type
        {
            get
            {
                return _Fee_type;
            }
            set
            {
                _Fee_type = value;
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
        private string _study_section;
        public string study_section
        {
            get
            {
                return _study_section;
            }
            set
            {
                _study_section = value;
            }
        }
        private decimal _suggestedAmount;
        public decimal suggestedAmount	
        {
            get
            {
                return _suggestedAmount;
            }
            set
            {
                _suggestedAmount = value;
            }
        }
    }
}
