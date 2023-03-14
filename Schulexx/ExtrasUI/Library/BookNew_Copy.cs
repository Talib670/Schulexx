using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Model;
using Schulexx.Data;
using Schulexx.Code;
using Schulexx.Forms;

namespace Schulexx.LibraryUI
{
    public partial class BookNew_Copy : UserControl
    {
        public BookNew_Copy(int get_id)
        {
            InitializeComponent();
            get_id1 = get_id;
        }
        int get_id1;
        Book_copies Local_book = new Book_copies();
        Book_copiesDataAdapter Process_bookCopy = new Book_copiesDataAdapter();
        int get_id = 0;
        public string GenerateNumber()
        {
            Random random = new Random();
            string r = "MHCS-BK |" + DateTime.Today.ToString("yy") + " |";
            string y = DateTime.Today.ToString("yy");
            int i;
            for (i = 1; i < 4; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
        }
        public void insert_update()
        {
            Local_book.id = get_id;
            Local_book.Mainbook_id = get_id1;
            Local_book.book_number = new Connectoperations().validate_All_Data(GenerateNumber());
            Local_book.availability_status = "Available";
            if(get_id==0){
                Process_bookCopy.Insert(Local_book);
            }
            else
            {
                Process_bookCopy.Update(Local_book);
            }
        }

        private void BookNew_Copy_Load(object sender, EventArgs e)
        {
            CodeTxt.Text = GenerateNumber();
            label2.Text = "Adding new copy of" + ' ' + new Connectoperations().singleval("books", "bookName", "where id='"+get_id1 +"'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert_update();
            NewBook_Copy sf = (NewBook_Copy)Application.OpenForms["NewBook_Copy"];
            sf.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Parent.Controls.Remove(this);
             NewBook_Copy sf = (NewBook_Copy)Application.OpenForms["NewBook_Copy"];
            sf.Close();
        }
    }
}
