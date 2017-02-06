namespace Prj_menu
{
    partial class Menu
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
            this.btn_fonction1 = new Prj_lib_graphique.btn_fonction();
            this.btn_fonction2 = new Prj_lib_graphique.btn_fonction();
            this.SuspendLayout();
            // 
            // btn_fonction1
            // 
            this.btn_fonction1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fonction1.Font = new System.Drawing.Font("Californian FB", 15.75F);
            this.btn_fonction1.Location = new System.Drawing.Point(55, 274);
            this.btn_fonction1.Name = "btn_fonction1";
            this.btn_fonction1.Size = new System.Drawing.Size(185, 58);
            this.btn_fonction1.TabIndex = 0;
            this.btn_fonction1.Text = "btn_fonction1";
            this.btn_fonction1.UseVisualStyleBackColor = true;
            // 
            // btn_fonction2
            // 
            this.btn_fonction2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fonction2.Font = new System.Drawing.Font("Californian FB", 15.75F);
            this.btn_fonction2.Location = new System.Drawing.Point(450, 274);
            this.btn_fonction2.Name = "btn_fonction2";
            this.btn_fonction2.Size = new System.Drawing.Size(203, 58);
            this.btn_fonction2.TabIndex = 1;
            this.btn_fonction2.Text = "btn_fonction2";
            this.btn_fonction2.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 519);
            this.Controls.Add(this.btn_fonction2);
            this.Controls.Add(this.btn_fonction1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Prj_lib_graphique.btn_fonction btn_fonction1;
        private Prj_lib_graphique.btn_fonction btn_fonction2;
    }
}