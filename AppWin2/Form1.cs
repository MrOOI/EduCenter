﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppWin2.NewFolder;


namespace AppWin2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Siz O'qituvchilar bo'limiga kirdingiz!");
            Teachers teachers = new Teachers();
            this.Hide();
            teachers.Show();     
        }
    }
}
