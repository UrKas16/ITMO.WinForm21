
namespace ITMO.WinForm.exp5.check
{
    partial class RubberForm
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
            this.rubberTexBox1 = new System.Windows.Forms.TextBox();
            this.sellerBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rubberTexBox1
            // 
            this.rubberTexBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rubberTexBox1.Location = new System.Drawing.Point(173, 26);
            this.rubberTexBox1.Name = "rubberTexBox1";
            this.rubberTexBox1.Size = new System.Drawing.Size(150, 20);
            this.rubberTexBox1.TabIndex = 0;
            // 
            // sellerBTN
            // 
            this.sellerBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sellerBTN.Location = new System.Drawing.Point(259, 121);
            this.sellerBTN.Name = "sellerBTN";
            this.sellerBTN.Size = new System.Drawing.Size(75, 23);
            this.sellerBTN.TabIndex = 2;
            this.sellerBTN.Text = "Отправить";
            this.sellerBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите данные";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(22, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 180);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // RubberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sellerBTN);
            this.Controls.Add(this.rubberTexBox1);
            this.Name = "RubberForm";
            this.Text = "RubberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rubberTexBox1;
        private System.Windows.Forms.Button sellerBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}