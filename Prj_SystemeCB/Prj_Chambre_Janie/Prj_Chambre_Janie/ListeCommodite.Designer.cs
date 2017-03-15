namespace Prj_Chambre_Janie
{
    partial class ListeCommodite
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
            this.TA_Commodite = new Prj_Chambre_Janie.DataSet_ChambreTableAdapters.CommoditeTableAdapter();
            this.DGV_ListeCommodite = new System.Windows.Forms.DataGridView();
            this.codComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commoditeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Chambre = new Prj_Chambre_Janie.DataSet_Chambre();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListeCommodite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoditeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre)).BeginInit();
            this.SuspendLayout();
            // 
            // TA_Commodite
            // 
            this.TA_Commodite.ClearBeforeFill = true;
            // 
            // DGV_ListeCommodite
            // 
            this.DGV_ListeCommodite.AllowUserToAddRows = false;
            this.DGV_ListeCommodite.AllowUserToDeleteRows = false;
            this.DGV_ListeCommodite.AutoGenerateColumns = false;
            this.DGV_ListeCommodite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListeCommodite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codComDataGridViewTextBoxColumn,
            this.descComDataGridViewTextBoxColumn});
            this.DGV_ListeCommodite.DataSource = this.commoditeBindingSource;
            this.DGV_ListeCommodite.Location = new System.Drawing.Point(13, 13);
            this.DGV_ListeCommodite.Name = "DGV_ListeCommodite";
            this.DGV_ListeCommodite.ReadOnly = true;
            this.DGV_ListeCommodite.Size = new System.Drawing.Size(505, 160);
            this.DGV_ListeCommodite.TabIndex = 0;
            // 
            // codComDataGridViewTextBoxColumn
            // 
            this.codComDataGridViewTextBoxColumn.DataPropertyName = "CodCom";
            this.codComDataGridViewTextBoxColumn.HeaderText = "CodCom";
            this.codComDataGridViewTextBoxColumn.Name = "codComDataGridViewTextBoxColumn";
            this.codComDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descComDataGridViewTextBoxColumn
            // 
            this.descComDataGridViewTextBoxColumn.DataPropertyName = "DescCom";
            this.descComDataGridViewTextBoxColumn.HeaderText = "DescCom";
            this.descComDataGridViewTextBoxColumn.Name = "descComDataGridViewTextBoxColumn";
            this.descComDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commoditeBindingSource
            // 
            this.commoditeBindingSource.DataMember = "Commodite";
            this.commoditeBindingSource.DataSource = this.dataSet_Chambre;
            // 
            // dataSet_Chambre
            // 
            this.dataSet_Chambre.DataSetName = "DataSet_Chambre";
            this.dataSet_Chambre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(115, 179);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 48);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(329, 179);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 48);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // ListeCommodite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 229);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.DGV_ListeCommodite);
            this.Name = "ListeCommodite";
            this.Text = "ListeCommodite";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListeCommodite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoditeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet_ChambreTableAdapters.CommoditeTableAdapter TA_Commodite;
        private System.Windows.Forms.DataGridView DGV_ListeCommodite;
        private System.Windows.Forms.DataGridViewTextBoxColumn codComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descComDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource commoditeBindingSource;
        private DataSet_Chambre dataSet_Chambre;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}