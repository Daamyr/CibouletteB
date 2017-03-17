namespace Prj_Transaction_Charles
{
    partial class Transaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_Trx = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_Trx = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Transaction = new Prj_Transaction_Charles.DataSet_Transaction();
            this.txtBox_noReserve = new System.Windows.Forms.TextBox();
            this.lab_numCli = new System.Windows.Forms.Label();
            this.lab_nameCli = new System.Windows.Forms.Label();
            this.lab_phone = new System.Windows.Forms.Label();
            this.txtBox_numCli = new System.Windows.Forms.TextBox();
            this.txtBox_nameCli = new System.Windows.Forms.TextBox();
            this.txtBox_phone = new System.Windows.Forms.TextBox();
            this.lab_noReserve = new System.Windows.Forms.Label();
            this.lab_dateReserve = new System.Windows.Forms.Label();
            this.lab_numRoom = new System.Windows.Forms.Label();
            this.lab_dateStart = new System.Windows.Forms.Label();
            this.lab_dateEnd = new System.Windows.Forms.Label();
            this.txtBox_dateReserve = new System.Windows.Forms.TextBox();
            this.txtBox_roomNum = new System.Windows.Forms.TextBox();
            this.txtBox_dateStart = new System.Windows.Forms.TextBox();
            this.txtBox_dateEnd = new System.Windows.Forms.TextBox();
            this.lab_total = new System.Windows.Forms.Label();
            this.txtBox_tot = new System.Windows.Forms.TextBox();
            this.TA_Trx = new Prj_Transaction_Charles.DataSet_TransactionTableAdapters.TrxTableAdapter();
            this.TA_Client = new Prj_Transaction_Charles.DataSet_TransactionTableAdapters.ClientTableAdapter();
            this.TA_Reserve = new Prj_Transaction_Charles.DataSet_TransactionTableAdapters.ReservationTableAdapter();
            this.BS_Reserve = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Cli = new System.Windows.Forms.BindingSource(this.components);
            this.TA_Chambre = new Prj_Transaction_Charles.DataSet_TransactionTableAdapters.ChambreTableAdapter();
            this.BS_Chambre = new System.Windows.Forms.BindingSource(this.components);
            this.TA_TypeTrx = new Prj_Transaction_Charles.DataSet_TransactionTableAdapters.TypeTrxTableAdapter();
            this.BS_TypeTrx = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB)).BeginInit();
            this.pan_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Trx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Trx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Transaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Reserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Cli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TypeTrx)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Click += new System.EventHandler(this.onNonImplemented);
            // 
            // btn_previous
            // 
            this.btn_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Click += new System.EventHandler(this.onNonImplemented);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Click += new System.EventHandler(this.onNonImplemented);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Click += new System.EventHandler(this.onNonImplemented);
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Click += new System.EventHandler(this.onNonImplemented);
            // 
            // pan_principal
            // 
            this.pan_principal.Controls.Add(this.txtBox_tot);
            this.pan_principal.Controls.Add(this.lab_total);
            this.pan_principal.Controls.Add(this.txtBox_dateEnd);
            this.pan_principal.Controls.Add(this.txtBox_dateStart);
            this.pan_principal.Controls.Add(this.txtBox_roomNum);
            this.pan_principal.Controls.Add(this.txtBox_dateReserve);
            this.pan_principal.Controls.Add(this.lab_dateEnd);
            this.pan_principal.Controls.Add(this.lab_dateStart);
            this.pan_principal.Controls.Add(this.lab_numRoom);
            this.pan_principal.Controls.Add(this.lab_dateReserve);
            this.pan_principal.Controls.Add(this.lab_noReserve);
            this.pan_principal.Controls.Add(this.txtBox_phone);
            this.pan_principal.Controls.Add(this.txtBox_nameCli);
            this.pan_principal.Controls.Add(this.txtBox_numCli);
            this.pan_principal.Controls.Add(this.lab_phone);
            this.pan_principal.Controls.Add(this.lab_nameCli);
            this.pan_principal.Controls.Add(this.lab_numCli);
            this.pan_principal.Controls.Add(this.txtBox_noReserve);
            this.pan_principal.Controls.Add(this.DGV_Trx);
            this.pan_principal.Size = new System.Drawing.Size(1154, 439);
            // 
            // DGV_Trx
            // 
            this.DGV_Trx.AllowUserToAddRows = false;
            this.DGV_Trx.AllowUserToDeleteRows = false;
            this.DGV_Trx.AllowUserToResizeColumns = false;
            this.DGV_Trx.AllowUserToResizeRows = false;
            this.DGV_Trx.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Californian FB", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Trx.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Trx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Trx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.Description,
            this.dataGridViewTextBoxColumn3});
            this.DGV_Trx.DataSource = this.BS_Trx;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Californian FB", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Trx.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Trx.EnableHeadersVisualStyles = false;
            this.DGV_Trx.Location = new System.Drawing.Point(0, 221);
            this.DGV_Trx.Name = "DGV_Trx";
            this.DGV_Trx.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Californian FB", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Trx.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Trx.RowHeadersVisible = false;
            this.DGV_Trx.ShowEditingIcon = false;
            this.DGV_Trx.Size = new System.Drawing.Size(1151, 160);
            this.DGV_Trx.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdTrx";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numéro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateTrx";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CodTypTrx";
            this.dataGridViewTextBoxColumn5.HeaderText = "Code";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MontantTrx";
            this.dataGridViewTextBoxColumn3.HeaderText = "Montant";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // BS_Trx
            // 
            this.BS_Trx.DataMember = "Trx";
            this.BS_Trx.DataSource = this.DataSet_Transaction;
            // 
            // DataSet_Transaction
            // 
            this.DataSet_Transaction.DataSetName = "DataSet_Transaction";
            this.DataSet_Transaction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBox_noReserve
            // 
            this.txtBox_noReserve.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_noReserve.Location = new System.Drawing.Point(573, 18);
            this.txtBox_noReserve.Name = "txtBox_noReserve";
            this.txtBox_noReserve.ReadOnly = true;
            this.txtBox_noReserve.Size = new System.Drawing.Size(100, 25);
            this.txtBox_noReserve.TabIndex = 1;
            // 
            // lab_numCli
            // 
            this.lab_numCli.AutoSize = true;
            this.lab_numCli.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.lab_numCli.Location = new System.Drawing.Point(18, 24);
            this.lab_numCli.Name = "lab_numCli";
            this.lab_numCli.Size = new System.Drawing.Size(108, 18);
            this.lab_numCli.TabIndex = 2;
            this.lab_numCli.Text = "Numéro Client : ";
            // 
            // lab_nameCli
            // 
            this.lab_nameCli.AutoSize = true;
            this.lab_nameCli.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.lab_nameCli.Location = new System.Drawing.Point(18, 50);
            this.lab_nameCli.Name = "lab_nameCli";
            this.lab_nameCli.Size = new System.Drawing.Size(89, 18);
            this.lab_nameCli.TabIndex = 3;
            this.lab_nameCli.Text = "Nom Client : ";
            // 
            // lab_phone
            // 
            this.lab_phone.AutoSize = true;
            this.lab_phone.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.lab_phone.Location = new System.Drawing.Point(18, 77);
            this.lab_phone.Name = "lab_phone";
            this.lab_phone.Size = new System.Drawing.Size(79, 18);
            this.lab_phone.TabIndex = 4;
            this.lab_phone.Text = "Téléphone : ";
            // 
            // txtBox_numCli
            // 
            this.txtBox_numCli.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_numCli.Location = new System.Drawing.Point(123, 18);
            this.txtBox_numCli.Name = "txtBox_numCli";
            this.txtBox_numCli.ReadOnly = true;
            this.txtBox_numCli.Size = new System.Drawing.Size(100, 25);
            this.txtBox_numCli.TabIndex = 5;
            this.txtBox_numCli.TextChanged += new System.EventHandler(this.onIdCliChanged);
            // 
            // txtBox_nameCli
            // 
            this.txtBox_nameCli.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_nameCli.Location = new System.Drawing.Point(123, 46);
            this.txtBox_nameCli.Name = "txtBox_nameCli";
            this.txtBox_nameCli.ReadOnly = true;
            this.txtBox_nameCli.Size = new System.Drawing.Size(100, 25);
            this.txtBox_nameCli.TabIndex = 6;
            // 
            // txtBox_phone
            // 
            this.txtBox_phone.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_phone.Location = new System.Drawing.Point(123, 74);
            this.txtBox_phone.Name = "txtBox_phone";
            this.txtBox_phone.ReadOnly = true;
            this.txtBox_phone.Size = new System.Drawing.Size(100, 25);
            this.txtBox_phone.TabIndex = 7;
            // 
            // lab_noReserve
            // 
            this.lab_noReserve.AutoSize = true;
            this.lab_noReserve.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.lab_noReserve.Location = new System.Drawing.Point(454, 23);
            this.lab_noReserve.Name = "lab_noReserve";
            this.lab_noReserve.Size = new System.Drawing.Size(110, 18);
            this.lab_noReserve.TabIndex = 8;
            this.lab_noReserve.Text = "No. Réservation : ";
            // 
            // lab_dateReserve
            // 
            this.lab_dateReserve.AutoSize = true;
            this.lab_dateReserve.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.lab_dateReserve.Location = new System.Drawing.Point(454, 49);
            this.lab_dateReserve.Name = "lab_dateReserve";
            this.lab_dateReserve.Size = new System.Drawing.Size(91, 18);
            this.lab_dateReserve.TabIndex = 9;
            this.lab_dateReserve.Text = "Date Réservé : ";
            // 
            // lab_numRoom
            // 
            this.lab_numRoom.AutoSize = true;
            this.lab_numRoom.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.lab_numRoom.Location = new System.Drawing.Point(944, 24);
            this.lab_numRoom.Name = "lab_numRoom";
            this.lab_numRoom.Size = new System.Drawing.Size(98, 18);
            this.lab_numRoom.TabIndex = 10;
            this.lab_numRoom.Text = "Chambre No. : ";
            // 
            // lab_dateStart
            // 
            this.lab_dateStart.AutoSize = true;
            this.lab_dateStart.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.lab_dateStart.Location = new System.Drawing.Point(944, 50);
            this.lab_dateStart.Name = "lab_dateStart";
            this.lab_dateStart.Size = new System.Drawing.Size(99, 18);
            this.lab_dateStart.TabIndex = 11;
            this.lab_dateStart.Text = "Date de début : ";
            // 
            // lab_dateEnd
            // 
            this.lab_dateEnd.AutoSize = true;
            this.lab_dateEnd.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.lab_dateEnd.Location = new System.Drawing.Point(944, 76);
            this.lab_dateEnd.Name = "lab_dateEnd";
            this.lab_dateEnd.Size = new System.Drawing.Size(80, 18);
            this.lab_dateEnd.TabIndex = 12;
            this.lab_dateEnd.Text = "Date de fin : ";
            // 
            // txtBox_dateReserve
            // 
            this.txtBox_dateReserve.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_dateReserve.Location = new System.Drawing.Point(573, 46);
            this.txtBox_dateReserve.Name = "txtBox_dateReserve";
            this.txtBox_dateReserve.ReadOnly = true;
            this.txtBox_dateReserve.Size = new System.Drawing.Size(100, 25);
            this.txtBox_dateReserve.TabIndex = 13;
            // 
            // txtBox_roomNum
            // 
            this.txtBox_roomNum.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_roomNum.Location = new System.Drawing.Point(1041, 20);
            this.txtBox_roomNum.Name = "txtBox_roomNum";
            this.txtBox_roomNum.ReadOnly = true;
            this.txtBox_roomNum.Size = new System.Drawing.Size(100, 25);
            this.txtBox_roomNum.TabIndex = 14;
            // 
            // txtBox_dateStart
            // 
            this.txtBox_dateStart.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_dateStart.Location = new System.Drawing.Point(1041, 47);
            this.txtBox_dateStart.Name = "txtBox_dateStart";
            this.txtBox_dateStart.ReadOnly = true;
            this.txtBox_dateStart.Size = new System.Drawing.Size(100, 25);
            this.txtBox_dateStart.TabIndex = 15;
            // 
            // txtBox_dateEnd
            // 
            this.txtBox_dateEnd.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_dateEnd.Location = new System.Drawing.Point(1041, 74);
            this.txtBox_dateEnd.Name = "txtBox_dateEnd";
            this.txtBox_dateEnd.ReadOnly = true;
            this.txtBox_dateEnd.Size = new System.Drawing.Size(100, 25);
            this.txtBox_dateEnd.TabIndex = 16;
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.lab_total.Location = new System.Drawing.Point(550, 390);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(48, 18);
            this.lab_total.TabIndex = 17;
            this.lab_total.Text = "Total : ";
            // 
            // txtBox_tot
            // 
            this.txtBox_tot.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_tot.Location = new System.Drawing.Point(602, 387);
            this.txtBox_tot.Name = "txtBox_tot";
            this.txtBox_tot.ReadOnly = true;
            this.txtBox_tot.Size = new System.Drawing.Size(100, 25);
            this.txtBox_tot.TabIndex = 18;
            // 
            // TA_Trx
            // 
            this.TA_Trx.ClearBeforeFill = true;
            // 
            // TA_Client
            // 
            this.TA_Client.ClearBeforeFill = true;
            // 
            // TA_Reserve
            // 
            this.TA_Reserve.ClearBeforeFill = true;
            // 
            // BS_Reserve
            // 
            this.BS_Reserve.DataMember = "Reservation";
            this.BS_Reserve.DataSource = this.DataSet_Transaction;
            // 
            // BS_Cli
            // 
            this.BS_Cli.AllowNew = true;
            this.BS_Cli.DataMember = "Client";
            this.BS_Cli.DataSource = this.DataSet_Transaction;
            // 
            // TA_Chambre
            // 
            this.TA_Chambre.ClearBeforeFill = true;
            // 
            // BS_Chambre
            // 
            this.BS_Chambre.DataMember = "Chambre";
            this.BS_Chambre.DataSource = this.DataSet_Transaction;
            // 
            // TA_TypeTrx
            // 
            this.TA_TypeTrx.ClearBeforeFill = true;
            // 
            // BS_TypeTrx
            // 
            this.BS_TypeTrx.DataMember = "TypeTrx";
            this.BS_TypeTrx.DataSource = this.DataSet_Transaction;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1183, 608);
            this.Name = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB)).EndInit();
            this.pan_principal.ResumeLayout(false);
            this.pan_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Trx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Trx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Transaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Reserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Cli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TypeTrx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet_Transaction DataSet_Transaction;
        private System.Windows.Forms.BindingSource BS_Trx;
        private DataSet_TransactionTableAdapters.TrxTableAdapter TA_Trx;
        private System.Windows.Forms.DataGridView DGV_Trx;
        private System.Windows.Forms.TextBox txtBox_noReserve;
        private DataSet_TransactionTableAdapters.ClientTableAdapter TA_Client;
        private DataSet_TransactionTableAdapters.ReservationTableAdapter TA_Reserve;
        private System.Windows.Forms.BindingSource BS_Reserve;
        private System.Windows.Forms.BindingSource BS_Cli;
        private System.Windows.Forms.TextBox txtBox_dateReserve;
        private System.Windows.Forms.Label lab_dateEnd;
        private System.Windows.Forms.Label lab_dateStart;
        private System.Windows.Forms.Label lab_numRoom;
        private System.Windows.Forms.Label lab_dateReserve;
        private System.Windows.Forms.Label lab_noReserve;
        private System.Windows.Forms.TextBox txtBox_phone;
        private System.Windows.Forms.TextBox txtBox_nameCli;
        private System.Windows.Forms.TextBox txtBox_numCli;
        private System.Windows.Forms.Label lab_phone;
        private System.Windows.Forms.Label lab_nameCli;
        private System.Windows.Forms.Label lab_numCli;
        private System.Windows.Forms.TextBox txtBox_dateEnd;
        private System.Windows.Forms.TextBox txtBox_dateStart;
        private System.Windows.Forms.TextBox txtBox_roomNum;
        private System.Windows.Forms.TextBox txtBox_tot;
        private System.Windows.Forms.Label lab_total;
        private DataSet_TransactionTableAdapters.ChambreTableAdapter TA_Chambre;
        private System.Windows.Forms.BindingSource BS_Chambre;
        private DataSet_TransactionTableAdapters.TypeTrxTableAdapter TA_TypeTrx;
        private System.Windows.Forms.BindingSource BS_TypeTrx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
