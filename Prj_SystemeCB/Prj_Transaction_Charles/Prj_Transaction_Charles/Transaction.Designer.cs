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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSet_Transaction1 = new Prj_Transaction_Charles.DataSet_Transaction();
            this.BS_Trx = new System.Windows.Forms.BindingSource(this.components);
            this.TA_Trx = new Prj_Transaction_Charles.DataSet_TransactionTableAdapters.TrxTableAdapter();
            this.DGV_Trx = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBox_noReserve = new System.Windows.Forms.TextBox();
            this.TA_Client = new Prj_Transaction_Charles.DataSet_TransactionTableAdapters.ClientTableAdapter();
            this.TA_Reserve = new Prj_Transaction_Charles.DataSet_TransactionTableAdapters.ReservationTableAdapter();
            this.BS_Reserve = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Cli = new System.Windows.Forms.BindingSource(this.components);
            this.labl_numCli = new System.Windows.Forms.Label();
            this.labl_nameCli = new System.Windows.Forms.Label();
            this.labl_phone = new System.Windows.Forms.Label();
            this.txtBox_numCli = new System.Windows.Forms.TextBox();
            this.txtBox_nameCli = new System.Windows.Forms.TextBox();
            this.txtBox_phone = new System.Windows.Forms.TextBox();
            this.labl_noReserve = new System.Windows.Forms.Label();
            this.labl_dateReserve = new System.Windows.Forms.Label();
            this.labl_numRoom = new System.Windows.Forms.Label();
            this.labl_dateStart = new System.Windows.Forms.Label();
            this.labl_dateEnd = new System.Windows.Forms.Label();
            this.txtBox_dateReserve = new System.Windows.Forms.TextBox();
            this.txtBox_roomNum = new System.Windows.Forms.TextBox();
            this.txtBox_dateStart = new System.Windows.Forms.TextBox();
            this.txtBox_dateEnd = new System.Windows.Forms.TextBox();
            this.labl_tot = new System.Windows.Forms.Label();
            this.txtBox_tot = new System.Windows.Forms.TextBox();
            this.TA_Chambre = new Prj_Transaction_Charles.DataSet_TransactionTableAdapters.ChambreTableAdapter();
            this.BS_Chambre = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Transaction1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Trx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Trx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Reserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Cli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_previous
            // 
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBox_tot);
            this.panel1.Controls.Add(this.labl_tot);
            this.panel1.Controls.Add(this.txtBox_dateEnd);
            this.panel1.Controls.Add(this.txtBox_dateStart);
            this.panel1.Controls.Add(this.txtBox_roomNum);
            this.panel1.Controls.Add(this.txtBox_dateReserve);
            this.panel1.Controls.Add(this.labl_dateEnd);
            this.panel1.Controls.Add(this.labl_dateStart);
            this.panel1.Controls.Add(this.labl_numRoom);
            this.panel1.Controls.Add(this.labl_dateReserve);
            this.panel1.Controls.Add(this.labl_noReserve);
            this.panel1.Controls.Add(this.txtBox_phone);
            this.panel1.Controls.Add(this.txtBox_nameCli);
            this.panel1.Controls.Add(this.txtBox_numCli);
            this.panel1.Controls.Add(this.labl_phone);
            this.panel1.Controls.Add(this.labl_nameCli);
            this.panel1.Controls.Add(this.labl_numCli);
            this.panel1.Controls.Add(this.txtBox_noReserve);
            this.panel1.Controls.Add(this.DGV_Trx);
            this.panel1.Size = new System.Drawing.Size(1154, 439);
            // 
            // dataSet_Transaction1
            // 
            this.dataSet_Transaction1.DataSetName = "DataSet_Transaction";
            this.dataSet_Transaction1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BS_Trx
            // 
            this.BS_Trx.DataMember = "Trx";
            this.BS_Trx.DataSource = this.dataSet_Transaction1;
            // 
            // TA_Trx
            // 
            this.TA_Trx.ClearBeforeFill = true;
            // 
            // DGV_Trx
            // 
            this.DGV_Trx.AllowUserToAddRows = false;
            this.DGV_Trx.AllowUserToDeleteRows = false;
            this.DGV_Trx.AllowUserToResizeColumns = false;
            this.DGV_Trx.AllowUserToResizeRows = false;
            this.DGV_Trx.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Californian FB", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Trx.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_Trx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Trx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3});
            this.DGV_Trx.DataSource = this.BS_Trx;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Californian FB", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Trx.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_Trx.EnableHeadersVisualStyles = false;
            this.DGV_Trx.Location = new System.Drawing.Point(0, 221);
            this.DGV_Trx.Name = "DGV_Trx";
            this.DGV_Trx.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Californian FB", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Trx.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_Trx.RowHeadersVisible = false;
            this.DGV_Trx.ShowEditingIcon = false;
            this.DGV_Trx.Size = new System.Drawing.Size(1289, 160);
            this.DGV_Trx.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdTrx";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdTrx";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateTrx";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateTrx";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CodTypTrx";
            this.dataGridViewTextBoxColumn5.HeaderText = "CodTypTrx";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MontantTrx";
            this.dataGridViewTextBoxColumn3.HeaderText = "MontantTrx";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // txtBox_noReserve
            // 
            this.txtBox_noReserve.Font = new System.Drawing.Font("Californian FB", 10F);
            this.txtBox_noReserve.Location = new System.Drawing.Point(563, 20);
            this.txtBox_noReserve.Name = "txtBox_noReserve";
            this.txtBox_noReserve.ReadOnly = true;
            this.txtBox_noReserve.Size = new System.Drawing.Size(100, 23);
            this.txtBox_noReserve.TabIndex = 1;
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
            this.BS_Reserve.DataSource = this.dataSet_Transaction1;
            // 
            // BS_Cli
            // 
            this.BS_Cli.AllowNew = true;
            this.BS_Cli.DataMember = "Client";
            this.BS_Cli.DataSource = this.dataSet_Transaction1;
            // 
            // labl_numCli
            // 
            this.labl_numCli.AutoSize = true;
            this.labl_numCli.Font = new System.Drawing.Font("Californian FB", 10F);
            this.labl_numCli.Location = new System.Drawing.Point(16, 25);
            this.labl_numCli.Name = "labl_numCli";
            this.labl_numCli.Size = new System.Drawing.Size(101, 18);
            this.labl_numCli.TabIndex = 2;
            this.labl_numCli.Text = "Numéro Client : ";
            // 
            // labl_nameCli
            // 
            this.labl_nameCli.AutoSize = true;
            this.labl_nameCli.Font = new System.Drawing.Font("Californian FB", 10F);
            this.labl_nameCli.Location = new System.Drawing.Point(18, 51);
            this.labl_nameCli.Name = "labl_nameCli";
            this.labl_nameCli.Size = new System.Drawing.Size(83, 18);
            this.labl_nameCli.TabIndex = 3;
            this.labl_nameCli.Text = "Nom Client : ";
            // 
            // labl_phone
            // 
            this.labl_phone.AutoSize = true;
            this.labl_phone.Font = new System.Drawing.Font("Californian FB", 10F);
            this.labl_phone.Location = new System.Drawing.Point(18, 77);
            this.labl_phone.Name = "labl_phone";
            this.labl_phone.Size = new System.Drawing.Size(73, 18);
            this.labl_phone.TabIndex = 4;
            this.labl_phone.Text = "Téléphone : ";
            // 
            // txtBox_numCli
            // 
            this.txtBox_numCli.Font = new System.Drawing.Font("Californian FB", 10F);
            this.txtBox_numCli.Location = new System.Drawing.Point(123, 22);
            this.txtBox_numCli.Name = "txtBox_numCli";
            this.txtBox_numCli.ReadOnly = true;
            this.txtBox_numCli.Size = new System.Drawing.Size(100, 23);
            this.txtBox_numCli.TabIndex = 5;
            // 
            // txtBox_nameCli
            // 
            this.txtBox_nameCli.Font = new System.Drawing.Font("Californian FB", 10F);
            this.txtBox_nameCli.Location = new System.Drawing.Point(123, 48);
            this.txtBox_nameCli.Name = "txtBox_nameCli";
            this.txtBox_nameCli.ReadOnly = true;
            this.txtBox_nameCli.Size = new System.Drawing.Size(100, 23);
            this.txtBox_nameCli.TabIndex = 6;
            // 
            // txtBox_phone
            // 
            this.txtBox_phone.Font = new System.Drawing.Font("Californian FB", 10F);
            this.txtBox_phone.Location = new System.Drawing.Point(123, 74);
            this.txtBox_phone.Name = "txtBox_phone";
            this.txtBox_phone.ReadOnly = true;
            this.txtBox_phone.Size = new System.Drawing.Size(100, 23);
            this.txtBox_phone.TabIndex = 7;
            // 
            // labl_noReserve
            // 
            this.labl_noReserve.AutoSize = true;
            this.labl_noReserve.Font = new System.Drawing.Font("Californian FB", 10F);
            this.labl_noReserve.Location = new System.Drawing.Point(454, 23);
            this.labl_noReserve.Name = "labl_noReserve";
            this.labl_noReserve.Size = new System.Drawing.Size(105, 18);
            this.labl_noReserve.TabIndex = 8;
            this.labl_noReserve.Text = "No. Réservation : ";
            // 
            // labl_dateReserve
            // 
            this.labl_dateReserve.AutoSize = true;
            this.labl_dateReserve.Font = new System.Drawing.Font("Californian FB", 10F);
            this.labl_dateReserve.Location = new System.Drawing.Point(454, 49);
            this.labl_dateReserve.Name = "labl_dateReserve";
            this.labl_dateReserve.Size = new System.Drawing.Size(90, 18);
            this.labl_dateReserve.TabIndex = 9;
            this.labl_dateReserve.Text = "Date Réservé : ";
            // 
            // labl_numRoom
            // 
            this.labl_numRoom.AutoSize = true;
            this.labl_numRoom.Font = new System.Drawing.Font("Californian FB", 10F);
            this.labl_numRoom.Location = new System.Drawing.Point(944, 24);
            this.labl_numRoom.Name = "labl_numRoom";
            this.labl_numRoom.Size = new System.Drawing.Size(91, 18);
            this.labl_numRoom.TabIndex = 10;
            this.labl_numRoom.Text = "Chambre No. : ";
            // 
            // labl_dateStart
            // 
            this.labl_dateStart.AutoSize = true;
            this.labl_dateStart.Font = new System.Drawing.Font("Californian FB", 10F);
            this.labl_dateStart.Location = new System.Drawing.Point(944, 50);
            this.labl_dateStart.Name = "labl_dateStart";
            this.labl_dateStart.Size = new System.Drawing.Size(95, 18);
            this.labl_dateStart.TabIndex = 11;
            this.labl_dateStart.Text = "Date de début : ";
            // 
            // labl_dateEnd
            // 
            this.labl_dateEnd.AutoSize = true;
            this.labl_dateEnd.Font = new System.Drawing.Font("Californian FB", 10F);
            this.labl_dateEnd.Location = new System.Drawing.Point(944, 76);
            this.labl_dateEnd.Name = "labl_dateEnd";
            this.labl_dateEnd.Size = new System.Drawing.Size(78, 18);
            this.labl_dateEnd.TabIndex = 12;
            this.labl_dateEnd.Text = "Date de fin : ";
            // 
            // txtBox_dateReserve
            // 
            this.txtBox_dateReserve.Font = new System.Drawing.Font("Californian FB", 10F);
            this.txtBox_dateReserve.Location = new System.Drawing.Point(563, 48);
            this.txtBox_dateReserve.Name = "txtBox_dateReserve";
            this.txtBox_dateReserve.ReadOnly = true;
            this.txtBox_dateReserve.Size = new System.Drawing.Size(100, 23);
            this.txtBox_dateReserve.TabIndex = 13;
            // 
            // txtBox_roomNum
            // 
            this.txtBox_roomNum.Font = new System.Drawing.Font("Californian FB", 10F);
            this.txtBox_roomNum.Location = new System.Drawing.Point(1041, 20);
            this.txtBox_roomNum.Name = "txtBox_roomNum";
            this.txtBox_roomNum.ReadOnly = true;
            this.txtBox_roomNum.Size = new System.Drawing.Size(100, 23);
            this.txtBox_roomNum.TabIndex = 14;
            // 
            // txtBox_dateStart
            // 
            this.txtBox_dateStart.Font = new System.Drawing.Font("Californian FB", 10F);
            this.txtBox_dateStart.Location = new System.Drawing.Point(1041, 44);
            this.txtBox_dateStart.Name = "txtBox_dateStart";
            this.txtBox_dateStart.ReadOnly = true;
            this.txtBox_dateStart.Size = new System.Drawing.Size(100, 23);
            this.txtBox_dateStart.TabIndex = 15;
            // 
            // txtBox_dateEnd
            // 
            this.txtBox_dateEnd.Font = new System.Drawing.Font("Californian FB", 10F);
            this.txtBox_dateEnd.Location = new System.Drawing.Point(1041, 71);
            this.txtBox_dateEnd.Name = "txtBox_dateEnd";
            this.txtBox_dateEnd.ReadOnly = true;
            this.txtBox_dateEnd.Size = new System.Drawing.Size(100, 23);
            this.txtBox_dateEnd.TabIndex = 16;
            // 
            // labl_tot
            // 
            this.labl_tot.AutoSize = true;
            this.labl_tot.Font = new System.Drawing.Font("Californian FB", 10F);
            this.labl_tot.Location = new System.Drawing.Point(550, 390);
            this.labl_tot.Name = "labl_tot";
            this.labl_tot.Size = new System.Drawing.Size(45, 18);
            this.labl_tot.TabIndex = 17;
            this.labl_tot.Text = "Total : ";
            // 
            // txtBox_tot
            // 
            this.txtBox_tot.Font = new System.Drawing.Font("Californian FB", 10F);
            this.txtBox_tot.Location = new System.Drawing.Point(602, 387);
            this.txtBox_tot.Name = "txtBox_tot";
            this.txtBox_tot.ReadOnly = true;
            this.txtBox_tot.Size = new System.Drawing.Size(100, 23);
            this.txtBox_tot.TabIndex = 18;
            // 
            // TA_Chambre
            // 
            this.TA_Chambre.ClearBeforeFill = true;
            // 
            // BS_Chambre
            // 
            this.BS_Chambre.DataMember = "Chambre";
            this.BS_Chambre.DataSource = this.dataSet_Transaction1;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1183, 608);
            this.Name = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Transaction1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Trx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Trx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Reserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Cli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet_Transaction dataSet_Transaction1;
        private System.Windows.Forms.BindingSource BS_Trx;
        private DataSet_TransactionTableAdapters.TrxTableAdapter TA_Trx;
        private System.Windows.Forms.DataGridView DGV_Trx;
        private System.Windows.Forms.TextBox txtBox_noReserve;
        private DataSet_TransactionTableAdapters.ClientTableAdapter TA_Client;
        private DataSet_TransactionTableAdapters.ReservationTableAdapter TA_Reserve;
        private System.Windows.Forms.BindingSource BS_Reserve;
        private System.Windows.Forms.BindingSource BS_Cli;
        private System.Windows.Forms.TextBox txtBox_dateReserve;
        private System.Windows.Forms.Label labl_dateEnd;
        private System.Windows.Forms.Label labl_dateStart;
        private System.Windows.Forms.Label labl_numRoom;
        private System.Windows.Forms.Label labl_dateReserve;
        private System.Windows.Forms.Label labl_noReserve;
        private System.Windows.Forms.TextBox txtBox_phone;
        private System.Windows.Forms.TextBox txtBox_nameCli;
        private System.Windows.Forms.TextBox txtBox_numCli;
        private System.Windows.Forms.Label labl_phone;
        private System.Windows.Forms.Label labl_nameCli;
        private System.Windows.Forms.Label labl_numCli;
        private System.Windows.Forms.TextBox txtBox_dateEnd;
        private System.Windows.Forms.TextBox txtBox_dateStart;
        private System.Windows.Forms.TextBox txtBox_roomNum;
        private System.Windows.Forms.TextBox txtBox_tot;
        private System.Windows.Forms.Label labl_tot;
        private DataSet_TransactionTableAdapters.ChambreTableAdapter TA_Chambre;
        private System.Windows.Forms.BindingSource BS_Chambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
