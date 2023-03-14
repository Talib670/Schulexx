using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Forms;
using Schulexx.Code;
using Schulexx.Model;
using Schulexx.Data;

namespace Schulexx.LibraryUI
{
    public partial class NewBook : UserControl
    {
        public NewBook()
        {
            InitializeComponent();
        }
        Books Local_book = new Books();
        BooksDataAdapter Process_books = new BooksDataAdapter();
        int get_id = 0;
        public void insert_update()
        {
            Local_book.id = get_id;
            Local_book.bookName = new Connectoperations().validate_All_Data(BookNameTbx.Text);
            Local_book.Author = new Connectoperations().validate_All_Data(AuthorTbx.Text);
            Local_book.Publisher = new Connectoperations().validate_All_Data(PubTbx.Text);
            Local_book.level_id = int.Parse(new Connectoperations().singleval("levels", "id", "where name='" + LevelCbx.Text + "'"));
            Local_book.subject_id = int.Parse(new Connectoperations().singleval("subjects", "subject_id", "where sname='" + SubjectCbx .Text+ "'"));
            Local_book.Book_descritpion = new Connectoperations().validate_All_Data(BkDescrbx.Text);
            if (get_id == 0)
            {
                Process_books.Insert(Local_book);
                Load_List();
                clear();
            }
            else
            {
                Process_books.Update(Local_book);
                Load_List();
                clear();
            }
        }
        public void clear()
        {
            get_id = 0;
            Btn_save.Text = "Save";
            Btn_delete.Visible = false;
            SubjectCbx.SelectedIndex = -1;
            LevelCbx.SelectedIndex = -1;
            BookNameTbx.Clear();
            AuthorTbx.Clear();
            PubTbx.Clear();
            BkDescrbx.Clear();
        }
        SubjectsDataAdapter subj_process = new SubjectsDataAdapter();
        List<Subjects> subjectsLoad = new List<Subjects>();
        public void Load_subjects()
        {
            try
            {
                SubjectCbx.Items.Clear();
                subjectsLoad = subj_process.GetSubjectsList("");
                foreach (Subjects c in subjectsLoad)
                {
                    SubjectCbx.Items.Add(c.sname);

                }
            }
            catch { }

        }

        LevelsDataAdapter Level_process = new LevelsDataAdapter();
        List<Levels> LevelsLoad = new List<Levels>();
        public void Load_levels()
        {
            try
            {
                LevelCbx.Items.Clear();
                LevelsLoad = Level_process.GetLevelsList("");
                foreach (Levels c in LevelsLoad)
                {
                    LevelCbx.Items.Add(c.name);

                }
            }
            catch { }

        }

        List<Books> Load_books = new List<Books>();

        public void Load_List()
        {
            try
            {
                listView1.Items.Clear();
                Load_books = Process_books.GetBooksList("");
                foreach (Books c in Load_books)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(c.bookName);
                    pp.SubItems.Add(new Connectoperations().singleval("subjects", "sname", "where subject_id='"+c.subject_id+"'"));
                    pp.SubItems.Add(new Connectoperations().singleval("levels", "name", "where id='" + c.level_id + "'"));
                    pp.SubItems.Add(c.Author);
                    pp.SubItems.Add(c.Publisher);
                    pp.SubItems.Add(new Connectoperations().singleval("book_copies", "COUNT(id)", "where Mainbook_id='"+c.id+"'"));
                    pp.SubItems.Add(c.Book_descritpion);

                    listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            insert_update();
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            Btn_NewCopy.Visible = false;
            clear();
            Load_List();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret;
                ret = MessageBox.Show("Are you sure you want to Delete", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    Process_books.deletebooks("where id = '" + get_id + "'");
                    Load_List();
                    clear();
                }
                else
                {
                    return;
                }
            }
            catch { }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Btn_delete.Enabled = false;
            Btn_save.Text = "Update";
            Btn_NewCopy.Visible = true;
            get_id = int.Parse(e.Item.SubItems[0].Text);
            BookNameTbx.Text = e.Item.SubItems[1].Text;
            SubjectCbx.Text = e.Item.SubItems[2].Text;
            LevelCbx.Text = e.Item.SubItems[3].Text;
            AuthorTbx.Text = e.Item.SubItems[4].Text;
            PubTbx.Text = e.Item.SubItems[5].Text;
            BkDescrbx.Text = e.Item.SubItems[7].Text;
        }

        private void NewBook_Load(object sender, EventArgs e)
        {
            Btn_NewCopy.Visible = false;
            Load_List();
            Load_subjects();
            Load_levels();
        }

        private void Btn_NewCopy_Click(object sender, EventArgs e)
        {
            new NewBook_Copy(get_id).ShowDialog();
        }
    }
}
