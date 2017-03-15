namespace Prj_Chambre_Janie
{
    partial class ListeChambre
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
            this.DGV_ListeChambre = new System.Windows.Forms.DataGridView();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.dataSet_Chambre = new Prj_Chambre_Janie.DataSet_Chambre();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new Prj_Chambre_Janie.DataSet_ChambreTableAdapters.ChambreTableAdapter();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListeChambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_ListeChambre
            // 
            this.DGV_ListeChambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListeChambre.Location = new System.Drawing.Point(12, 12);
            this.DGV_ListeChambre.Name = "DGV_ListeChambre";
            this.DGV_ListeChambre.Size = new System.Drawing.Size(667, 236);
            this.DGV_ListeChambre.TabIndex = 0;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Ok.Location = new System.Drawing.Point(160, 254);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(56, 49);
            this.Btn_Ok.TabIndex = 1;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            // 
            // dataSet_Chambre
            // 
            this.dataSet_Chambre.DataSetName = "DataSet_Chambre";
            this.dataSet_Chambre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "Chambre";
            this.chambreBindingSource.DataSource = this.dataSet_Chambre;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Location = new System.Drawing.Point(492, 254);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(56, 49);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // ListeChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 315);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.DGV_ListeChambre);
            this.Name = "ListeChambre";
            this.Text = "ListeChambre";
            this.Load += new System.EventHandler(this.ListeChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListeChambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_ListeChambre;
        private System.Windows.Forms.Button Btn_Ok;
        private DataSet_Chambre dataSet_Chambre;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private DataSet_ChambreTableAdapters.ChambreTableAdapter chambreTableAdapter;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}