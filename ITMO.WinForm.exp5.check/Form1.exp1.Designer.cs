
namespace ITMO.WinForm.exp5.check
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
            this.ClsBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClsBut
            // 
            this.ClsBut.Location = new System.Drawing.Point(121, 104);
            this.ClsBut.Name = "ClsBut";
            this.ClsBut.Size = new System.Drawing.Size(111, 50);
            this.ClsBut.TabIndex = 0;
            this.ClsBut.Text = "Закрыть";
            this.ClsBut.UseVisualStyleBackColor = true;
            this.ClsBut.Click += new System.EventHandler(this.ClsBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.ClsBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackColor = System.Drawing.Color.Bisque;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClsBut;
    }
}

