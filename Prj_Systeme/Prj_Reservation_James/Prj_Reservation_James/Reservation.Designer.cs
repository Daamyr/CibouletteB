namespace Prj_Reservation_James
{
    partial class Reservation
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
            this.CBDataSet = new Prj_Reservation_James.CBDataSet();
            this.BS_Res = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter = new Prj_Reservation_James.CBDataSetTableAdapters.ReservationTableAdapter();
            this.TA_Res = new Prj_Reservation_James.CBDataSetTableAdapters.TableAdapterManager();
            this.reservationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_Res = new System.Windows.Forms.Panel();
            this.TextBox_Fin = new System.Windows.Forms.TextBox();
            this.TextBox_Debut = new System.Windows.Forms.TextBox();
            this.TextBox_ResLe = new System.Windows.Forms.TextBox();
            this.Label_Fin = new System.Windows.Forms.Label();
            this.TextBox_NoRes = new System.Windows.Forms.TextBox();
            this.Label_NoRes = new System.Windows.Forms.Label();
            this.Label_ResLe = new System.Windows.Forms.Label();
            this.Label_Debut = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
            this.Panel_Res.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Panel_Res);
            this.panel1.Controls.Add(this.reservationDataGridView);
            // 
            // CBDataSet
            // 
            this.CBDataSet.DataSetName = "CBDataSet";
            this.CBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BS_Res
            // 
            this.BS_Res.DataMember = "Reservation";
            this.BS_Res.DataSource = this.CBDataSet;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // TA_Res
            // 
            this.TA_Res.ArriveTableAdapter = null;
            this.TA_Res.AyantTableAdapter = null;
            this.TA_Res.BackupDataSetBeforeUpdate = false;
            this.TA_Res.ChambreTableAdapter = null;
            this.TA_Res.ClientTableAdapter = null;
            this.TA_Res.CommoditeTableAdapter = null;
            this.TA_Res.DepartTableAdapter = null;
            this.TA_Res.DeTableAdapter = null;
            this.TA_Res.LocalisationTableAdapter = null;
            this.TA_Res.ReservationTableAdapter = this.reservationTableAdapter;
            this.TA_Res.TrxTableAdapter = null;
            this.TA_Res.TypeChamTableAdapter = null;
            this.TA_Res.TypeTrxTableAdapter = null;
            this.TA_Res.UpdateOrder = Prj_Reservation_James.CBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reservationDataGridView
            // 
            this.reservationDataGridView.AllowUserToAddRows = false;
            this.reservationDataGridView.AllowUserToDeleteRows = false;
            this.reservationDataGridView.AllowUserToResizeColumns = false;
            this.reservationDataGridView.AllowUserToResizeRows = false;
            this.reservationDataGridView.AutoGenerateColumns = false;
            this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.reservationDataGridView.DataSource = this.BS_Res;
            this.reservationDataGridView.EnableHeadersVisualStyles = false;
            this.reservationDataGridView.Location = new System.Drawing.Point(0, 219);
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.RowHeadersVisible = false;
            this.reservationDataGridView.Size = new System.Drawing.Size(1269, 163);
            this.reservationDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdReser";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdReser";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateReser";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateReser";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateDebut";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateDebut";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateFin";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateFin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdCli";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdCli";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Panel_Res
            // 
            this.Panel_Res.Controls.Add(this.TextBox_Fin);
            this.Panel_Res.Controls.Add(this.TextBox_Debut);
            this.Panel_Res.Controls.Add(this.TextBox_ResLe);
            this.Panel_Res.Controls.Add(this.Label_Fin);
            this.Panel_Res.Controls.Add(this.TextBox_NoRes);
            this.Panel_Res.Controls.Add(this.Label_NoRes);
            this.Panel_Res.Controls.Add(this.Label_ResLe);
            this.Panel_Res.Controls.Add(this.Label_Debut);
            this.Panel_Res.Location = new System.Drawing.Point(793, 31);
            this.Panel_Res.Name = "Panel_Res";
            this.Panel_Res.Size = new System.Drawing.Size(473, 182);
            this.Panel_Res.TabIndex = 7;
            // 
            // TextBox_Fin
            // 
            this.TextBox_Fin.Location = new System.Drawing.Point(127, 147);
            this.TextBox_Fin.Name = "TextBox_Fin";
            this.TextBox_Fin.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Fin.TabIndex = 8;
            // 
            // TextBox_Debut
            // 
            this.TextBox_Debut.Location = new System.Drawing.Point(127, 102);
            this.TextBox_Debut.Name = "TextBox_Debut";
            this.TextBox_Debut.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Debut.TabIndex = 7;
            // 
            // TextBox_ResLe
            // 
            this.TextBox_ResLe.Location = new System.Drawing.Point(127, 62);
            this.TextBox_ResLe.Name = "TextBox_ResLe";
            this.TextBox_ResLe.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ResLe.TabIndex = 6;
            // 
            // Label_Fin
            // 
            this.Label_Fin.AutoSize = true;
            this.Label_Fin.Location = new System.Drawing.Point(26, 150);
            this.Label_Fin.Name = "Label_Fin";
            this.Label_Fin.Size = new System.Drawing.Size(65, 13);
            this.Label_Fin.TabIndex = 5;
            this.Label_Fin.Text = "Date de fin :";
            // 
            // TextBox_NoRes
            // 
            this.TextBox_NoRes.Location = new System.Drawing.Point(127, 20);
            this.TextBox_NoRes.Name = "TextBox_NoRes";
            this.TextBox_NoRes.Size = new System.Drawing.Size(100, 20);
            this.TextBox_NoRes.TabIndex = 1;
            // 
            // Label_NoRes
            // 
            this.Label_NoRes.AutoSize = true;
            this.Label_NoRes.Location = new System.Drawing.Point(26, 23);
            this.Label_NoRes.Name = "Label_NoRes";
            this.Label_NoRes.Size = new System.Drawing.Size(85, 13);
            this.Label_NoRes.TabIndex = 2;
            this.Label_NoRes.Text = "No. réservation :";
            // 
            // Label_ResLe
            // 
            this.Label_ResLe.AutoSize = true;
            this.Label_ResLe.Location = new System.Drawing.Point(26, 65);
            this.Label_ResLe.Name = "Label_ResLe";
            this.Label_ResLe.Size = new System.Drawing.Size(64, 13);
            this.Label_ResLe.TabIndex = 3;
            this.Label_ResLe.Text = "Réservé le :";
            // 
            // Label_Debut
            // 
            this.Label_Debut.AutoSize = true;
            this.Label_Debut.Location = new System.Drawing.Point(26, 105);
            this.Label_Debut.Name = "Label_Debut";
            this.Label_Debut.Size = new System.Drawing.Size(81, 13);
            this.Label_Debut.TabIndex = 4;
            this.Label_Debut.Text = "Date de début :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(955, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Informations sur la réservation";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1335, 608);
            this.Name = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Res)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
            this.Panel_Res.ResumeLayout(false);
            this.Panel_Res.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CBDataSet CBDataSet;
        private System.Windows.Forms.BindingSource BS_Res;
        private CBDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter;
        private CBDataSetTableAdapters.TableAdapterManager TA_Res;
        private System.Windows.Forms.DataGridView reservationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Panel_Res;
        private System.Windows.Forms.TextBox TextBox_Fin;
        private System.Windows.Forms.TextBox TextBox_Debut;
        private System.Windows.Forms.TextBox TextBox_ResLe;
        private System.Windows.Forms.Label Label_Fin;
        private System.Windows.Forms.TextBox TextBox_NoRes;
        private System.Windows.Forms.Label Label_NoRes;
        private System.Windows.Forms.Label Label_ResLe;
        private System.Windows.Forms.Label Label_Debut;
    }
}
