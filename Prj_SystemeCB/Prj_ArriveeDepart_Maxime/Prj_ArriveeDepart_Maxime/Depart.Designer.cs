namespace Prj_ArriveeDepart_Maxime
{
    partial class Depart
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
            this.pan_Client = new System.Windows.Forms.Panel();
            this.lab_InfoCli = new Prj_lib_graphique.lab_format();
            this.date_DateCarte = new System.Windows.Forms.DateTimePicker();
            this.txtBox_TypeCarte = new Prj_lib_graphique.txtBox_name();
            this.txtBox_Telephone = new Prj_lib_graphique.txtBox_name();
            this.txtBox_Adresse = new Prj_lib_graphique.txtBox_name();
            this.txtBox_Nom = new Prj_lib_graphique.txtBox_name();
            this.txtBox_IdCli = new System.Windows.Forms.TextBox();
            this.lab_TypeCarte = new System.Windows.Forms.Label();
            this.lab_DateCarte = new System.Windows.Forms.Label();
            this.lab_Telephone = new System.Windows.Forms.Label();
            this.lab_Adresse = new System.Windows.Forms.Label();
            this.lab_Nom = new System.Windows.Forms.Label();
            this.lab_IdCli = new System.Windows.Forms.Label();
            this.pan_Reser = new System.Windows.Forms.Panel();
            this.lab_InfoReser = new Prj_lib_graphique.lab_format();
            this.date_DateFin = new System.Windows.Forms.DateTimePicker();
            this.date_DateReser = new System.Windows.Forms.DateTimePicker();
            this.date_DateDebut = new System.Windows.Forms.DateTimePicker();
            this.txtBox_Confirme = new System.Windows.Forms.TextBox();
            this.txtBox_IdReser = new System.Windows.Forms.TextBox();
            this.lab_DateFin = new System.Windows.Forms.Label();
            this.lab_Confirme = new System.Windows.Forms.Label();
            this.lab_DateDebut = new System.Windows.Forms.Label();
            this.lab_DateReser = new System.Windows.Forms.Label();
            this.lab_IdReser = new System.Windows.Forms.Label();
            this.DGV_Depart = new System.Windows.Forms.DataGridView();
            this.idDepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmerParDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_Depart = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Depart = new Prj_ArriveeDepart_Maxime.DataSet_Depart();
            this.TA_Depart = new Prj_ArriveeDepart_Maxime.DataSet_DepartTableAdapters.DepartTableAdapter();
            this.TA_Arrive = new Prj_ArriveeDepart_Maxime.DataSet_DepartTableAdapters.ArriveTableAdapter();
            this.TA_Client = new Prj_ArriveeDepart_Maxime.DataSet_DepartTableAdapters.ClientTableAdapter();
            this.TA_Reser = new Prj_ArriveeDepart_Maxime.DataSet_DepartTableAdapters.ReservationTableAdapter();
            this.BS_Arrive = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Client = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Reser = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB)).BeginInit();
            this.pan_principal.SuspendLayout();
            this.pan_Client.SuspendLayout();
            this.pan_Reser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Depart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Depart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Depart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Arrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Reser)).BeginInit();
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
            this.btn_previous.Click += new System.EventHandler(this.btn_previous1_Click);
            // 
            // btn_next
            // 
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Click += new System.EventHandler(this.btn_next1_Click);
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
            this.pan_principal.Controls.Add(this.DGV_Depart);
            this.pan_principal.Controls.Add(this.pan_Reser);
            this.pan_principal.Controls.Add(this.pan_Client);
            // 
            // pan_Client
            // 
            this.pan_Client.Controls.Add(this.lab_InfoCli);
            this.pan_Client.Controls.Add(this.date_DateCarte);
            this.pan_Client.Controls.Add(this.txtBox_TypeCarte);
            this.pan_Client.Controls.Add(this.txtBox_Telephone);
            this.pan_Client.Controls.Add(this.txtBox_Adresse);
            this.pan_Client.Controls.Add(this.txtBox_Nom);
            this.pan_Client.Controls.Add(this.txtBox_IdCli);
            this.pan_Client.Controls.Add(this.lab_TypeCarte);
            this.pan_Client.Controls.Add(this.lab_DateCarte);
            this.pan_Client.Controls.Add(this.lab_Telephone);
            this.pan_Client.Controls.Add(this.lab_Adresse);
            this.pan_Client.Controls.Add(this.lab_Nom);
            this.pan_Client.Controls.Add(this.lab_IdCli);
            this.pan_Client.Location = new System.Drawing.Point(3, 4);
            this.pan_Client.Name = "pan_Client";
            this.pan_Client.Size = new System.Drawing.Size(514, 197);
            this.pan_Client.TabIndex = 2;
            // 
            // lab_InfoCli
            // 
            this.lab_InfoCli.AutoSize = true;
            this.lab_InfoCli.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_InfoCli.Location = new System.Drawing.Point(81, 6);
            this.lab_InfoCli.Name = "lab_InfoCli";
            this.lab_InfoCli.Size = new System.Drawing.Size(156, 18);
            this.lab_InfoCli.TabIndex = 8;
            this.lab_InfoCli.Text = "Informations sur le client";
            // 
            // date_DateCarte
            // 
            this.date_DateCarte.Enabled = false;
            this.date_DateCarte.Location = new System.Drawing.Point(132, 168);
            this.date_DateCarte.Name = "date_DateCarte";
            this.date_DateCarte.Size = new System.Drawing.Size(175, 20);
            this.date_DateCarte.TabIndex = 7;
            // 
            // txtBox_TypeCarte
            // 
            this.txtBox_TypeCarte.Enabled = false;
            this.txtBox_TypeCarte.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_TypeCarte.Location = new System.Drawing.Point(114, 131);
            this.txtBox_TypeCarte.Name = "txtBox_TypeCarte";
            this.txtBox_TypeCarte.Size = new System.Drawing.Size(211, 25);
            this.txtBox_TypeCarte.TabIndex = 6;
            this.txtBox_TypeCarte.Text = "txtBox";
            // 
            // txtBox_Telephone
            // 
            this.txtBox_Telephone.Enabled = false;
            this.txtBox_Telephone.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Telephone.Location = new System.Drawing.Point(97, 99);
            this.txtBox_Telephone.Name = "txtBox_Telephone";
            this.txtBox_Telephone.Size = new System.Drawing.Size(123, 25);
            this.txtBox_Telephone.TabIndex = 6;
            this.txtBox_Telephone.Text = "txtBox";
            // 
            // txtBox_Adresse
            // 
            this.txtBox_Adresse.Enabled = false;
            this.txtBox_Adresse.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Adresse.Location = new System.Drawing.Point(76, 64);
            this.txtBox_Adresse.Name = "txtBox_Adresse";
            this.txtBox_Adresse.Size = new System.Drawing.Size(318, 25);
            this.txtBox_Adresse.TabIndex = 6;
            this.txtBox_Adresse.Text = "txtBox";
            // 
            // txtBox_Nom
            // 
            this.txtBox_Nom.Enabled = false;
            this.txtBox_Nom.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Nom.Location = new System.Drawing.Point(226, 28);
            this.txtBox_Nom.Name = "txtBox_Nom";
            this.txtBox_Nom.Size = new System.Drawing.Size(167, 25);
            this.txtBox_Nom.TabIndex = 6;
            this.txtBox_Nom.Text = "txtBox";
            // 
            // txtBox_IdCli
            // 
            this.txtBox_IdCli.Enabled = false;
            this.txtBox_IdCli.Location = new System.Drawing.Point(90, 31);
            this.txtBox_IdCli.Name = "txtBox_IdCli";
            this.txtBox_IdCli.Size = new System.Drawing.Size(59, 20);
            this.txtBox_IdCli.TabIndex = 5;
            // 
            // lab_TypeCarte
            // 
            this.lab_TypeCarte.AutoSize = true;
            this.lab_TypeCarte.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TypeCarte.Location = new System.Drawing.Point(16, 134);
            this.lab_TypeCarte.Name = "lab_TypeCarte";
            this.lab_TypeCarte.Size = new System.Drawing.Size(92, 18);
            this.lab_TypeCarte.TabIndex = 4;
            this.lab_TypeCarte.Text = "Type de carte :";
            // 
            // lab_DateCarte
            // 
            this.lab_DateCarte.AutoSize = true;
            this.lab_DateCarte.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_DateCarte.Location = new System.Drawing.Point(15, 168);
            this.lab_DateCarte.Name = "lab_DateCarte";
            this.lab_DateCarte.Size = new System.Drawing.Size(110, 18);
            this.lab_DateCarte.TabIndex = 3;
            this.lab_DateCarte.Text = "Date d\'expiration";
            // 
            // lab_Telephone
            // 
            this.lab_Telephone.AutoSize = true;
            this.lab_Telephone.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Telephone.Location = new System.Drawing.Point(15, 102);
            this.lab_Telephone.Name = "lab_Telephone";
            this.lab_Telephone.Size = new System.Drawing.Size(76, 18);
            this.lab_Telephone.TabIndex = 2;
            this.lab_Telephone.Text = "Téléphone :";
            // 
            // lab_Adresse
            // 
            this.lab_Adresse.AutoSize = true;
            this.lab_Adresse.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Adresse.Location = new System.Drawing.Point(15, 67);
            this.lab_Adresse.Name = "lab_Adresse";
            this.lab_Adresse.Size = new System.Drawing.Size(60, 18);
            this.lab_Adresse.TabIndex = 1;
            this.lab_Adresse.Text = "Adresse :";
            // 
            // lab_Nom
            // 
            this.lab_Nom.AutoSize = true;
            this.lab_Nom.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Nom.Location = new System.Drawing.Point(175, 31);
            this.lab_Nom.Name = "lab_Nom";
            this.lab_Nom.Size = new System.Drawing.Size(45, 18);
            this.lab_Nom.TabIndex = 0;
            this.lab_Nom.Text = "Nom :";
            // 
            // lab_IdCli
            // 
            this.lab_IdCli.AutoSize = true;
            this.lab_IdCli.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_IdCli.Location = new System.Drawing.Point(16, 31);
            this.lab_IdCli.Name = "lab_IdCli";
            this.lab_IdCli.Size = new System.Drawing.Size(68, 18);
            this.lab_IdCli.TabIndex = 0;
            this.lab_IdCli.Text = "Client no°";
            // 
            // pan_Reser
            // 
            this.pan_Reser.Controls.Add(this.lab_InfoReser);
            this.pan_Reser.Controls.Add(this.date_DateFin);
            this.pan_Reser.Controls.Add(this.date_DateReser);
            this.pan_Reser.Controls.Add(this.date_DateDebut);
            this.pan_Reser.Controls.Add(this.txtBox_Confirme);
            this.pan_Reser.Controls.Add(this.txtBox_IdReser);
            this.pan_Reser.Controls.Add(this.lab_DateFin);
            this.pan_Reser.Controls.Add(this.lab_Confirme);
            this.pan_Reser.Controls.Add(this.lab_DateDebut);
            this.pan_Reser.Controls.Add(this.lab_DateReser);
            this.pan_Reser.Controls.Add(this.lab_IdReser);
            this.pan_Reser.Location = new System.Drawing.Point(702, 4);
            this.pan_Reser.Name = "pan_Reser";
            this.pan_Reser.Size = new System.Drawing.Size(453, 197);
            this.pan_Reser.TabIndex = 7;
            // 
            // lab_InfoReser
            // 
            this.lab_InfoReser.AutoSize = true;
            this.lab_InfoReser.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_InfoReser.Location = new System.Drawing.Point(113, 6);
            this.lab_InfoReser.Name = "lab_InfoReser";
            this.lab_InfoReser.Size = new System.Drawing.Size(181, 18);
            this.lab_InfoReser.TabIndex = 8;
            this.lab_InfoReser.Text = "Information sur la réservation";
            // 
            // date_DateFin
            // 
            this.date_DateFin.Enabled = false;
            this.date_DateFin.Location = new System.Drawing.Point(116, 122);
            this.date_DateFin.Name = "date_DateFin";
            this.date_DateFin.Size = new System.Drawing.Size(175, 20);
            this.date_DateFin.TabIndex = 7;
            // 
            // date_DateReser
            // 
            this.date_DateReser.Enabled = false;
            this.date_DateReser.Location = new System.Drawing.Point(275, 41);
            this.date_DateReser.Name = "date_DateReser";
            this.date_DateReser.Size = new System.Drawing.Size(152, 20);
            this.date_DateReser.TabIndex = 7;
            // 
            // date_DateDebut
            // 
            this.date_DateDebut.Enabled = false;
            this.date_DateDebut.Location = new System.Drawing.Point(117, 88);
            this.date_DateDebut.Name = "date_DateDebut";
            this.date_DateDebut.Size = new System.Drawing.Size(175, 20);
            this.date_DateDebut.TabIndex = 7;
            // 
            // txtBox_Confirme
            // 
            this.txtBox_Confirme.Enabled = false;
            this.txtBox_Confirme.Location = new System.Drawing.Point(232, 166);
            this.txtBox_Confirme.Name = "txtBox_Confirme";
            this.txtBox_Confirme.Size = new System.Drawing.Size(59, 20);
            this.txtBox_Confirme.TabIndex = 5;
            // 
            // txtBox_IdReser
            // 
            this.txtBox_IdReser.Enabled = false;
            this.txtBox_IdReser.Location = new System.Drawing.Point(125, 41);
            this.txtBox_IdReser.Name = "txtBox_IdReser";
            this.txtBox_IdReser.Size = new System.Drawing.Size(59, 20);
            this.txtBox_IdReser.TabIndex = 5;
            // 
            // lab_DateFin
            // 
            this.lab_DateFin.AutoSize = true;
            this.lab_DateFin.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_DateFin.Location = new System.Drawing.Point(15, 125);
            this.lab_DateFin.Name = "lab_DateFin";
            this.lab_DateFin.Size = new System.Drawing.Size(77, 18);
            this.lab_DateFin.TabIndex = 4;
            this.lab_DateFin.Text = "Date de fin :";
            // 
            // lab_Confirme
            // 
            this.lab_Confirme.AutoSize = true;
            this.lab_Confirme.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Confirme.Location = new System.Drawing.Point(122, 168);
            this.lab_Confirme.Name = "lab_Confirme";
            this.lab_Confirme.Size = new System.Drawing.Size(93, 18);
            this.lab_Confirme.TabIndex = 3;
            this.lab_Confirme.Text = "Confirmé par :";
            // 
            // lab_DateDebut
            // 
            this.lab_DateDebut.AutoSize = true;
            this.lab_DateDebut.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_DateDebut.Location = new System.Drawing.Point(15, 88);
            this.lab_DateDebut.Name = "lab_DateDebut";
            this.lab_DateDebut.Size = new System.Drawing.Size(96, 18);
            this.lab_DateDebut.TabIndex = 2;
            this.lab_DateDebut.Text = "Date de début :";
            // 
            // lab_DateReser
            // 
            this.lab_DateReser.AutoSize = true;
            this.lab_DateReser.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_DateReser.Location = new System.Drawing.Point(202, 41);
            this.lab_DateReser.Name = "lab_DateReser";
            this.lab_DateReser.Size = new System.Drawing.Size(71, 18);
            this.lab_DateReser.TabIndex = 1;
            this.lab_DateReser.Text = "Réservé le :";
            // 
            // lab_IdReser
            // 
            this.lab_IdReser.AutoSize = true;
            this.lab_IdReser.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_IdReser.Location = new System.Drawing.Point(15, 41);
            this.lab_IdReser.Name = "lab_IdReser";
            this.lab_IdReser.Size = new System.Drawing.Size(101, 18);
            this.lab_IdReser.TabIndex = 0;
            this.lab_IdReser.Text = "N° Réservation :";
            // 
            // DGV_Depart
            // 
            this.DGV_Depart.AllowUserToAddRows = false;
            this.DGV_Depart.AllowUserToDeleteRows = false;
            this.DGV_Depart.AutoGenerateColumns = false;
            this.DGV_Depart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Depart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepartDataGridViewTextBoxColumn,
            this.dateDepartDataGridViewTextBoxColumn,
            this.confirmerParDataGridViewTextBoxColumn,
            this.idReserDataGridViewTextBoxColumn,
            this.noChamDataGridViewTextBoxColumn,
            this.idCliDataGridViewTextBoxColumn,
            this.idArriveDataGridViewTextBoxColumn});
            this.DGV_Depart.DataSource = this.BS_Depart;
            this.DGV_Depart.Location = new System.Drawing.Point(1, 207);
            this.DGV_Depart.Name = "DGV_Depart";
            this.DGV_Depart.ReadOnly = true;
            this.DGV_Depart.Size = new System.Drawing.Size(1154, 229);
            this.DGV_Depart.TabIndex = 8;
            // 
            // idDepartDataGridViewTextBoxColumn
            // 
            this.idDepartDataGridViewTextBoxColumn.DataPropertyName = "IdDepart";
            this.idDepartDataGridViewTextBoxColumn.HeaderText = "IdDepart";
            this.idDepartDataGridViewTextBoxColumn.Name = "idDepartDataGridViewTextBoxColumn";
            this.idDepartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDepartDataGridViewTextBoxColumn
            // 
            this.dateDepartDataGridViewTextBoxColumn.DataPropertyName = "DateDepart";
            this.dateDepartDataGridViewTextBoxColumn.HeaderText = "DateDepart";
            this.dateDepartDataGridViewTextBoxColumn.Name = "dateDepartDataGridViewTextBoxColumn";
            this.dateDepartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // confirmerParDataGridViewTextBoxColumn
            // 
            this.confirmerParDataGridViewTextBoxColumn.DataPropertyName = "ConfirmerPar";
            this.confirmerParDataGridViewTextBoxColumn.HeaderText = "ConfirmerPar";
            this.confirmerParDataGridViewTextBoxColumn.Name = "confirmerParDataGridViewTextBoxColumn";
            this.confirmerParDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idReserDataGridViewTextBoxColumn
            // 
            this.idReserDataGridViewTextBoxColumn.DataPropertyName = "IdReser";
            this.idReserDataGridViewTextBoxColumn.HeaderText = "IdReser";
            this.idReserDataGridViewTextBoxColumn.Name = "idReserDataGridViewTextBoxColumn";
            this.idReserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
            this.noChamDataGridViewTextBoxColumn.HeaderText = "NoCham";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            this.noChamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCliDataGridViewTextBoxColumn
            // 
            this.idCliDataGridViewTextBoxColumn.DataPropertyName = "IdCli";
            this.idCliDataGridViewTextBoxColumn.HeaderText = "IdCli";
            this.idCliDataGridViewTextBoxColumn.Name = "idCliDataGridViewTextBoxColumn";
            this.idCliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idArriveDataGridViewTextBoxColumn
            // 
            this.idArriveDataGridViewTextBoxColumn.DataPropertyName = "IdArrive";
            this.idArriveDataGridViewTextBoxColumn.HeaderText = "IdArrive";
            this.idArriveDataGridViewTextBoxColumn.Name = "idArriveDataGridViewTextBoxColumn";
            this.idArriveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BS_Depart
            // 
            this.BS_Depart.DataMember = "Depart";
            this.BS_Depart.DataSource = this.dataSet_Depart;
            this.BS_Depart.PositionChanged += new System.EventHandler(this.onBS_DepartChanged);
            // 
            // dataSet_Depart
            // 
            this.dataSet_Depart.DataSetName = "DataSet_Depart";
            this.dataSet_Depart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TA_Depart
            // 
            this.TA_Depart.ClearBeforeFill = true;
            // 
            // TA_Arrive
            // 
            this.TA_Arrive.ClearBeforeFill = true;
            // 
            // TA_Client
            // 
            this.TA_Client.ClearBeforeFill = true;
            // 
            // TA_Reser
            // 
            this.TA_Reser.ClearBeforeFill = true;
            // 
            // BS_Arrive
            // 
            this.BS_Arrive.DataMember = "Arrive";
            this.BS_Arrive.DataSource = this.dataSet_Depart;
            // 
            // BS_Client
            // 
            this.BS_Client.DataMember = "Client";
            this.BS_Client.DataSource = this.dataSet_Depart;
            // 
            // BS_Reser
            // 
            this.BS_Reser.DataMember = "Reservation";
            this.BS_Reser.DataSource = this.dataSet_Depart;
            // 
            // Depart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1182, 622);
            this.Name = "Depart";
            this.Load += new System.EventHandler(this.Depart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB)).EndInit();
            this.pan_principal.ResumeLayout(false);
            this.pan_Client.ResumeLayout(false);
            this.pan_Client.PerformLayout();
            this.pan_Reser.ResumeLayout(false);
            this.pan_Reser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Depart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Depart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Depart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Arrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Reser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_Client;
        private System.Windows.Forms.TextBox txtBox_IdCli;
        private System.Windows.Forms.Label lab_TypeCarte;
        private System.Windows.Forms.Label lab_DateCarte;
        private System.Windows.Forms.Label lab_Telephone;
        private System.Windows.Forms.Label lab_Adresse;
        private System.Windows.Forms.Label lab_Nom;
        private System.Windows.Forms.Label lab_IdCli;
        private System.Windows.Forms.Panel pan_Reser;
        private System.Windows.Forms.TextBox txtBox_Confirme;
        private System.Windows.Forms.TextBox txtBox_IdReser;
        private System.Windows.Forms.Label lab_DateFin;
        private System.Windows.Forms.Label lab_Confirme;
        private System.Windows.Forms.Label lab_DateDebut;
        private System.Windows.Forms.Label lab_DateReser;
        private System.Windows.Forms.Label lab_IdReser;
        private System.Windows.Forms.DateTimePicker date_DateFin;
        private System.Windows.Forms.DateTimePicker date_DateReser;
        private System.Windows.Forms.DateTimePicker date_DateDebut;
        private System.Windows.Forms.DateTimePicker date_DateCarte;
        private Prj_lib_graphique.txtBox_name txtBox_TypeCarte;
        private Prj_lib_graphique.txtBox_name txtBox_Telephone;
        private Prj_lib_graphique.txtBox_name txtBox_Adresse;
        private Prj_lib_graphique.txtBox_name txtBox_Nom;
        private System.Windows.Forms.DataGridView DGV_Depart;
        private DataSet_Depart dataSet_Depart;
        private System.Windows.Forms.BindingSource BS_Depart;
        private DataSet_DepartTableAdapters.DepartTableAdapter TA_Depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmerParDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArriveDataGridViewTextBoxColumn;
        private Prj_lib_graphique.lab_format lab_InfoReser;
        private Prj_lib_graphique.lab_format lab_InfoCli;
        private DataSet_DepartTableAdapters.ArriveTableAdapter TA_Arrive;
        private DataSet_DepartTableAdapters.ClientTableAdapter TA_Client;
        private DataSet_DepartTableAdapters.ReservationTableAdapter TA_Reser;
        private System.Windows.Forms.BindingSource BS_Arrive;
        private System.Windows.Forms.BindingSource BS_Client;
        private System.Windows.Forms.BindingSource BS_Reser;
    }
}
