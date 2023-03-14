using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulexx.Code;
using Schulexx.Data;
using Schulexx.Model;

namespace Schulexx.ConfigureUI
{
    public partial class ClassStreams : Form
    {
        public ClassStreams()
        {
            InitializeComponent();
        }

        Class_streams Local_Stream = new Class_streams();
        Class_streamsDataAdapters Process_Stream = new Class_streamsDataAdapters();
        int get_id = 0;

        public void insert_update()
        {
            try {
                Local_Stream.id = get_id;
                Local_Stream.stream_label = St_nameTXT.Text;
                Local_Stream.stream_desc = StDescrTxt.Text;

                if (get_id == 0)
                {
                    Process_Stream.Insert(Local_Stream);
                    clear();
                    Load_List();
                }
                else
                {
                    Process_Stream.Update(Local_Stream);
                    clear();
                    Load_List();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred:" + e.Message);
                
            }
           
        }


        private void ClassStreams_Load(object sender, EventArgs e)
        {
            Load_List();
        }

        public void clear()
        {
            get_id = 0;
            St_nameTXT.Clear();
            StDescrTxt.Clear();

        }

        List<Class_streams> Load_class_streams = new List<Class_streams>();

        public void Load_List()
        {
            try
            {
                listView1.Items.Clear();
                Load_class_streams = Process_Stream.GetClass_streamsList("");

                foreach (Class_streams c in Load_class_streams)
                {
                    ListViewItem pp = new ListViewItem();
                    pp.Text = c.id.ToString();
                    pp.SubItems.Add(c.stream_label.ToString());
                    pp.SubItems.Add(c.stream_desc.ToString());

                    listView1.Items.Add(pp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            insert_update();
            clear();
        }

        private void Class_Cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            get_id = int.Parse(e.Item.SubItems[0].Text);
            St_nameTXT.Text = e.Item.SubItems[1].Text;
            StDescrTxt.Text = e.Item.SubItems[2].Text;
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
