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
            this.TA_Res = new Prj_Reservation_James.CBDataSetTableAdapters.ReservationTableAdapter();
            this.TA_Manager = new Prj_Reservation_James.CBDataSetTableAdapters.TableAdapterManager();
            this.reservationDataGridView = new System.Windows.Forms.DataGridView();
            this.BS_Cham = new System.Windows.Forms.BindingSource(this.components);
            this.Panel_Res = new System.Windows.Forms.Panel();
            this.TextBox_Fin = new System.Windows.Forms.TextBox();
            this.TextBox_Debut = new System.Windows.Forms.TextBox();
            this.TextBox_ResLe = new System.Windows.Forms.TextBox();
            this.Label_Fin = new System.Windows.Forms.Label();
            this.TextBox_NoRes = new System.Windows.Forms.TextBox();
            this.Label_NoRes = new System.Windows.Forms.Label();
            this.Label_ResLe = new System.Windows.Forms.Label();
            this.Label_Debut = new System.Windows.Forms.Label();
            this.Label_InfoRes = new System.Windows.Forms.Label();
            this.TA_Cham = new Prj_Reservation_James.CBDataSetTableAdapters.ChambreTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_InfoCli = new System.Windows.Forms.Label();
            this.Label_IdCli = new System.Windows.Forms.Label();
            this.Label_Adresse = new System.Windows.Forms.Label();
            this.Label_Telephone = new System.Windows.Forms.Label();
            this.Label_TypeCarte = new System.Windows.Forms.Label();
            this.Label_DateExp = new System.Windows.Forms.Label();
            this.Label_Nom = new System.Windows.Forms.Label();
            this.Label_Fax = new System.Windows.Forms.Label();
            this.Label_Solde_Du = new System.Windows.Forms.Label();
            this.TextBox_IdCli = new System.Windows.Forms.TextBox();
            this.TextBox_Nom = new System.Windows.Forms.TextBox();
            this.TextBox_Adresse = new System.Windows.Forms.TextBox();
            this.TextBox_Telephone = new System.Windows.Forms.TextBox();
            this.TextBox_TypeCarte = new System.Windows.Forms.TextBox();
            this.TextBox_DateExp = new System.Windows.Forms.TextBox();
            this.TextBox_Fax = new System.Windows.Forms.TextBox();
            this.TextBox_Solde_Du = new System.Windows.Forms.TextBox();
            this.BS_Client = new System.Windows.Forms.BindingSource(this.components);
            this.TA_Client = new Prj_Reservation_James.CBDataSetTableAdapters.ClientTableAdapter();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTypChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Cham)).BeginInit();
            this.Panel_Res.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Client)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_InfoCli);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Label_InfoRes);
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
            // TA_Res
            // 
            this.TA_Res.ClearBeforeFill = true;
            // 
            // TA_Manager
            // 
            this.TA_Manager.ArriveTableAdapter = null;
            this.TA_Manager.AyantTableAdapter = null;
            this.TA_Manager.BackupDataSetBeforeUpdate = false;
            this.TA_Manager.ChambreTableAdapter = null;
            this.TA_Manager.ClientTableAdapter = null;
            this.TA_Manager.CommoditeTableAdapter = null;
            this.TA_Manager.DepartTableAdapter = null;
            this.TA_Manager.DeTableAdapter = null;
            this.TA_Manager.LocalisationTableAdapter = null;
            this.TA_Manager.ReservationTableAdapter = this.TA_Res;
            this.TA_Manager.TrxTableAdapter = null;
            this.TA_Manager.TypeChamTableAdapter = null;
            this.TA_Manager.TypeTrxTableAdapter = null;
            this.TA_Manager.UpdateOrder = Prj_Reservation_James.CBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.noChamDataGridViewTextBoxColumn,
            this.etageDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.etatDataGridViewTextBoxColumn,
            this.memoDataGridViewTextBoxColumn,
            this.codLocDataGridViewTextBoxColumn,
            this.codTypChamDataGridViewTextBoxColumn});
            this.reservationDataGridView.DataSource = this.BS_Cham;
            this.reservationDataGridView.EnableHeadersVisualStyles = false;
            this.reservationDataGridView.Location = new System.Drawing.Point(0, 219);
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.ReadOnly = true;
            this.reservationDataGridView.RowHeadersVisible = false;
            this.reservationDataGridView.Size = new System.Drawing.Size(1269, 163);
            this.reservationDataGridView.TabIndex = 0;
            // 
            // BS_Cham
            // 
            this.BS_Cham.DataMember = "Chambre";
            this.BS_Cham.DataSource = this.CBDataSet;
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
            // Label_InfoRes
            // 
            this.Label_InfoRes.AutoSize = true;
            this.Label_InfoRes.Location = new System.Drawing.Point(955, 15);
            this.Label_InfoRes.Name = "Label_InfoRes";
            this.Label_InfoRes.Size = new System.Drawing.Size(147, 13);
            this.Label_InfoRes.TabIndex = 8;
            this.Label_InfoRes.Text = "Informations sur la réservation";
            // 
            // TA_Cham
            // 
            this.TA_Cham.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TextBox_Solde_Du);
            this.panel2.Controls.Add(this.TextBox_Fax);
            this.panel2.Controls.Add(this.TextBox_DateExp);
            this.panel2.Controls.Add(this.TextBox_TypeCarte);
            this.panel2.Controls.Add(this.TextBox_Telephone);
            this.panel2.Controls.Add(this.TextBox_Nom);
            this.panel2.Controls.Add(this.TextBox_Adresse);
            this.panel2.Controls.Add(this.TextBox_IdCli);
            this.panel2.Controls.Add(this.Label_Solde_Du);
            this.panel2.Controls.Add(this.Label_Fax);
            this.panel2.Controls.Add(this.Label_Nom);
            this.panel2.Controls.Add(this.Label_DateExp);
            this.panel2.Controls.Add(this.Label_TypeCarte);
            this.panel2.Controls.Add(this.Label_Telephone);
            this.panel2.Controls.Add(this.Label_Adresse);
            this.panel2.Controls.Add(this.Label_IdCli);
            this.panel2.Location = new System.Drawing.Point(3, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 182);
            this.panel2.TabIndex = 9;
            // 
            // Label_InfoCli
            // 
            this.Label_InfoCli.AutoSize = true;
            this.Label_InfoCli.Location = new System.Drawing.Point(307, 15);
            this.Label_InfoCli.Name = "Label_InfoCli";
            this.Label_InfoCli.Size = new System.Drawing.Size(175, 13);
            this.Label_InfoCli.TabIndex = 10;
            this.Label_InfoCli.Text = "Informations sur le client qui réserve";
            // 
            // Label_IdCli
            // 
            this.Label_IdCli.AutoSize = true;
            this.Label_IdCli.Location = new System.Drawing.Point(22, 23);
            this.Label_IdCli.Name = "Label_IdCli";
            this.Label_IdCli.Size = new System.Drawing.Size(54, 13);
            this.Label_IdCli.TabIndex = 0;
            this.Label_IdCli.Text = "Client no :";
            // 
            // Label_Adresse
            // 
            this.Label_Adresse.AutoSize = true;
            this.Label_Adresse.Location = new System.Drawing.Point(22, 52);
            this.Label_Adresse.Name = "Label_Adresse";
            this.Label_Adresse.Size = new System.Drawing.Size(51, 13);
            this.Label_Adresse.TabIndex = 1;
            this.Label_Adresse.Text = "Adresse :";
            // 
            // Label_Telephone
            // 
            this.Label_Telephone.AutoSize = true;
            this.Label_Telephone.Location = new System.Drawing.Point(22, 84);
            this.Label_Telephone.Name = "Label_Telephone";
            this.Label_Telephone.Size = new System.Drawing.Size(64, 13);
            this.Label_Telephone.TabIndex = 2;
            this.Label_Telephone.Text = "Telephone :";
            // 
            // Label_TypeCarte
            // 
            this.Label_TypeCarte.AutoSize = true;
            this.Label_TypeCarte.Location = new System.Drawing.Point(20, 116);
            this.Label_TypeCarte.Name = "Label_TypeCarte";
            this.Label_TypeCarte.Size = new System.Drawing.Size(82, 13);
            this.Label_TypeCarte.TabIndex = 3;
            this.Label_TypeCarte.Text = "Type de carte : ";
            // 
            // Label_DateExp
            // 
            this.Label_DateExp.AutoSize = true;
            this.Label_DateExp.Location = new System.Drawing.Point(22, 147);
            this.Label_DateExp.Name = "Label_DateExp";
            this.Label_DateExp.Size = new System.Drawing.Size(62, 13);
            this.Label_DateExp.TabIndex = 4;
            this.Label_DateExp.Text = "Expiration : ";
            // 
            // Label_Nom
            // 
            this.Label_Nom.AutoSize = true;
            this.Label_Nom.Location = new System.Drawing.Point(304, 23);
            this.Label_Nom.Name = "Label_Nom";
            this.Label_Nom.Size = new System.Drawing.Size(35, 13);
            this.Label_Nom.TabIndex = 5;
            this.Label_Nom.Text = "Nom :";
            // 
            // Label_Fax
            // 
            this.Label_Fax.AutoSize = true;
            this.Label_Fax.Location = new System.Drawing.Point(304, 84);
            this.Label_Fax.Name = "Label_Fax";
            this.Label_Fax.Size = new System.Drawing.Size(30, 13);
            this.Label_Fax.TabIndex = 6;
            this.Label_Fax.Text = "Fax :";
            // 
            // Label_Solde_Du
            // 
            this.Label_Solde_Du.AutoSize = true;
            this.Label_Solde_Du.Location = new System.Drawing.Point(304, 147);
            this.Label_Solde_Du.Name = "Label_Solde_Du";
            this.Label_Solde_Du.Size = new System.Drawing.Size(55, 13);
            this.Label_Solde_Du.TabIndex = 7;
            this.Label_Solde_Du.Text = "Solde dû :";
            // 
            // TextBox_IdCli
            // 
            this.TextBox_IdCli.Location = new System.Drawing.Point(114, 20);
            this.TextBox_IdCli.Name = "TextBox_IdCli";
            this.TextBox_IdCli.Size = new System.Drawing.Size(169, 20);
            this.TextBox_IdCli.TabIndex = 8;
            // 
            // TextBox_Nom
            // 
            this.TextBox_Nom.Location = new System.Drawing.Point(365, 20);
            this.TextBox_Nom.Name = "TextBox_Nom";
            this.TextBox_Nom.Size = new System.Drawing.Size(169, 20);
            this.TextBox_Nom.TabIndex = 9;
            // 
            // TextBox_Adresse
            // 
            this.TextBox_Adresse.Location = new System.Drawing.Point(114, 49);
            this.TextBox_Adresse.Name = "TextBox_Adresse";
            this.TextBox_Adresse.Size = new System.Drawing.Size(169, 20);
            this.TextBox_Adresse.TabIndex = 10;
            // 
            // TextBox_Telephone
            // 
            this.TextBox_Telephone.Location = new System.Drawing.Point(114, 81);
            this.TextBox_Telephone.Name = "TextBox_Telephone";
            this.TextBox_Telephone.Size = new System.Drawing.Size(169, 20);
            this.TextBox_Telephone.TabIndex = 11;
            // 
            // TextBox_TypeCarte
            // 
            this.TextBox_TypeCarte.Location = new System.Drawing.Point(114, 113);
            this.TextBox_TypeCarte.Name = "TextBox_TypeCarte";
            this.TextBox_TypeCarte.Size = new System.Drawing.Size(169, 20);
            this.TextBox_TypeCarte.TabIndex = 12;
            // 
            // TextBox_DateExp
            // 
            this.TextBox_DateExp.Location = new System.Drawing.Point(114, 144);
            this.TextBox_DateExp.Name = "TextBox_DateExp";
            this.TextBox_DateExp.Size = new System.Drawing.Size(169, 20);
            this.TextBox_DateExp.TabIndex = 13;
            // 
            // TextBox_Fax
            // 
            this.TextBox_Fax.Location = new System.Drawing.Point(365, 81);
            this.TextBox_Fax.Name = "TextBox_Fax";
            this.TextBox_Fax.Size = new System.Drawing.Size(169, 20);
            this.TextBox_Fax.TabIndex = 14;
            // 
            // TextBox_Solde_Du
            // 
            this.TextBox_Solde_Du.Location = new System.Drawing.Point(365, 144);
            this.TextBox_Solde_Du.Name = "TextBox_Solde_Du";
            this.TextBox_Solde_Du.Size = new System.Drawing.Size(169, 20);
            this.TextBox_Solde_Du.TabIndex = 15;
            // 
            // BS_Client
            // 
            this.BS_Client.DataMember = "Client";
            this.BS_Client.DataSource = this.CBDataSet;
            // 
            // TA_Client
            // 
            this.TA_Client.ClearBeforeFill = true;
            // 
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
            this.noChamDataGridViewTextBoxColumn.HeaderText = "NoCham";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            this.noChamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etageDataGridViewTextBoxColumn
            // 
            this.etageDataGridViewTextBoxColumn.DataPropertyName = "Etage";
            this.etageDataGridViewTextBoxColumn.HeaderText = "Etage";
            this.etageDataGridViewTextBoxColumn.Name = "etageDataGridViewTextBoxColumn";
            this.etageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etatDataGridViewTextBoxColumn
            // 
            this.etatDataGridViewTextBoxColumn.DataPropertyName = "Etat";
            this.etatDataGridViewTextBoxColumn.HeaderText = "Etat";
            this.etatDataGridViewTextBoxColumn.Name = "etatDataGridViewTextBoxColumn";
            this.etatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "Memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "Memo";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            this.memoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codLocDataGridViewTextBoxColumn
            // 
            this.codLocDataGridViewTextBoxColumn.DataPropertyName = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.HeaderText = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.Name = "codLocDataGridViewTextBoxColumn";
            this.codLocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codTypChamDataGridViewTextBoxColumn
            // 
            this.codTypChamDataGridViewTextBoxColumn.DataPropertyName = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.HeaderText = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.Name = "codTypChamDataGridViewTextBoxColumn";
            this.codTypChamDataGridViewTextBoxColumn.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.BS_Cham)).EndInit();
            this.Panel_Res.ResumeLayout(false);
            this.Panel_Res.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CBDataSet CBDataSet;
        private System.Windows.Forms.BindingSource BS_Res;
        private CBDataSetTableAdapters.ReservationTableAdapter TA_Res;
        private CBDataSetTableAdapters.TableAdapterManager TA_Manager;
        private System.Windows.Forms.DataGridView reservationDataGridView;
        private System.Windows.Forms.Label Label_InfoRes;
        private System.Windows.Forms.Panel Panel_Res;
        private System.Windows.Forms.TextBox TextBox_Fin;
        private System.Windows.Forms.TextBox TextBox_Debut;
        private System.Windows.Forms.TextBox TextBox_ResLe;
        private System.Windows.Forms.Label Label_Fin;
        private System.Windows.Forms.TextBox TextBox_NoRes;
        private System.Windows.Forms.Label Label_NoRes;
        private System.Windows.Forms.Label Label_ResLe;
        private System.Windows.Forms.Label Label_Debut;
        private System.Windows.Forms.BindingSource BS_Cham;
        private CBDataSetTableAdapters.ChambreTableAdapter TA_Cham;
        private System.Windows.Forms.Label Label_InfoCli;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label_Telephone;
        private System.Windows.Forms.Label Label_Adresse;
        private System.Windows.Forms.Label Label_IdCli;
        private System.Windows.Forms.Label Label_DateExp;
        private System.Windows.Forms.Label Label_TypeCarte;
        private System.Windows.Forms.Label Label_Solde_Du;
        private System.Windows.Forms.Label Label_Fax;
        private System.Windows.Forms.Label Label_Nom;
        private System.Windows.Forms.TextBox TextBox_Solde_Du;
        private System.Windows.Forms.TextBox TextBox_Fax;
        private System.Windows.Forms.TextBox TextBox_DateExp;
        private System.Windows.Forms.TextBox TextBox_TypeCarte;
        private System.Windows.Forms.TextBox TextBox_Telephone;
        private System.Windows.Forms.TextBox TextBox_Nom;
        private System.Windows.Forms.TextBox TextBox_Adresse;
        private System.Windows.Forms.TextBox TextBox_IdCli;
        private System.Windows.Forms.BindingSource BS_Client;
        private CBDataSetTableAdapters.ClientTableAdapter TA_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTypChamDataGridViewTextBoxColumn;
    }
}
