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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_Chambre = new System.Windows.Forms.DataGridView();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_Ayant = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Chambre = new Prj_Chambre_Janie.DataSet_Chambre();
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
            this.Label_CodeLoc = new System.Windows.Forms.Label();
            this.TextBox_TypeChambre = new System.Windows.Forms.TextBox();
            this.TextBox_LocChambre = new System.Windows.Forms.TextBox();
            this.Label_Description = new System.Windows.Forms.Label();
            this.TextBox_DescChambre = new System.Windows.Forms.TextBox();
            this.Label_Description2 = new System.Windows.Forms.Label();
            this.TextBox_DescLocCham = new System.Windows.Forms.TextBox();
            this.BS_Localisation = new System.Windows.Forms.BindingSource(this.components);
            this.BS_TypeChambre = new System.Windows.Forms.BindingSource(this.components);
            this.fKAYANTCHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Chambre = new System.Windows.Forms.BindingSource(this.components);
            this.localisationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TA_Chambre = new Prj_Chambre_Janie.DataSet_ChambreTableAdapters.ChambreTableAdapter();
            this.TA_Localisation = new Prj_Chambre_Janie.DataSet_ChambreTableAdapters.LocalisationTableAdapter();
            this.TA_TypeChambre = new Prj_Chambre_Janie.DataSet_ChambreTableAdapters.TypeChamTableAdapter();
            this.TA_Ayant = new Prj_Chambre_Janie.DataSet_ChambreTableAdapters.AyantTableAdapter();
            this.TA_Commodite = new Prj_Chambre_Janie.DataSet_ChambreTableAdapters.CommoditeTableAdapter();
            this.BS_Commodite = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Chambre1 = new Prj_Chambre_Janie.DataSet_Chambre();
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Ayant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Localisation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TypeChambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAYANTCHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localisationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Commodite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(724, 544);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(16, 544);
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(1103, 544);
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(460, 544);
            // 
            // logo_CB
            // 
            this.logo_CB.BackColor = System.Drawing.Color.Transparent;
            // 
            // btn_add
            // 
            this.btn_add.Click += new System.EventHandler(this.btn_add1_Click);
            // 
            // btn_delete1
            // 
            this.btn_delete.Click += new System.EventHandler(this.btn_delete1_Click);
            // 
            // btn_edit1
            // 
            this.btn_edit.Location = new System.Drawing.Point(801, 14);
            this.btn_edit.Click += new System.EventHandler(this.btn_edit1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextBox_DescLocCham);
            this.panel1.Controls.Add(this.Label_Description2);
            this.panel1.Controls.Add(this.TextBox_DescChambre);
            this.panel1.Controls.Add(this.Label_Description);
            this.panel1.Controls.Add(this.TextBox_LocChambre);
            this.panel1.Controls.Add(this.TextBox_TypeChambre);
            this.panel1.Controls.Add(this.Label_CodeLoc);
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
            this.panel1.Controls.Add(this.DGV_Chambre);
            this.panel1.Location = new System.Drawing.Point(13, 102);
            // 
            // DGV_Chambre
            // 
            this.DGV_Chambre.AllowUserToAddRows = false;
            this.DGV_Chambre.AllowUserToDeleteRows = false;
            this.DGV_Chambre.AllowUserToOrderColumns = true;
            this.DGV_Chambre.AllowUserToResizeColumns = false;
            this.DGV_Chambre.AllowUserToResizeRows = false;
            this.DGV_Chambre.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Chambre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_Chambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Chambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noChamDataGridViewTextBoxColumn,
            this.codComDataGridViewTextBoxColumn,
            this.DescCom});
            this.DGV_Chambre.DataSource = this.BS_Ayant;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Chambre.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_Chambre.EnableHeadersVisualStyles = false;
            this.DGV_Chambre.Location = new System.Drawing.Point(3, 286);
            this.DGV_Chambre.Name = "DGV_Chambre";
            this.DGV_Chambre.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Chambre.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_Chambre.RowHeadersVisible = false;
            this.DGV_Chambre.Size = new System.Drawing.Size(1152, 150);
            this.DGV_Chambre.TabIndex = 0;
            // 
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
            this.noChamDataGridViewTextBoxColumn.HeaderText = "NoCham";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            this.noChamDataGridViewTextBoxColumn.ReadOnly = true;
            this.noChamDataGridViewTextBoxColumn.Width = 250;
            // 
            // codComDataGridViewTextBoxColumn
            // 
            this.codComDataGridViewTextBoxColumn.DataPropertyName = "CodCom";
            this.codComDataGridViewTextBoxColumn.HeaderText = "CodCom";
            this.codComDataGridViewTextBoxColumn.Name = "codComDataGridViewTextBoxColumn";
            this.codComDataGridViewTextBoxColumn.ReadOnly = true;
            this.codComDataGridViewTextBoxColumn.Width = 250;
            // 
            // DescCom
            // 
            this.DescCom.DataPropertyName = "DescCom";
            this.DescCom.HeaderText = "Description";
            this.DescCom.Name = "DescCom";
            this.DescCom.ReadOnly = true;
            this.DescCom.Width = 648;
            // 
            // BS_Ayant
            // 
            this.BS_Ayant.DataMember = "Ayant";
            this.BS_Ayant.DataSource = this.dataSet_Chambre;
            // 
            // dataSet_Chambre
            // 
            this.dataSet_Chambre.DataSetName = "DataSet_Chambre";
            this.dataSet_Chambre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.TextBox_NoCham.ReadOnly = true;
            this.TextBox_NoCham.Size = new System.Drawing.Size(100, 20);
            this.TextBox_NoCham.TabIndex = 6;
            this.TextBox_NoCham.DoubleClick += new System.EventHandler(this.TextBox_NoCham_DoubleClick);
            // 
            // TextBox_Etage
            // 
            this.TextBox_Etage.Location = new System.Drawing.Point(169, 53);
            this.TextBox_Etage.Name = "TextBox_Etage";
            this.TextBox_Etage.ReadOnly = true;
            this.TextBox_Etage.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Etage.TabIndex = 7;
            // 
            // TextBox_Etat
            // 
            this.TextBox_Etat.Location = new System.Drawing.Point(169, 85);
            this.TextBox_Etat.Name = "TextBox_Etat";
            this.TextBox_Etat.ReadOnly = true;
            this.TextBox_Etat.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Etat.TabIndex = 8;
            // 
            // TextBox_Prix
            // 
            this.TextBox_Prix.Location = new System.Drawing.Point(169, 116);
            this.TextBox_Prix.Name = "TextBox_Prix";
            this.TextBox_Prix.ReadOnly = true;
            this.TextBox_Prix.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Prix.TabIndex = 9;
            // 
            // TextBox_Memo
            // 
            this.TextBox_Memo.Location = new System.Drawing.Point(169, 142);
            this.TextBox_Memo.Name = "TextBox_Memo";
            this.TextBox_Memo.ReadOnly = true;
            this.TextBox_Memo.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Memo.TabIndex = 10;
            // 
            // Label_CodeType
            // 
            this.Label_CodeType.AutoSize = true;
            this.Label_CodeType.Location = new System.Drawing.Point(531, 28);
            this.Label_CodeType.Name = "Label_CodeType";
            this.Label_CodeType.Size = new System.Drawing.Size(96, 13);
            this.Label_CodeType.TabIndex = 11;
            this.Label_CodeType.Text = "Type de chambre :";
            // 
            // Label_CodeLoc
            // 
            this.Label_CodeLoc.AutoSize = true;
            this.Label_CodeLoc.Location = new System.Drawing.Point(494, 81);
            this.Label_CodeLoc.Name = "Label_CodeLoc";
            this.Label_CodeLoc.Size = new System.Drawing.Size(139, 13);
            this.Label_CodeLoc.TabIndex = 12;
            this.Label_CodeLoc.Text = "Localisation de le chambre :";
            // 
            // TextBox_TypeChambre
            // 
            this.TextBox_TypeChambre.Location = new System.Drawing.Point(633, 25);
            this.TextBox_TypeChambre.Name = "TextBox_TypeChambre";
            this.TextBox_TypeChambre.ReadOnly = true;
            this.TextBox_TypeChambre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_TypeChambre.TabIndex = 13;
            // 
            // TextBox_LocChambre
            // 
            this.TextBox_LocChambre.Location = new System.Drawing.Point(633, 78);
            this.TextBox_LocChambre.Name = "TextBox_LocChambre";
            this.TextBox_LocChambre.ReadOnly = true;
            this.TextBox_LocChambre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_LocChambre.TabIndex = 14;
            // 
            // Label_Description
            // 
            this.Label_Description.AutoSize = true;
            this.Label_Description.Location = new System.Drawing.Point(792, 25);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(66, 13);
            this.Label_Description.TabIndex = 15;
            this.Label_Description.Text = "Description :";
            // 
            // TextBox_DescChambre
            // 
            this.TextBox_DescChambre.Location = new System.Drawing.Point(867, 25);
            this.TextBox_DescChambre.Name = "TextBox_DescChambre";
            this.TextBox_DescChambre.ReadOnly = true;
            this.TextBox_DescChambre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_DescChambre.TabIndex = 16;
            // 
            // Label_Description2
            // 
            this.Label_Description2.AutoSize = true;
            this.Label_Description2.Location = new System.Drawing.Point(795, 78);
            this.Label_Description2.Name = "Label_Description2";
            this.Label_Description2.Size = new System.Drawing.Size(66, 13);
            this.Label_Description2.TabIndex = 17;
            this.Label_Description2.Text = "Description :";
            // 
            // TextBox_DescLocCham
            // 
            this.TextBox_DescLocCham.Location = new System.Drawing.Point(867, 70);
            this.TextBox_DescLocCham.Name = "TextBox_DescLocCham";
            this.TextBox_DescLocCham.ReadOnly = true;
            this.TextBox_DescLocCham.Size = new System.Drawing.Size(100, 20);
            this.TextBox_DescLocCham.TabIndex = 18;
            // 
            // fKAYANTCHAMBindingSource
            // 
            this.fKAYANTCHAMBindingSource.DataMember = "FK_AYANTCHAM";
            this.fKAYANTCHAMBindingSource.DataSource = this.BS_Chambre;
            // 
            // BS_Chambre
            // 
            this.BS_Chambre.DataMember = "Chambre";
            this.BS_Chambre.DataSource = this.dataSet_Chambre;
            // 
            // localisationBindingSource
            // 
            this.localisationBindingSource.DataMember = "Localisation";
            this.localisationBindingSource.DataSource = this.dataSetChambreBindingSource;
            // 
            // dataSetChambreBindingSource
            // 
            this.dataSetChambreBindingSource.DataSource = this.dataSet_Chambre;
            this.dataSetChambreBindingSource.Position = 0;
            // 
            // TA_Chambre
            // 
            this.TA_Chambre.ClearBeforeFill = true;
            // 
            // TA_Localisation
            // 
            this.TA_Localisation.ClearBeforeFill = true;
            // 
            // TA_TypeChambre
            // 
            this.TA_TypeChambre.ClearBeforeFill = true;
            // 
            // TA_Ayant
            // 
            this.TA_Ayant.ClearBeforeFill = true;
            // 
            // TA_Commodite
            // 
            this.TA_Commodite.ClearBeforeFill = true;
            // 
            // dataSet_Chambre1
            // 
            this.dataSet_Chambre1.DataSetName = "DataSet_Chambre";
            this.dataSet_Chambre1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Chambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1182, 622);
            this.Name = "Chambre";
            this.Load += new System.EventHandler(this.Chambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Ayant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Localisation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TypeChambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAYANTCHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localisationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Commodite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet_Chambre dataSet_Chambre;
        private System.Windows.Forms.BindingSource BS_Chambre;
        private DataSet_ChambreTableAdapters.ChambreTableAdapter TA_Chambre;
        protected System.Windows.Forms.DataGridView DGV_Chambre;
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
        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.TextBox TextBox_LocChambre;
        private System.Windows.Forms.TextBox TextBox_TypeChambre;
        private System.Windows.Forms.Label Label_CodeLoc;
        private System.Windows.Forms.Label Label_CodeType;
        private System.Windows.Forms.TextBox TextBox_DescLocCham;
        private System.Windows.Forms.Label Label_Description2;
        private System.Windows.Forms.TextBox TextBox_DescChambre;
        private DataSet_ChambreTableAdapters.LocalisationTableAdapter TA_Localisation;
        private DataSet_ChambreTableAdapters.TypeChamTableAdapter TA_TypeChambre;
        private System.Windows.Forms.BindingSource BS_Localisation;
        private System.Windows.Forms.BindingSource BS_TypeChambre;
        private System.Windows.Forms.BindingSource fKAYANTCHAMBindingSource;
        private DataSet_ChambreTableAdapters.AyantTableAdapter TA_Ayant;
        private System.Windows.Forms.BindingSource dataSetChambreBindingSource;
        private System.Windows.Forms.BindingSource BS_Ayant;
        private System.Windows.Forms.BindingSource localisationBindingSource;
        private DataSet_ChambreTableAdapters.CommoditeTableAdapter TA_Commodite;
        private System.Windows.Forms.BindingSource BS_Commodite;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescCom;
        private DataSet_Chambre dataSet_Chambre1;
    }
}
