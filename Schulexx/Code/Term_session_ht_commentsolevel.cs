using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Term_session_ht_commentsolevel
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

        private int _term_session_rank_id;
        public int term_session_rank_id	
        {
            get
            {
                return _term_session_rank_id;
            }
            set
            {
                _term_session_rank_id = value;
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

        private string _comment;
        public string comment
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = value;
            }
        }
    }
}
