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
    class Allowances
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

        private int _staff_id;
        public int staff_id
        {
            get
            {
                return _staff_id;
            }
            set
            {
                _staff_id = value;
            }
        }

        private string _allowance_for;
        public string allowance_for
        {
            get
            {
                return _allowance_for;
            }
            set
            {
                _allowance_for = value;
            }
        }

        private decimal _amount;
        public decimal amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        private DateTime _date_given;
        public DateTime date_given
        {
            get
            {
                return _date_given;
            }
            set
            {
                _date_given = value;
            }
        }
    }
}
