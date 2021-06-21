using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinForm.exp5.check
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { 
                new Point(0, 150), 
                new Point(150, this.Height), 
                new Point(this.Width, 150),
                new Point(150, 0)});
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void greenPeace_TextChanged(object sender, EventArgs e)
        {
            //System.Drawing.Drawing2D.GraphicsPath myPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            //myPath2.AddPolygon(new Point[] {
            //    new Point(0, 150),
            //    new Point(150, this.Height),
            //    new Point(this.Width, 150),
            //    new Point(150, 0)});
            //Region myRegion2 = new Region(myPath2);
            //this.Region = myRegion2;

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
