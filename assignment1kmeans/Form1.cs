﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1kmeans
{
    public partial class Form1 : Form
    {
        public String filepath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog filebrowser = new OpenFileDialog();
            filebrowser.ShowDialog();
            filepath = filebrowser.FileName;
            textBoxFilename.Text = filepath;
        }
    }
}