﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemNet
{
    public partial class ComTamSuon : Form
    {
        public ComTamSuon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Close();
        }
    }
}
