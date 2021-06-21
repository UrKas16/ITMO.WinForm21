
namespace ITMO.WinForm.exp5.check
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.greenPeace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greenPeace
            // 
            this.greenPeace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.greenPeace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenPeace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenPeace.Location = new System.Drawing.Point(90, 143);
            this.greenPeace.Name = "greenPeace";
            this.greenPeace.Size = new System.Drawing.Size(117, 23);
            this.greenPeace.TabIndex = 0;
            this.greenPeace.Text = "GREENPEACE";
            this.greenPeace.UseVisualStyleBackColor = true;
            this.greenPeace.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.greenPeace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button greenPeace;
    }
}