namespace Prj_Chambre_Janie
{
    partial class Chambre
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTypChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_Chambre = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Chambre = new Prj_Chambre_Janie.DataSet_Chambre();
            this.TA_Chambre = new Prj_Chambre_Janie.DataSet_ChambreTableAdapters.ChambreTableAdapter();
            this.Label_NoCham = new System.Windows.Forms.Label();
            this.Label_Memo = new System.Windows.Forms.Label();
            this.Label_Prix = new System.Windows.Forms.Label();
            this.Label_Etat = new System.Windows.Forms.Label();
            this.Label_Etage = new System.Windows.Forms.Label();
            this.TextBox_NoCham = new System.Windows.Forms.TextBox();
            this.TextBox_Etage = new System.Windows.Forms.TextBox();
            this.TextBox_Etat = new System.Windows.Forms.TextBox();
            this.TextBox_Prix = new System.Windows.Forms.TextBox();
            this.TextBox_Memo = new System.Windows.Forms.TextBox();
            this.Label_CodeType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel1
            // 
            this.btn_cancel1.Location = new System.Drawing.Point(724, 544);
            // 
            // btn_previous1
            // 
            this.btn_previous1.Location = new System.Drawing.Point(151, 547);
            // 
            // btn_edit1
            // 
            this.btn_edit1.Location = new System.Drawing.Point(578, 544);
            // 
            // btn_next1
            // 
            this.btn_next1.Location = new System.Drawing.Point(1128, 544);
            // 
            // btn_remove1
            // 
            this.btn_remove1.Location = new System.Drawing.Point(1256, 547);
            // 
            // btn_save1
            // 
            this.btn_save1.Location = new System.Drawing.Point(651, 544);
            // 
            // logo_CB1
            // 
            this.logo_CB1.BackColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Label_CodeType);
            this.panel1.Controls.Add(this.TextBox_Memo);
            this.panel1.Controls.Add(this.TextBox_Prix);
            this.panel1.Controls.Add(this.TextBox_Etat);
            this.panel1.Controls.Add(this.TextBox_Etage);
            this.panel1.Controls.Add(this.TextBox_NoCham);
            this.panel1.Controls.Add(this.Label_Etage);
            this.panel1.Controls.Add(this.Label_Etat);
            this.panel1.Controls.Add(this.Label_Prix);
            this.panel1.Controls.Add(this.Label_Memo);
            this.panel1.Controls.Add(this.Label_NoCham);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(91, 102);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noChamDataGridViewTextBoxColumn,
            this.etageDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.etatDataGridViewTextBoxColumn,
            this.memoDataGridViewTextBoxColumn,
            this.codLocDataGridViewTextBoxColumn,
            this.codTypChamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.BS_Chambre;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 286);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1152, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
            this.noChamDataGridViewTextBoxColumn.HeaderText = "NoCham";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            // 
            // etageDataGridViewTextBoxColumn
            // 
            this.etageDataGridViewTextBoxColumn.DataPropertyName = "Etage";
            this.etageDataGridViewTextBoxColumn.HeaderText = "Etage";
            this.etageDataGridViewTextBoxColumn.Name = "etageDataGridViewTextBoxColumn";
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            // 
            // etatDataGridViewTextBoxColumn
            // 
            this.etatDataGridViewTextBoxColumn.DataPropertyName = "Etat";
            this.etatDataGridViewTextBoxColumn.HeaderText = "Etat";
            this.etatDataGridViewTextBoxColumn.Name = "etatDataGridViewTextBoxColumn";
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "Memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "Memo";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            // 
            // codLocDataGridViewTextBoxColumn
            // 
            this.codLocDataGridViewTextBoxColumn.DataPropertyName = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.HeaderText = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.Name = "codLocDataGridViewTextBoxColumn";
            // 
            // codTypChamDataGridViewTextBoxColumn
            // 
            this.codTypChamDataGridViewTextBoxColumn.DataPropertyName = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.HeaderText = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.Name = "codTypChamDataGridViewTextBoxColumn";
            // 
            // BS_Chambre
            // 
            this.BS_Chambre.DataMember = "Chambre";
            this.BS_Chambre.DataSource = this.dataSet_Chambre;
            // 
            // dataSet_Chambre
            // 
            this.dataSet_Chambre.DataSetName = "DataSet_Chambre";
            this.dataSet_Chambre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TA_Chambre
            // 
            this.TA_Chambre.ClearBeforeFill = true;
            // 
            // Label_NoCham
            // 
            this.Label_NoCham.AutoSize = true;
            this.Label_NoCham.Location = new System.Drawing.Point(42, 32);
            this.Label_NoCham.Name = "Label_NoCham";
            this.Label_NoCham.Size = new System.Drawing.Size(109, 13);
            this.Label_NoCham.TabIndex = 1;
            this.Label_NoCham.Text = "Numéro de chambre :";
            // 
            // Label_Memo
            // 
            this.Label_Memo.AutoSize = true;
            this.Label_Memo.Location = new System.Drawing.Point(42, 149);
            this.Label_Memo.Name = "Label_Memo";
            this.Label_Memo.Size = new System.Drawing.Size(42, 13);
            this.Label_Memo.TabIndex = 2;
            this.Label_Memo.Text = "Mémo :\r\n";
            // 
            // Label_Prix
            // 
            this.Label_Prix.AutoSize = true;
            this.Label_Prix.Location = new System.Drawing.Point(42, 121);
            this.Label_Prix.Name = "Label_Prix";
            this.Label_Prix.Size = new System.Drawing.Size(30, 13);
            this.Label_Prix.TabIndex = 3;
            this.Label_Prix.Text = "Prix :\r\n";
            // 
            // Label_Etat
            // 
            this.Label_Etat.AutoSize = true;
            this.Label_Etat.Location = new System.Drawing.Point(42, 92);
            this.Label_Etat.Name = "Label_Etat";
            this.Label_Etat.Size = new System.Drawing.Size(32, 13);
            this.Label_Etat.TabIndex = 4;
            this.Label_Etat.Text = "État :\r\n";
            // 
            // Label_Etage
            // 
            this.Label_Etage.AutoSize = true;
            this.Label_Etage.Location = new System.Drawing.Point(42, 60);
            this.Label_Etage.Name = "Label_Etage";
            this.Label_Etage.Size = new System.Drawing.Size(41, 13);
            this.Label_Etage.TabIndex = 5;
            this.Label_Etage.Text = "Étage :\r\n";
            // 
            // TextBox_NoCham
            // 
            this.TextBox_NoCham.Location = new System.Drawing.Point(169, 25);
            this.TextBox_NoCham.Name = "TextBox_NoCham";
            this.TextBox_NoCham.Size = new System.Drawing.Size(100, 20);
            this.TextBox_NoCham.TabIndex = 6;
            // 
            // TextBox_Etage
            // 
            this.TextBox_Etage.Location = new System.Drawing.Point(169, 53);
            this.TextBox_Etage.Name = "TextBox_Etage";
            this.TextBox_Etage.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Etage.TabIndex = 7;
            // 
            // TextBox_Etat
            // 
            this.TextBox_Etat.Location = new System.Drawing.Point(169, 85);
            this.TextBox_Etat.Name = "TextBox_Etat";
            this.TextBox_Etat.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Etat.TabIndex = 8;
            // 
            // TextBox_Prix
            // 
            this.TextBox_Prix.Location = new System.Drawing.Point(169, 116);
            this.TextBox_Prix.Name = "TextBox_Prix";
            this.TextBox_Prix.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Prix.TabIndex = 9;
            // 
            // TextBox_Memo
            // 
            this.TextBox_Memo.Location = new System.Drawing.Point(169, 142);
            this.TextBox_Memo.Name = "TextBox_Memo";
            this.TextBox_Memo.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Memo.TabIndex = 10;
            // 
            // Label_CodeType
            // 
            this.Label_CodeType.AutoSize = true;
            this.Label_CodeType.Location = new System.Drawing.Point(560, 32);
            this.Label_CodeType.Name = "Label_CodeType";
            this.Label_CodeType.Size = new System.Drawing.Size(35, 13);
            this.Label_CodeType.TabIndex = 11;
            this.Label_CodeType.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(633, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(633, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(867, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(795, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(867, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 18;
            // 
            // Chambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1335, 608);
            this.Name = "Chambre";
            this.Load += new System.EventHandler(this.Chambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet_Chambre dataSet_Chambre;
        private System.Windows.Forms.BindingSource BS_Chambre;
        private DataSet_ChambreTableAdapters.ChambreTableAdapter TA_Chambre;
        protected System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTypChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TextBox_Memo;
        private System.Windows.Forms.TextBox TextBox_Prix;
        private System.Windows.Forms.TextBox TextBox_Etat;
        private System.Windows.Forms.TextBox TextBox_Etage;
        private System.Windows.Forms.TextBox TextBox_NoCham;
        private System.Windows.Forms.Label Label_Etage;
        private System.Windows.Forms.Label Label_Etat;
        private System.Windows.Forms.Label Label_Prix;
        private System.Windows.Forms.Label Label_Memo;
        private System.Windows.Forms.Label Label_NoCham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_CodeType;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
    }
}
