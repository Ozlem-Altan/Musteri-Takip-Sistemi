﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public List<string> musteriler1 = new List<string>();
        private void müşteriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(musteriler1);
            form3.MdiParent = this;
            form3.Show();
        }

        private void müşteriListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(musteriler1);
            form4.MdiParent = this;
            form4.Show();
        }
    }
}
