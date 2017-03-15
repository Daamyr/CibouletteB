namespace Prj_Chambre_Janie
{
    partial class ListeLocalisation
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
            this.TA_Localisation = new Prj_Chambre_Janie.DataSet_ChambreTableAdapters.LocalisationTableAdapter();
            this.DGV_ListeLocalisation = new System.Windows.Forms.DataGridView();
            this.codLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localisationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Chambre = new Prj_Chambre_Janie.DataSet_Chambre();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListeLocalisation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localisationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre)).BeginInit();
            this.SuspendLayout();
            // 
            // TA_Localisation
            // 
            this.TA_Localisation.ClearBeforeFill = true;
            // 
            // DGV_ListeLocalisation
            // 
            this.DGV_ListeLocalisation.AllowUserToAddRows = false;
            this.DGV_ListeLocalisation.AllowUserToDeleteRows = false;
            this.DGV_ListeLocalisation.AutoGenerateColumns = false;
            this.DGV_ListeLocalisation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListeLocalisation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLocDataGridViewTextBoxColumn,
            this.descLocDataGridViewTextBoxColumn});
            this.DGV_ListeLocalisation.DataSource = this.localisationBindingSource;
            this.DGV_ListeLocalisation.Location = new System.Drawing.Point(13, 13);
            this.DGV_ListeLocalisation.Name = "DGV_ListeLocalisation";
            this.DGV_ListeLocalisation.ReadOnly = true;
            this.DGV_ListeLocalisation.Size = new System.Drawing.Size(388, 175);
            this.DGV_ListeLocalisation.TabIndex = 0;
            // 
            // codLocDataGridViewTextBoxColumn
            // 
            this.codLocDataGridViewTextBoxColumn.DataPropertyName = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.HeaderText = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.Name = "codLocDataGridViewTextBoxColumn";
            this.codLocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descLocDataGridViewTextBoxColumn
            // 
            this.descLocDataGridViewTextBoxColumn.DataPropertyName = "DescLoc";
            this.descLocDataGridViewTextBoxColumn.HeaderText = "DescLoc";
            this.descLocDataGridViewTextBoxColumn.Name = "descLocDataGridViewTextBoxColumn";
            this.descLocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localisationBindingSource
            // 
            this.localisationBindingSource.DataMember = "Localisation";
            this.localisationBindingSource.DataSource = this.dataSet_Chambre;
            // 
            // dataSet_Chambre
            // 
            this.dataSet_Chambre.DataSetName = "DataSet_Chambre";
            this.dataSet_Chambre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(72, 207);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(60, 51);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(282, 207);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(60, 51);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // ListeLocalisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 270);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.DGV_ListeLocalisation);
            this.Name = "ListeLocalisation";
            this.Text = "ListeLocalisation";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListeLocalisation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localisationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet_ChambreTableAdapters.LocalisationTableAdapter TA_Localisation;
        private System.Windows.Forms.DataGridView DGV_ListeLocalisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource localisationBindingSource;
        private DataSet_Chambre dataSet_Chambre;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}