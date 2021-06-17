﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinForm
{
    public partial class nForm : Form
    {
        private bool nclose = false;
        public nForm()
        {
            InitializeComponent();
        }

        private void nForm_Load(object sender, EventArgs e)
        {

        }

      
        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }


        private void checkBoxClose_CheckedChanged(object sender, EventArgs e)
        {
            if (nclose) return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Close();
        }

        public new void Close()
        {
            nclose = true;
            base.Close();
        }

        
    }
}
