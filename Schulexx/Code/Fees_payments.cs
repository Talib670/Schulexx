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
    class Fees_payments
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

        private string _term;
        public string term
        {
            get
            {
                return _term;
            }
            set
            {
                _term = value;
            }
        }

        private int _feestructureID;
        public int feestructureID
        {
            get
            {
                return _feestructureID;
            }
            set
            {
                _feestructureID = value;
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

        private DateTime _date_paid;
        public DateTime date_paid
        {
            get
            {
                return _date_paid;
            }
            set
            {
                _date_paid = value;
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

        private string _pay_mode;
        public string pay_mode
        {
            get
            {
                return _pay_mode;
            }
            set
            {
                _pay_mode = value;
            }
        }
    }
}
