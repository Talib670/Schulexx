using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Schulexx.Code;
using Schulexx.Model;
using MySql.Data.MySqlClient;

namespace Schulexx.Data
{
    class Olevel_rankingsDataAdapter
    {
        public bool Insert(string attributes, string values)
        {
            if (new Connectoperations().insert("olevel_rankings", attributes, values) > 0)
            {
                MessageBox.Show("captured!");
                return true;
            }
            else
            {
                MessageBox.Show("Failed!");
                return false;
            }
        }
        public bool Update(string attributes, string values, string where)
        {
            if (new Connectoperations().update("olevel_rankings", attributes, values, where) > 0)
            {
                MessageBox.Show("updated!");
                return true;
            }
            else
            {
                MessageBox.Show("Failed!");
                return false;
            }
        }
        public bool Insert(Olevel_rankings MyOlevel_rankings)
        {
            if (Insert("id,student_id,class_id,aggregates,division_id,Total_marks,Average_mark,Range,class_total,position", "" + MyOlevel_rankings.id + ",'" + MyOlevel_rankings.student_id + "','" + MyOlevel_rankings.class_id + "','" + MyOlevel_rankings.aggregates + "','" + MyOlevel_rankings.division_id + "','" + MyOlevel_rankings.Total_marks + "','" + MyOlevel_rankings.Average_mark + "','" + MyOlevel_rankings.Range + "','" + MyOlevel_rankings.class_total + "','" + MyOlevel_rankings.position + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Update(Olevel_rankings MyOlevel_rankings)
        {
            if (Update("id,student_id,class_id,aggregates,division_id,Total_marks,Average_mark,Range,class_total,position", "" + MyOlevel_rankings.id + ",'" + MyOlevel_rankings.student_id + "','" + MyOlevel_rankings.class_id + "','" + MyOlevel_rankings.aggregates + "','" + MyOlevel_rankings.division_id + "','" + MyOlevel_rankings.Total_marks + "','" + MyOlevel_rankings.Average_mark + "','" + MyOlevel_rankings.Range + "','" + MyOlevel_rankings.class_total + "','" + MyOlevel_rankings.position + "'", "Where id=" + MyOlevel_rankings.id +""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable selecttableolevel_rankings(string attributes, string where)
        {
            DataTable dt = new DataTable();
            dt = new Connectoperations().selectdatable("olevel_rankings", attributes, where);
            return dt;
        }
        public string selectsinglevalueolevel_rankings(string attribute, string where)
        {
            string str = "";
            str = new Connectoperations().singleval("olevel_rankings", attribute, where);
            return str;
        }
        public bool deleteolevel_rankings(string where)
        {
            if (new Connectoperations().delete("olevel_rankings", where) > 0)
            {
                MessageBox.Show("deleted!");
                return true;
            }
            else
            {
                MessageBox.Show("Failed!");
                return false;
            }
        }
        public List<Olevel_rankings> GetOlevel_rankingsList()
        {
            List<Olevel_rankings> mylistOfolevel_rankings = new List<Olevel_rankings>();
            DataTable dat = selecttableolevel_rankings("*", "");
            if (dat.Rows.Count == 0) { return null; }
            foreach (DataRow row in dat.Rows)
            {
                mylistOfolevel_rankings.Add(GetOlevel_rankings(row));
            }
            return mylistOfolevel_rankings;
        }
        public Olevel_rankings GetOlevel_rankings(string ID)
        {
            DataTable dat = selecttableolevel_rankings("*", "where id=" + ID);
            if (dat.Rows.Count != 0)
            {
                return GetOlevel_rankings(dat.Rows[0]);
            }
            else
            {
                return null;
            }
        }
        public List<Olevel_rankings> GetOlevel_rankingsList(string where)
        {
            List<Olevel_rankings> mylistOfolevel_rankings = new List<Olevel_rankings>();
            DataTable dat = selecttableolevel_rankings("*", where);
            foreach (DataRow row in dat.Rows)
            {
                mylistOfolevel_rankings.Add(GetOlevel_rankings(row));
            }
            return mylistOfolevel_rankings;
        }
        public Olevel_rankings GetOlevel_rankings(DataRow row)
        {
            Olevel_rankings mylist = new Olevel_rankings();
            mylist.id = Convert.ToInt32(row["id"].ToString());
            mylist.student_id = Convert.ToInt32(row["student_id"].ToString());
            mylist.class_id = Convert.ToInt32(row["class_id"].ToString());
            mylist.aggregates = Convert.ToInt32(row["aggregates"].ToString());
            mylist.division_id = Convert.ToInt32(row["division_id"].ToString());
            mylist.Total_marks = Convert.ToInt32(row["Total_marks"].ToString());
            mylist.Average_mark = Convert.ToInt32(row["Average_mark"].ToString());
            mylist.Range = Convert.ToInt32(row["Range"].ToString());
            mylist.class_total = Convert.ToInt32(row["class_total"].ToString());
            mylist.position = Convert.ToInt32(row["position"].ToString());
            return mylist;
        }
        public string getmysqldate(DateTimePicker dt)
        {
            dt.Format = DateTimePickerFormat.Short;
            return new Connectoperations().mysqldate(Convert.ToDateTime(dt.Value));
        }
        //Validation methods
        public bool validate_int(string val)
        {
            return Regex.IsMatch(val, @"[0-9]+");
        }
        public bool validate_floatpoints(string val)
        {
            return Regex.IsMatch(val, @"[0-9]+\.\[0-9]+");
        }
        public bool validate_date(string val)
        {
            // Return true if val is valid mysql date format.
            return true;
        }
        public bool validate_email(string val)
        {
            // Return true if val is in valid e-mail format.
            return Regex.IsMatch(val, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*([,;]\s*\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)*");
        }
    }
}
