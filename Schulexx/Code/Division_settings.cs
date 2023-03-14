using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Division_settings
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

        private int _min_agg;
        public int min_agg
        {
            get
            {
                return _min_agg;
            }
            set
            {
                _min_agg = value;
            }
        }

        private int _max_agg;
        public int max_agg
        {
            get
            {
                return _max_agg;
            }
            set
            {
                _max_agg = value;
            }
        }

        private string _Div_label;
        public string Div_label
        {
            get
            {
                return _Div_label;
            }
            set
            {
                _Div_label = value;
            }
        }

        private string _Div_short;
        public string Div_short
        {
            get
            {
                return _Div_short;
            }
            set
            {
                _Div_short = value;
            }
        }
    }
}
