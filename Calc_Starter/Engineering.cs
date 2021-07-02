using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public class Engineering: CalcUI
    {
        private System.Windows.Forms.Button expon;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button squar;
        private System.Windows.Forms.Button cuberoot;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button revnum;

        public void createBTNexpon()
        {
            expon = new Button();
            expon.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            expon.ForeColor = System.Drawing.Color.Blue;
            expon.Location = new System.Drawing.Point(7, 270);
            expon.Name = "Exponentiation";
            expon.Size = new System.Drawing.Size(40, 40);
            expon.TabIndex = 5;
            expon.TabStop = false;
            expon.Text = "x^y";
            expon.Click += new System.EventHandler(this.Expon_Click);
            this.toolTip1.SetToolTip(expon, "Возведение в степень");
            this.Controls.Add(expon);
        }

        private void createBTNsquar()
        {
            squar = new Button();
            squar.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            squar.ForeColor = System.Drawing.Color.Blue;
            squar.Location = new System.Drawing.Point(54, 270);
            squar.Name = "Squaring";
            squar.Size = new System.Drawing.Size(40, 40);
            squar.TabIndex = 5;
            squar.TabStop = false;
            squar.Text = "x²";
            squar.Click += new System.EventHandler(this.Squar_Click);
            this.toolTip1.SetToolTip(squar, "Квадрат числа");
            this.Controls.Add(squar);
        }


        private void createBTNsqrt()
        {
            sqrt = new Button();
            sqrt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            sqrt.ForeColor = System.Drawing.Color.Blue;
            sqrt.Location = new System.Drawing.Point(101, 270);
            sqrt.Name = "Square root";
            sqrt.Size = new System.Drawing.Size(40, 40);
            sqrt.TabIndex = 5;
            sqrt.TabStop = false;
            sqrt.Text = "√";
            sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            this.toolTip1.SetToolTip(sqrt, "Извлечение квадратного корня");
            this.Controls.Add(sqrt);
        }

        private void createBTNcuberoot()
        {
            cuberoot = new Button();
            cuberoot.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            cuberoot.ForeColor = System.Drawing.Color.Blue;
            cuberoot.Location = new System.Drawing.Point(101, 317);
            cuberoot.Name = "Сube root";
            cuberoot.Size = new System.Drawing.Size(40, 40);
            cuberoot.TabIndex = 5;
            cuberoot.TabStop = false;
            cuberoot.Text = "∛";
            cuberoot.Click += new System.EventHandler(this.Cuberoot_Click);
            this.toolTip1.SetToolTip(cuberoot, "Извлечение кубического корня");
            this.Controls.Add(cuberoot);
        }
    }
}
