using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulexx.Code
{
    class Alevel_agg_settings
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

         private decimal _minAv_agg;
         public decimal minAv_agg
         {
             get
             {
                 return _minAv_agg;
             }
             set
             {
                 _minAv_agg = value;
             }
         }

         private decimal _maxAv_agg;
         public decimal maxAv_agg
         {
             get
             {
                 return _maxAv_agg;
             }
             set
             {
                 _maxAv_agg = value;
             }
         }

         private string _grade;
         public string grade
         {
             get
             {
                 return _grade;
             }
             set
             {
                 _grade = value;
             }
         }

         private int _points;
         public int points
         {
             get
             {
                 return _points;
             }
             set
             {
                 _points = value;
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
