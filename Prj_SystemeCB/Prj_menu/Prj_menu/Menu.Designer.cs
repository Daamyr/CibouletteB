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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.logo_CB1 = new Prj_lib_graphique.Logo_CB();
            this.txt_CB1 = new Prj_lib_graphique.Txt_CB();
            this.btn_function1 = new Prj_lib_graphique.btn_function();
            this.btn_function2 = new Prj_lib_graphique.btn_function();
            this.btn_function3 = new Prj_lib_graphique.btn_function();
            this.btn_function4 = new Prj_lib_graphique.btn_function();
            this.btn_function5 = new Prj_lib_graphique.btn_function();
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_CB1
            // 
            this.logo_CB1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_CB1.BackgroundImage")));
            this.logo_CB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo_CB1.Location = new System.Drawing.Point(26, 125);
            this.logo_CB1.Name = "logo_CB1";
            this.logo_CB1.Size = new System.Drawing.Size(328, 302);
            this.logo_CB1.TabIndex = 0;
            this.logo_CB1.TabStop = false;
            // 
            // txt_CB1
            // 
            this.txt_CB1.AutoSize = true;
            this.txt_CB1.BackColor = System.Drawing.Color.Transparent;
            this.txt_CB1.Font = new System.Drawing.Font("Californian FB", 48F, System.Drawing.FontStyle.Italic);
            this.txt_CB1.ForeColor = System.Drawing.Color.Black;
            this.txt_CB1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_CB1.Location = new System.Drawing.Point(191, 9);
            this.txt_CB1.Name = "txt_CB1";
            this.txt_CB1.Size = new System.Drawing.Size(497, 74);
            this.txt_CB1.TabIndex = 7;
            this.txt_CB1.Text = "Ciboulette Balistique";
            // 
            // btn_function1
            // 
            this.btn_function1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_function1.Font = new System.Drawing.Font("Californian FB", 15.75F);
            this.btn_function1.Location = new System.Drawing.Point(537, 253);
            this.btn_function1.Name = "btn_function1";
            this.btn_function1.Size = new System.Drawing.Size(126, 48);
            this.btn_function1.TabIndex = 8;
            this.btn_function1.Text = "Transaction";
            this.btn_function1.UseVisualStyleBackColor = true;
            this.btn_function1.Click += new System.EventHandler(this.onNonImplemented);
            // 
            // btn_function2
            // 
            this.btn_function2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_function2.Font = new System.Drawing.Font("Californian FB", 15.75F);
            this.btn_function2.Location = new System.Drawing.Point(678, 125);
            this.btn_function2.Name = "btn_function2";
            this.btn_function2.Size = new System.Drawing.Size(126, 48);
            this.btn_function2.TabIndex = 9;
            this.btn_function2.Text = "Reservation";
            this.btn_function2.UseVisualStyleBackColor = true;
            this.btn_function2.Click += new System.EventHandler(this.onNonImplemented);
            // 
            // btn_function3
            // 
            this.btn_function3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_function3.Font = new System.Drawing.Font("Californian FB", 15.75F);
            this.btn_function3.Location = new System.Drawing.Point(401, 125);
            this.btn_function3.Name = "btn_function3";
            this.btn_function3.Size = new System.Drawing.Size(126, 48);
            this.btn_function3.TabIndex = 10;
            this.btn_function3.Text = "Chambre";
            this.btn_function3.UseVisualStyleBackColor = true;
            this.btn_function3.Click += new System.EventHandler(this.onNonImplemented);
            // 
            // btn_function4
            // 
            this.btn_function4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_function4.Font = new System.Drawing.Font("Californian FB", 15.75F);
            this.btn_function4.Location = new System.Drawing.Point(678, 379);
            this.btn_function4.Name = "btn_function4";
            this.btn_function4.Size = new System.Drawing.Size(126, 48);
            this.btn_function4.TabIndex = 11;
            this.btn_function4.Text = "Arrivée";
            this.btn_function4.UseVisualStyleBackColor = true;
            this.btn_function4.Click += new System.EventHandler(this.onNonImplemented);
            // 
            // btn_function5
            // 
            this.btn_function5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_function5.Font = new System.Drawing.Font("Californian FB", 15.75F);
            this.btn_function5.Location = new System.Drawing.Point(401, 379);
            this.btn_function5.Name = "btn_function5";
            this.btn_function5.Size = new System.Drawing.Size(126, 48);
            this.btn_function5.TabIndex = 12;
            this.btn_function5.Text = "Départ";
            this.btn_function5.UseVisualStyleBackColor = true;
            this.btn_function5.Click += new System.EventHandler(this.onNonImplemented);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prj_menu.Properties.Resources.FMenu1;
            this.ClientSize = new System.Drawing.Size(848, 519);
            this.Controls.Add(this.btn_function5);
            this.Controls.Add(this.btn_function4);
            this.Controls.Add(this.btn_function3);
            this.Controls.Add(this.btn_function2);
            this.Controls.Add(this.btn_function1);
            this.Controls.Add(this.txt_CB1);
            this.Controls.Add(this.logo_CB1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Prj_lib_graphique.Logo_CB logo_CB1;
        private Prj_lib_graphique.Txt_CB txt_CB1;
        private Prj_lib_graphique.btn_function btn_function1;
        private Prj_lib_graphique.btn_function btn_function2;
        private Prj_lib_graphique.btn_function btn_function3;
        private Prj_lib_graphique.btn_function btn_function4;
        private Prj_lib_graphique.btn_function btn_function5;
    }
}