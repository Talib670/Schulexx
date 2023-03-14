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
using Schulexx.Data;
using Schulexx.Model;

namespace Schulexx.LibraryUI
{
    public partial class IssueBookOutStaff : UserControl
    {
        public IssueBookOutStaff()
        {
            InitializeComponent();
        }
        Books_takenbystaff Local__bookIssue = new Books_takenbystaff();
        Books_takenbystaffDataAdapter Process_IssuedBook = new Books_takenbystaffDataAdapter();
        int get_id;
        public void insert_update()
        {
            string[] mm = personnelCbx.Text.Split(' ');
            Local__bookIssue.id = get_id;
            Local__bookIssue.date_issued = dateTimePicker1.Value;
            Local__bookIssue.date_due_return = dateTimePicker3.Value;
            Local__bookIssue.staff_id = int.Parse(new Connectoperations().singleval("staff", "id", "where fname='"+mm[0]+"' and lname='"+mm[1]+"'"));
            Local__bookIssue.bookCopy_id = int.Parse(new Connectoperations().singleval("book_copies", "id", "where book_number='" + Book_copyCbx.Text + "'"));
            if (get_id == 0)
            {
                Process_IssuedBook.Insert(Local__bookIssue);
                clear();
                Load_List();
            }
            else
            {
                Process_IssuedBook.Update(Local__bookIssue);
                clear();
                Load_List();
            }
            
        }

        public void clear()
        {
            get_id = 0;
            BookIssueBtn.Text = "Issue Book";
            levelcbx.SelectedIndex = -1;
            personnelCbx.SelectedIndex = -1;
            Book_subCbx.SelectedIndex = -1;
            BookTitleCbx.SelectedIndex = -1;
            Book_copyCbx.SelectedIndex = -1;
        }

        List<Books_takenbystaff> Stf_hiredBooks = new List<Books_takenbystaff>();
        public void Load_List()
        {
            try
            {
                listView4.Items.Clear();
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
                    listView4.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        List<Staff> Load_teachers = new List<Staff>();
        StaffDataAdapter Process_teachers = new StaffDataAdapter();

        public void load_staff_list()
        {
            try
            {
                personnelCbx.Items.Clear();

                Load_teachers = Process_teachers.GetStaffList("where staff_type= 'Teaching Staff' ");

                foreach (Staff c in Load_teachers)
                {
                    personnelCbx.Items.Add(c.fname + " " + c.lname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        LevelsDataAdapter process_levels = new LevelsDataAdapter();
        List<Levels> load_levels = new List<Levels>();
        public void load_level()
        {

            try
            {
                levelcbx.Items.Clear();
                load_levels = process_levels.GetLevelsList("");

                foreach (Levels ee in load_levels)
                {

                    levelcbx.Items.Add(ee.name);

                }
            }
            catch { }

        }

        BooksDataAdapter process_subjects = new BooksDataAdapter();
        List<Books> load_subjects = new List<Books>();

        public void load_subject()
        {

            try
            {
                Book_subCbx.Items.Clear();

                load_subjects = process_subjects.GetBooksList("where level_id='" + new Connectoperations().singleval("levels", "id", "where name='" + levelcbx.Text + "'") + "'");

                foreach (Books ee in load_subjects)
                {

                    Book_subCbx.Items.Add(new Connectoperations().singleval("subjects", "sname", "where subject_id='" + ee.subject_id + "'"));

                }
            }
            catch { }

        }

        public void Load_books()
        {
            try
            {
                BookTitleCbx.Items.Clear();

                load_subjects = process_subjects.GetBooksList("where subject_id='" + new Connectoperations().singleval("subjects", "subject_id", "where sname='" + Book_subCbx.Text + "'") + "'");

                foreach (Books ee in load_subjects)
                {

                    BookTitleCbx.Items.Add(ee.bookName);

                }
            }
            catch { }
        }

        Book_copiesDataAdapter Process_BookCopies = new Book_copiesDataAdapter();
        List<Book_copies> St_BookCopies = new List<Book_copies>();
        public void book_copies_Load()
        {
            try
            {
                Book_copyCbx.Items.Clear();

                St_BookCopies = Process_BookCopies.GetBook_copiesList("where Mainbook_id='" + new Connectoperations().singleval("books", "id", "where bookName='" + BookTitleCbx.Text + "'") + "'");

                foreach (Book_copies ee in St_BookCopies)
                {

                    Book_copyCbx.Items.Add(ee.book_number);

                }
            }
            catch { }
        }
        private void IssueBookOutStaff_Load(object sender, EventArgs e)
        {
            groupBox14.Visible = false;
            load_staff_list();
            Load_List();
            load_level();
        }

        private void BookIssueBtn_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void levelcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_subject();
        }

        private void Book_subCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_books();
        }

        private void BookTitleCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            book_copies_Load();
        }

        
    }
}
