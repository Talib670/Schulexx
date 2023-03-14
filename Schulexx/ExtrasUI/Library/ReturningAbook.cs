using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Code;
using Schulexx.Model;
using Schulexx.Data;

namespace Schulexx.LibraryUI
{
    public partial class ReturningAbook : UserControl
    {
        public ReturningAbook()
        {
            InitializeComponent();
        }

        Books_returned LocalReturn_book = new Books_returned();
        Books_returnedDataAdapter Process_ReturnBook = new Books_returnedDataAdapter();
        int get_id = 0;
        int bk_id = 0;

        Book_copies Local_bookCopy = new Book_copies();
        Book_copiesDataAdapter Process_BookCopy = new Book_copiesDataAdapter();
        public void insert_update()
        {
            LocalReturn_book.id = get_id;
            LocalReturn_book.bookCopy_id = bk_id;
            LocalReturn_book.date_returned = dateTimePicker1.Value;
            if (get_id == 0)
            {
                Process_ReturnBook.Insert(LocalReturn_book);
                Local_bookCopy.availability_status = "Available";
                Local_bookCopy.id = LocalReturn_book.bookCopy_id;
                Process_BookCopy.Update(Local_bookCopy);
                Load_List();
                Load_List_2();
            }
        }

        List<Books_takenbystaff> Stf_hiredBooks = new List<Books_takenbystaff>();
        Books_takenbystaffDataAdapter Process_IssuedBook = new Books_takenbystaffDataAdapter();

        Books_takenbystudsDataAdapter Process_StudBookHire = new Books_takenbystudsDataAdapter();
        List<Books_takenbystuds> Std_hiredBooks = new List<Books_takenbystuds>();
        public void Load_List()
        {
            if (personnelCbx.Text == "Student")
            {
                listView1.Items.Clear();
                Std_hiredBooks = Process_StudBookHire.GetBooks_takenbystudsList("");


                foreach (Books_takenbystuds c in Std_hiredBooks)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("book_copies", "book_number", "where id='" + c.bookCopy_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("books", "bookName", "where id='" + new Connectoperations().singleval("book_copies", "Mainbook_id", "where id='" + c.bookCopy_id + "'") + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("books", "Author", "where id='" + new Connectoperations().singleval("book_copies", "Mainbook_id", "where id='" + c.bookCopy_id + "'") + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("books", "Publisher", "where id='" + new Connectoperations().singleval("book_copies", "Mainbook_id", "where id='" + c.bookCopy_id + "'") + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                    pp.SubItems.Add(c.date_hired.ToShortDateString());
                    pp.SubItems.Add(c.date_of_return.ToShortDateString());
                    listView1.Items.Add(pp);
                }
            }
            if (personnelCbx.Text == "Staff")
            {
                listView1.Items.Clear();
                Stf_hiredBooks = Process_IssuedBook.GetBooks_takenbystaffList("");


                foreach (Books_takenbystaff c in Stf_hiredBooks)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("book_copies", "book_number", "where id='" + c.bookCopy_id + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("books", "bookName", "where id='" + new Connectoperations().singleval("book_copies", "Mainbook_id", "where id='" + c.bookCopy_id + "'") + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("books", "Author", "where id='" + new Connectoperations().singleval("book_copies", "Mainbook_id", "where id='" + c.bookCopy_id + "'") + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("books", "Publisher", "where id='" + new Connectoperations().singleval("book_copies", "Mainbook_id", "where id='" + c.bookCopy_id + "'") + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("staff", "concat(fname,' ',lname)", "where id='" + c.staff_id + "'"));
                    pp.SubItems.Add(c.date_issued.ToShortDateString());
                    pp.SubItems.Add(c.date_due_return.ToShortDateString());
                    listView1.Items.Add(pp);
                }
            }
        }

        public void Load_List_2()
        {

        }

        private void ReturningAbook_Load(object sender, EventArgs e)
        {
            RetunBookBtn.Visible = false;
            groupBox4.Visible = false;
        }

        private void personnelCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_List();
        }
    }
}
