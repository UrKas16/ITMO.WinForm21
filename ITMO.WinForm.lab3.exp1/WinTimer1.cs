using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinForm.lab3.exp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stoptime_CheckedChanged(object sender, EventArgs e)
        {
            if (stoptime.Checked == true)
            {
                userControlTimer1.TimeEnabled = false;
                
            }
            else
            {
                userControlTimer1.TimeEnabled = true;
            }
        }
    }
}
