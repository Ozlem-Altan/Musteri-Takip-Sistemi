using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generics_form
{
    public partial class Form4 : Form
    {
        public List<string> musteriler = new List<string>();
        public Form4(List<string>must1)
        {
            InitializeComponent();
            this.musteriler = must1;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            int y = 0;
            for(int i = 0; i < musteriler.Count() / 3; i++)
            { 
                string ad, soyad,numara;
                ad = musteriler[i + y];
                soyad = musteriler[i + y + 1];
                numara = musteriler[i + y + 2];
                y = y + 2;
                string[] satir = { ad, soyad, numara };
                ListViewItem item = new ListViewItem(satir);
                listView1.Items.Add(item);
            }
        }
    }
}
