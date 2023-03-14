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
    class Supplies
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

        private int _supplier_id;
        public int supplier_id
        {
            get
            {
                return _supplier_id;
            }
            set
            {
                _supplier_id = value;
            }
        }

        private string _supply_category;
        public string supply_category	
        {
            get
            {
                return _supply_category;
            }
            set
            {
                _supply_category = value;
            }
        }

        private int _quantity;
        public int quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }

        private DateTime _date_of_supply;
        public DateTime date_of_supply
        {
            get
            {
                return _date_of_supply;
            }
            set
            {
                _date_of_supply = value;
            }
        }

        private string _Descr;
        public string Descr
        {
            get
            {
                return _Descr;
            }
            set
            {
                _Descr = value;
            }
        }
    }
}
