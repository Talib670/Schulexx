using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Term_ht_commentsolevel
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
       
        private int _term_rankings_id;
        public int term_rankings_id
        {
            get
            {
                return _term_rankings_id;
            }
            set
            {
                _term_rankings_id = value;
            }
        }

        private string _conduct;
        public string conduct
        {
            get
            {
                return _conduct;
            }
            set
            {
                _conduct = value;
            }
        }

        private string _Comment;
        public string Comment
        {
            get
            {
                return _Comment;
            }
            set
            {
                _Comment = value;
            }
        }
    }
}
