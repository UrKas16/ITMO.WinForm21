
namespace ITMO.WinForm.lab3.exp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControlTimer1 = new ITMO.WinForm.lab3.exp1.UserControlTimer();
            this.stoptime = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // userControlTimer1
            // 
            this.userControlTimer1.Location = new System.Drawing.Point(13, 13);
            this.userControlTimer1.Name = "userControlTimer1";
            this.userControlTimer1.Size = new System.Drawing.Size(77, 63);
            this.userControlTimer1.TabIndex = 0;
            this.userControlTimer1.TimeEnabled = true;
            // 
            // stoptime
            // 
            this.stoptime.AutoSize = true;
            this.stoptime.Location = new System.Drawing.Point(132, 13);
            this.stoptime.Name = "stoptime";
            this.stoptime.Size = new System.Drawing.Size(121, 17);
            this.stoptime.TabIndex = 1;
            this.stoptime.Text = "Остановить время";
            this.stoptime.UseVisualStyleBackColor = true;
            this.stoptime.CheckedChanged += new System.EventHandler(this.stoptime_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 229);
            this.Controls.Add(this.stoptime);
            this.Controls.Add(this.userControlTimer1);
            this.Name = "Form1";
            this.Text = "WinTimer1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlTimer userControlTimer1;
        private System.Windows.Forms.CheckBox stoptime;
    }
}

