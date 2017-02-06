namespace Prj_Transaction_Charles
{
    partial class Transaction
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_CB1
            // 
            this.txt_CB1.Click += new System.EventHandler(this.txt_CB1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(681, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1335, 608);
            this.Controls.Add(this.textBox1);
            this.Name = "Transaction";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btn_cancel1, 0);
            this.Controls.SetChildIndex(this.btn_previous1, 0);
            this.Controls.SetChildIndex(this.btn_edit1, 0);
            this.Controls.SetChildIndex(this.btn_next1, 0);
            this.Controls.SetChildIndex(this.btn_remove1, 0);
            this.Controls.SetChildIndex(this.btn_save1, 0);
            this.Controls.SetChildIndex(this.txt_CB1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
    }
}
