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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] veri = new string[2, 3];
        int i, j ;
        private void button1_Click(object sender, EventArgs e)
        {           

            string k_ad, k_sifre,ad_giris,sifre_giris;
            k_ad = "admin";
            k_sifre = "1234";
            ad_giris = textBox1.Text;
            sifre_giris = textBox2.Text;
          
            veri[1,1] = ad_giris;

            veri[1,2] = sifre_giris;
            
            if(k_ad==veri[1,1] && k_sifre == veri[1, 2])
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.WindowState = FormWindowState.Maximized;
                form2.Show();
            }
            else
            { 
                MessageBox.Show("Hatalı Giriş");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Select();

            }
        }
    }
}
