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
            this.lab_format = new System.Windows.Forms.Label();
            this.btn_fonction3 = new Prj_lib_graphique.btn_function();
            this.btn_fonction2 = new Prj_lib_graphique.btn_function();
            this.btn_fonction1 = new Prj_lib_graphique.btn_function();
            this.lab_format1 = new Prj_lib_graphique.lab_format();
            this.lab_format2 = new Prj_lib_graphique.lab_format();
            this.SuspendLayout();
            // 
            // lab_format
            // 
            this.lab_format.AutoSize = true;
            this.lab_format.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_format.Location = new System.Drawing.Point(110, 123);
            this.lab_format.Name = "lab_format";
            this.lab_format.Size = new System.Drawing.Size(71, 18);
            this.lab_format.TabIndex = 2;
            this.lab_format.Text = "lab_format";
            // 
            // btn_fonction3
            // 
            this.btn_fonction3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fonction3.Font = new System.Drawing.Font("Californian FB", 15.75F);
            this.btn_fonction3.Location = new System.Drawing.Point(312, 65);
            this.btn_fonction3.Name = "btn_fonction3";
            this.btn_fonction3.Size = new System.Drawing.Size(126, 48);
            this.btn_fonction3.TabIndex = 3;
            this.btn_fonction3.Text = "btn_fonction3";
            this.btn_fonction3.UseVisualStyleBackColor = true;
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
            // lab_format1
            // 
            this.lab_format1.AutoSize = true;
            this.lab_format1.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_format1.Location = new System.Drawing.Point(233, 200);
            this.lab_format1.Name = "lab_format1";
            this.lab_format1.Size = new System.Drawing.Size(76, 18);
            this.lab_format1.TabIndex = 4;
            this.lab_format1.Text = "lab_format1";
            // 
            // lab_format2
            // 
            this.lab_format2.AutoSize = true;
            this.lab_format2.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_format2.Location = new System.Drawing.Point(101, 65);
            this.lab_format2.Name = "lab_format2";
            this.lab_format2.Size = new System.Drawing.Size(79, 18);
            this.lab_format2.TabIndex = 5;
            this.lab_format2.Text = "lab_format2";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 519);
            this.Controls.Add(this.lab_format2);
            this.Controls.Add(this.lab_format1);
            this.Controls.Add(this.btn_fonction3);
            this.Controls.Add(this.lab_format);
            this.Controls.Add(this.btn_fonction2);
            this.Controls.Add(this.btn_fonction1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Prj_lib_graphique.btn_function btn_fonction1;
        private Prj_lib_graphique.btn_function btn_fonction2;
        private System.Windows.Forms.Label lab_format;
        private Prj_lib_graphique.btn_function btn_fonction3;
        private Prj_lib_graphique.lab_format lab_format1;
        private Prj_lib_graphique.lab_format lab_format2;
    }
}