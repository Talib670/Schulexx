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
    public partial class IssueBookOutStud : UserControl
    {
        public IssueBookOutStud()
        {
            InitializeComponent();
        }
        Books_takenbystuds Local_StudBookHire = new Books_takenbystuds();
        Books_takenbystudsDataAdapter Process_StudBookHire = new Books_takenbystudsDataAdapter();
        int get_id = 0;

        Book_copies Local_bookCopy = new Book_copies();
        Book_copiesDataAdapter Process_BookCopy = new Book_copiesDataAdapter();

        public void insert_update()
        {
            string[] mm = StudCbx.Text.Split(' ');
            Local_StudBookHire.id = get_id;
            Local_StudBookHire.student_id = int.Parse(new Connectoperations().singleval("students", "student_id	", "where fname='" + mm[0] + "' and lname='" + mm[1] + "'"));
            Local_StudBookHire.bookCopy_id = int.Parse(new Connectoperations().singleval("book_copies", "id", "where book_number='" + Book_copyCbx.Text + "'"));
            Local_StudBookHire.date_hired = dateTimePicker1.Value;
            Local_StudBookHire.date_of_return = dateTimePicker3.Value;
            if(get_id==0){
                Process_StudBookHire.Insert(Local_StudBookHire);
                Local_bookCopy.availability_status = "Out";
                Local_bookCopy.id = Local_StudBookHire.bookCopy_id;
                Process_BookCopies.Update(Local_bookCopy);
                clear();
                Load_List();
            }
            else
            {
                Process_StudBookHire.Update(Local_StudBookHire);
                clear();
                Load_List();
            }
        }
        public void clear()
        {
            get_id = 0;
            BookIssueBtn.Text = "Issue Book";
            Level_cbx.SelectedIndex = -1;
            Class_cbx.SelectedIndex = -1;
            StudCbx.SelectedIndex = -1;
            Book_subCbx.SelectedIndex = -1;
            BookTitleCbx.SelectedIndex = -1;
            Book_copyCbx.SelectedIndex = -1;
        }

        List<Books_takenbystuds> St_hiredBooks = new List<Books_takenbystuds>();
        public void Load_List()
        {
            try
            {
                listView4.Items.Clear();
                St_hiredBooks = Process_StudBookHire.GetBooks_takenbystudsList("");


                foreach (Books_takenbystuds c in St_hiredBooks)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(new Connectoperations().singleval("book_copies", "book_number", "where id='"+c.bookCopy_id+"'"));
                    pp.SubItems.Add(new Connectoperations().singleval("books", "bookName", "where id='" + new Connectoperations().singleval("book_copies", "Mainbook_id", "where id='" + c.bookCopy_id + "'") + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("books", "Author", "where id='" + new Connectoperations().singleval("book_copies", "Mainbook_id", "where id='" + c.bookCopy_id + "'") + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("books", "Publisher", "where id='" + new Connectoperations().singleval("book_copies", "Mainbook_id", "where id='" + c.bookCopy_id + "'") + "'"));
                    pp.SubItems.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                    pp.SubItems.Add(c.date_hired.ToShortDateString());
                    pp.SubItems.Add(c.date_of_return.ToShortDateString());
                    listView4.Items.Add(pp);
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
                Level_cbx.Items.Clear();
                load_levels = process_levels.GetLevelsList("");

                foreach (Levels ee in load_levels)
                {

                    Level_cbx.Items.Add(ee.name);

                }
            }
            catch { }

        }
        ClassesDataAdapter process_class = new ClassesDataAdapter();
        List<Classes> load_classes = new List<Classes>();
        public void load_class()
        {

            try
            {
                Class_cbx.Items.Clear();
                load_classes = process_class.GetClassesList("where level_id=" + new Connectoperations().singleval("levels", "id", "where name= '"+Level_cbx.Text+"'"));

                foreach (Classes ee in load_classes)
                {

                    Class_cbx.Items.Add(ee.cname);

                }
            }
            catch { }

        }

        StudentsDataAdapter Process_student = new StudentsDataAdapter();
        ClassEnrollmentsDataAdapter process_enrol = new ClassEnrollmentsDataAdapter();
        List<Class_enrollments> load_student = new List<Class_enrollments>();

        public void Load_Students()
        {
            try
            {
                StudCbx.Items.Clear();
                load_student = process_enrol.GetClass_enrollmentsList("where class_id='" + new Connectoperations().singleval("classes", "class_id", "where cname='" + Class_cbx.Text + "'") + "'");


                foreach (Class_enrollments c in load_student)
                {
                    StudCbx.Items.Add(new Connectoperations().singleval("students", "concat(fname,' ',lname)", "where student_id='" + c.student_id + "'"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        BooksDataAdapter process_subjects = new BooksDataAdapter();
        List<Books> load_subjects = new List<Books>();

        public void load_subject()
        {

            try
            {
                 Book_subCbx.Items.Clear();

                 load_subjects = process_subjects.GetBooksList("where level_id='" + new Connectoperations().singleval("levels", "id", "where name='" + Level_cbx.Text + "'") + "'");

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

                St_BookCopies = Process_BookCopies.GetBook_copiesList("where Mainbook_id='" + new Connectoperations().singleval("books", "id", "where bookName='" + BookTitleCbx.Text + "'") + "' and availability_status='Available'");

                foreach (Book_copies ee in St_BookCopies)
                {

                    Book_copyCbx.Items.Add(ee.book_number);

                }
            }
            catch { }
        }

        private void IssueBookOutStud_Load(object sender, EventArgs e)
        {
            load_level();
            Load_List();
        }

        private void Level_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_class();
            load_subject();
        }
        private void Class_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Students();
        }

        private void Book_subCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_books();
        }

        private void BookTitleCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            book_copies_Load();
        }

        private void BookIssueBtn_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
