namespace Prj_Chambre_Janie
{
    partial class ListeTypeChambre
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
            this.TA_TypeCham = new Prj_Chambre_Janie.DataSet_ChambreTableAdapters.TypeChamTableAdapter();
            this.DGV_ListeTypeChambre = new System.Windows.Forms.DataGridView();
            this.codTypChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descTypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbDispoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeChamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Chambre = new Prj_Chambre_Janie.DataSet_Chambre();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListeTypeChambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre)).BeginInit();
            this.SuspendLayout();
            // 
            // TA_TypeCham
            // 
            this.TA_TypeCham.ClearBeforeFill = true;
            // 
            // DGV_ListeTypeChambre
            // 
            this.DGV_ListeTypeChambre.AllowUserToAddRows = false;
            this.DGV_ListeTypeChambre.AllowUserToDeleteRows = false;
            this.DGV_ListeTypeChambre.AutoGenerateColumns = false;
            this.DGV_ListeTypeChambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListeTypeChambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTypChamDataGridViewTextBoxColumn,
            this.descTypDataGridViewTextBoxColumn,
            this.nbDispoDataGridViewTextBoxColumn});
            this.DGV_ListeTypeChambre.DataSource = this.typeChamBindingSource;
            this.DGV_ListeTypeChambre.Location = new System.Drawing.Point(13, 13);
            this.DGV_ListeTypeChambre.Name = "DGV_ListeTypeChambre";
            this.DGV_ListeTypeChambre.ReadOnly = true;
            this.DGV_ListeTypeChambre.Size = new System.Drawing.Size(572, 179);
            this.DGV_ListeTypeChambre.TabIndex = 0;
            // 
            // codTypChamDataGridViewTextBoxColumn
            // 
            this.codTypChamDataGridViewTextBoxColumn.DataPropertyName = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.HeaderText = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.Name = "codTypChamDataGridViewTextBoxColumn";
            this.codTypChamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descTypDataGridViewTextBoxColumn
            // 
            this.descTypDataGridViewTextBoxColumn.DataPropertyName = "DescTyp";
            this.descTypDataGridViewTextBoxColumn.HeaderText = "DescTyp";
            this.descTypDataGridViewTextBoxColumn.Name = "descTypDataGridViewTextBoxColumn";
            this.descTypDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbDispoDataGridViewTextBoxColumn
            // 
            this.nbDispoDataGridViewTextBoxColumn.DataPropertyName = "NbDispo";
            this.nbDispoDataGridViewTextBoxColumn.HeaderText = "NbDispo";
            this.nbDispoDataGridViewTextBoxColumn.Name = "nbDispoDataGridViewTextBoxColumn";
            this.nbDispoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeChamBindingSource
            // 
            this.typeChamBindingSource.DataMember = "TypeCham";
            this.typeChamBindingSource.DataSource = this.dataSet_Chambre;
            // 
            // dataSet_Chambre
            // 
            this.dataSet_Chambre.DataSetName = "DataSet_Chambre";
            this.dataSet_Chambre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(141, 195);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(81, 31);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(350, 195);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(81, 31);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // ListeTypeChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 230);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.DGV_ListeTypeChambre);
            this.Name = "ListeTypeChambre";
            this.Text = "ListeTypeChambre";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListeTypeChambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet_ChambreTableAdapters.TypeChamTableAdapter TA_TypeCham;
        private System.Windows.Forms.DataGridView DGV_ListeTypeChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTypChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descTypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbDispoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource typeChamBindingSource;
        private DataSet_Chambre dataSet_Chambre;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}