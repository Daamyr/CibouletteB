namespace Prj_ArriveeDepart_Maxime
{
    partial class Arrivee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pan_Reser = new System.Windows.Forms.Panel();
            this.date_DateReser = new System.Windows.Forms.DateTimePicker();
            this.date_ReserFin = new System.Windows.Forms.DateTimePicker();
            this.date_ReserDebut = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBox_IdReser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_Nom_Reser = new System.Windows.Forms.Label();
            this.lab_IdCli_Reser = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_DateReser = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pan_Arrivee = new System.Windows.Forms.Panel();
            this.txtBox_IdArrive = new Prj_lib_graphique.txtBox_name();
            this.lab_IdArrive = new Prj_lib_graphique.lab_format();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBox_IdCli_Arrive = new System.Windows.Forms.TextBox();
            this.lab_NumCham = new System.Windows.Forms.Label();
            this.lab_Telephone = new System.Windows.Forms.Label();
            this.lab_Adresse = new System.Windows.Forms.Label();
            this.lab_Nom = new System.Windows.Forms.Label();
            this.lab_IdCli_Arrive = new System.Windows.Forms.Label();
            this.DGV_Arrivee = new System.Windows.Forms.DataGridView();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPECHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attribueeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_De = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Arrivee = new Prj_ArriveeDepart_Maxime.DataSet_Arrivee();
            this.BS_Client = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Chambre = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Reser = new System.Windows.Forms.BindingSource(this.components);
            this.TA_Reservation = new Prj_ArriveeDepart_Maxime.DataSet_ArriveeTableAdapters.ReservationTableAdapter();
            this.TA_De = new Prj_ArriveeDepart_Maxime.DataSet_ArriveeTableAdapters.DeTableAdapter();
            this.TA_Client = new Prj_ArriveeDepart_Maxime.DataSet_ArriveeTableAdapters.ClientTableAdapter();
            this.TA_Chambre = new Prj_ArriveeDepart_Maxime.DataSet_ArriveeTableAdapters.ChambreTableAdapter();
            this.BS_TypeCham = new System.Windows.Forms.BindingSource(this.components);
            this.TA_TypeCham = new Prj_ArriveeDepart_Maxime.DataSet_ArriveeTableAdapters.TypeChamTableAdapter();
            this.TA_Arrive = new Prj_ArriveeDepart_Maxime.DataSet_ArriveeTableAdapters.ArriveTableAdapter();
            this.BS_Arrive = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB)).BeginInit();
            this.panel1.SuspendLayout();
            this.pan_Reser.SuspendLayout();
            this.pan_Arrivee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Arrivee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_De)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Arrivee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Reser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TypeCham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Arrive)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_previous
            // 
            this.btn_previous.Click += new System.EventHandler(this.btn_previous1_Click);
            // 
            // btn_next
            // 
            this.btn_next.Click += new System.EventHandler(this.btn_next1_Click);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGV_Arrivee);
            this.panel1.Controls.Add(this.pan_Reser);
            this.panel1.Controls.Add(this.pan_Arrivee);
            // 
            // pan_Reser
            // 
            this.pan_Reser.Controls.Add(this.date_DateReser);
            this.pan_Reser.Controls.Add(this.date_ReserFin);
            this.pan_Reser.Controls.Add(this.date_ReserDebut);
            this.pan_Reser.Controls.Add(this.label24);
            this.pan_Reser.Controls.Add(this.label22);
            this.pan_Reser.Controls.Add(this.txtBox_IdReser);
            this.pan_Reser.Controls.Add(this.label6);
            this.pan_Reser.Controls.Add(this.lab_Nom_Reser);
            this.pan_Reser.Controls.Add(this.lab_IdCli_Reser);
            this.pan_Reser.Controls.Add(this.label8);
            this.pan_Reser.Controls.Add(this.lab_DateReser);
            this.pan_Reser.Controls.Add(this.label10);
            this.pan_Reser.Location = new System.Drawing.Point(701, 3);
            this.pan_Reser.Name = "pan_Reser";
            this.pan_Reser.Size = new System.Drawing.Size(453, 176);
            this.pan_Reser.TabIndex = 7;
            // 
            // date_DateReser
            // 
            this.date_DateReser.Enabled = false;
            this.date_DateReser.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.date_DateReser.Location = new System.Drawing.Point(280, 14);
            this.date_DateReser.Name = "date_DateReser";
            this.date_DateReser.Size = new System.Drawing.Size(136, 25);
            this.date_DateReser.TabIndex = 8;
            // 
            // date_ReserFin
            // 
            this.date_ReserFin.Enabled = false;
            this.date_ReserFin.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.date_ReserFin.Location = new System.Drawing.Point(117, 97);
            this.date_ReserFin.Name = "date_ReserFin";
            this.date_ReserFin.Size = new System.Drawing.Size(200, 25);
            this.date_ReserFin.TabIndex = 7;
            // 
            // date_ReserDebut
            // 
            this.date_ReserDebut.Enabled = false;
            this.date_ReserDebut.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.date_ReserDebut.Location = new System.Drawing.Point(117, 61);
            this.date_ReserDebut.Name = "date_ReserDebut";
            this.date_ReserDebut.Size = new System.Drawing.Size(200, 25);
            this.date_ReserDebut.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(122, 147);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 18);
            this.label24.TabIndex = 6;
            this.label24.Text = "Value";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(122, 129);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 18);
            this.label22.TabIndex = 6;
            this.label22.Text = "Value";
            // 
            // txtBox_IdReser
            // 
            this.txtBox_IdReser.Enabled = false;
            this.txtBox_IdReser.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_IdReser.Location = new System.Drawing.Point(122, 17);
            this.txtBox_IdReser.Name = "txtBox_IdReser";
            this.txtBox_IdReser.Size = new System.Drawing.Size(59, 25);
            this.txtBox_IdReser.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date de fin :";
            // 
            // lab_Nom_Reser
            // 
            this.lab_Nom_Reser.AutoSize = true;
            this.lab_Nom_Reser.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Nom_Reser.Location = new System.Drawing.Point(15, 147);
            this.lab_Nom_Reser.Name = "lab_Nom_Reser";
            this.lab_Nom_Reser.Size = new System.Drawing.Size(45, 18);
            this.lab_Nom_Reser.TabIndex = 3;
            this.lab_Nom_Reser.Text = "Nom :";
            // 
            // lab_IdCli_Reser
            // 
            this.lab_IdCli_Reser.AutoSize = true;
            this.lab_IdCli_Reser.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_IdCli_Reser.Location = new System.Drawing.Point(15, 129);
            this.lab_IdCli_Reser.Name = "lab_IdCli_Reser";
            this.lab_IdCli_Reser.Size = new System.Drawing.Size(68, 18);
            this.lab_IdCli_Reser.TabIndex = 3;
            this.lab_IdCli_Reser.Text = "Client no°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date de début :";
            // 
            // lab_DateReser
            // 
            this.lab_DateReser.AutoSize = true;
            this.lab_DateReser.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_DateReser.Location = new System.Drawing.Point(202, 17);
            this.lab_DateReser.Name = "lab_DateReser";
            this.lab_DateReser.Size = new System.Drawing.Size(71, 18);
            this.lab_DateReser.TabIndex = 1;
            this.lab_DateReser.Text = "Réservé le :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "N° Réservation :";
            // 
            // pan_Arrivee
            // 
            this.pan_Arrivee.Controls.Add(this.txtBox_IdArrive);
            this.pan_Arrivee.Controls.Add(this.lab_IdArrive);
            this.pan_Arrivee.Controls.Add(this.label16);
            this.pan_Arrivee.Controls.Add(this.label15);
            this.pan_Arrivee.Controls.Add(this.label14);
            this.pan_Arrivee.Controls.Add(this.label13);
            this.pan_Arrivee.Controls.Add(this.txtBox_IdCli_Arrive);
            this.pan_Arrivee.Controls.Add(this.lab_NumCham);
            this.pan_Arrivee.Controls.Add(this.lab_Telephone);
            this.pan_Arrivee.Controls.Add(this.lab_Adresse);
            this.pan_Arrivee.Controls.Add(this.lab_Nom);
            this.pan_Arrivee.Controls.Add(this.lab_IdCli_Arrive);
            this.pan_Arrivee.Location = new System.Drawing.Point(3, 3);
            this.pan_Arrivee.Name = "pan_Arrivee";
            this.pan_Arrivee.Size = new System.Drawing.Size(514, 176);
            this.pan_Arrivee.TabIndex = 6;
            // 
            // txtBox_IdArrive
            // 
            this.txtBox_IdArrive.Enabled = false;
            this.txtBox_IdArrive.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_IdArrive.Location = new System.Drawing.Point(389, 85);
            this.txtBox_IdArrive.Name = "txtBox_IdArrive";
            this.txtBox_IdArrive.Size = new System.Drawing.Size(37, 25);
            this.txtBox_IdArrive.TabIndex = 8;
            this.txtBox_IdArrive.TextChanged += new System.EventHandler(this.txtBox_IdArrive_TextChanged);
            // 
            // lab_IdArrive
            // 
            this.lab_IdArrive.AutoSize = true;
            this.lab_IdArrive.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_IdArrive.Location = new System.Drawing.Point(309, 88);
            this.lab_IdArrive.Name = "lab_IdArrive";
            this.lab_IdArrive.Size = new System.Drawing.Size(74, 18);
            this.lab_IdArrive.TabIndex = 7;
            this.lab_IdArrive.Text = "N° Arrivée :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(143, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 18);
            this.label16.TabIndex = 6;
            this.label16.Text = "Value";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(97, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 18);
            this.label15.TabIndex = 6;
            this.label15.Text = "Value";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(97, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "Value";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(226, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "Value";
            // 
            // txtBox_IdCli_Arrive
            // 
            this.txtBox_IdCli_Arrive.Enabled = false;
            this.txtBox_IdCli_Arrive.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_IdCli_Arrive.Location = new System.Drawing.Point(89, 17);
            this.txtBox_IdCli_Arrive.Name = "txtBox_IdCli_Arrive";
            this.txtBox_IdCli_Arrive.Size = new System.Drawing.Size(59, 25);
            this.txtBox_IdCli_Arrive.TabIndex = 5;
            // 
            // lab_NumCham
            // 
            this.lab_NumCham.AutoSize = true;
            this.lab_NumCham.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_NumCham.Location = new System.Drawing.Point(14, 137);
            this.lab_NumCham.Name = "lab_NumCham";
            this.lab_NumCham.Size = new System.Drawing.Size(123, 18);
            this.lab_NumCham.TabIndex = 3;
            this.lab_NumCham.Text = "Numéro Chambre :";
            // 
            // lab_Telephone
            // 
            this.lab_Telephone.AutoSize = true;
            this.lab_Telephone.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Telephone.Location = new System.Drawing.Point(15, 88);
            this.lab_Telephone.Name = "lab_Telephone";
            this.lab_Telephone.Size = new System.Drawing.Size(76, 18);
            this.lab_Telephone.TabIndex = 2;
            this.lab_Telephone.Text = "Téléphone :";
            // 
            // lab_Adresse
            // 
            this.lab_Adresse.AutoSize = true;
            this.lab_Adresse.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Adresse.Location = new System.Drawing.Point(15, 53);
            this.lab_Adresse.Name = "lab_Adresse";
            this.lab_Adresse.Size = new System.Drawing.Size(60, 18);
            this.lab_Adresse.TabIndex = 1;
            this.lab_Adresse.Text = "Adresse :";
            // 
            // lab_Nom
            // 
            this.lab_Nom.AutoSize = true;
            this.lab_Nom.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Nom.Location = new System.Drawing.Point(175, 17);
            this.lab_Nom.Name = "lab_Nom";
            this.lab_Nom.Size = new System.Drawing.Size(45, 18);
            this.lab_Nom.TabIndex = 0;
            this.lab_Nom.Text = "Nom :";
            // 
            // lab_IdCli_Arrive
            // 
            this.lab_IdCli_Arrive.AutoSize = true;
            this.lab_IdCli_Arrive.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_IdCli_Arrive.Location = new System.Drawing.Point(15, 17);
            this.lab_IdCli_Arrive.Name = "lab_IdCli_Arrive";
            this.lab_IdCli_Arrive.Size = new System.Drawing.Size(68, 18);
            this.lab_IdCli_Arrive.TabIndex = 0;
            this.lab_IdCli_Arrive.Text = "Client no°";
            // 
            // DGV_Arrivee
            // 
            this.DGV_Arrivee.AllowUserToAddRows = false;
            this.DGV_Arrivee.AllowUserToDeleteRows = false;
            this.DGV_Arrivee.AutoGenerateColumns = false;
            this.DGV_Arrivee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Arrivee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noChamDataGridViewTextBoxColumn,
            this.TYPECHAM,
            this.Prix,
            this.attribueeDataGridViewTextBoxColumn});
            this.DGV_Arrivee.DataSource = this.BS_De;
            this.DGV_Arrivee.Location = new System.Drawing.Point(3, 186);
            this.DGV_Arrivee.Name = "DGV_Arrivee";
            this.DGV_Arrivee.ReadOnly = true;
            this.DGV_Arrivee.Size = new System.Drawing.Size(1151, 250);
            this.DGV_Arrivee.TabIndex = 8;
            // 
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.noChamDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.noChamDataGridViewTextBoxColumn.HeaderText = "NoCham";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            this.noChamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TYPECHAM
            // 
            this.TYPECHAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TYPECHAM.DataPropertyName = "DesTyp";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.TYPECHAM.DefaultCellStyle = dataGridViewCellStyle10;
            this.TYPECHAM.HeaderText = "Type de Chambre";
            this.TYPECHAM.Name = "TYPECHAM";
            this.TYPECHAM.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prix.DataPropertyName = "Prix";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.Prix.DefaultCellStyle = dataGridViewCellStyle11;
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // attribueeDataGridViewTextBoxColumn
            // 
            this.attribueeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attribueeDataGridViewTextBoxColumn.DataPropertyName = "Attribuee";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.attribueeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.attribueeDataGridViewTextBoxColumn.HeaderText = "Attribuee";
            this.attribueeDataGridViewTextBoxColumn.Name = "attribueeDataGridViewTextBoxColumn";
            this.attribueeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BS_De
            // 
            this.BS_De.DataMember = "De";
            this.BS_De.DataSource = this.DataSet_Arrivee;
            // 
            // DataSet_Arrivee
            // 
            this.DataSet_Arrivee.DataSetName = "DataSet_Arrivee";
            this.DataSet_Arrivee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BS_Client
            // 
            this.BS_Client.DataMember = "Client";
            this.BS_Client.DataSource = this.DataSet_Arrivee;
            // 
            // BS_Reser
            // 
            this.BS_Reser.DataMember = "Reservation";
            this.BS_Reser.DataSource = this.DataSet_Arrivee;
            // 
            // TA_Reservation
            // 
            this.TA_Reservation.ClearBeforeFill = true;
            // 
            // TA_De
            // 
            this.TA_De.ClearBeforeFill = true;
            // 
            // TA_Client
            // 
            this.TA_Client.ClearBeforeFill = true;
            // 
            // TA_Chambre
            // 
            this.TA_Chambre.ClearBeforeFill = true;
            // 
            // BS_TypeCham
            // 
            this.BS_TypeCham.DataMember = "TypeCham";
            this.BS_TypeCham.DataSource = this.DataSet_Arrivee;
            // 
            // TA_TypeCham
            // 
            this.TA_TypeCham.ClearBeforeFill = true;
            // 
            // TA_Arrive
            // 
            this.TA_Arrive.ClearBeforeFill = true;
            // 
            // BS_Arrive
            // 
            this.BS_Arrive.DataMember = "Arrive";
            this.BS_Arrive.DataSource = this.DataSet_Arrivee;
            // 
            // Arrivee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1182, 622);
            this.Name = "Arrivee";
            this.Load += new System.EventHandler(this.Arrivee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_CB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pan_Reser.ResumeLayout(false);
            this.pan_Reser.PerformLayout();
            this.pan_Arrivee.ResumeLayout(false);
            this.pan_Arrivee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Arrivee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_De)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Arrivee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Reser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TypeCham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Arrive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_Reser;
        private System.Windows.Forms.DateTimePicker date_ReserFin;
        private System.Windows.Forms.DateTimePicker date_ReserDebut;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBox_IdReser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_Nom_Reser;
        private System.Windows.Forms.Label lab_IdCli_Reser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_DateReser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pan_Arrivee;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBox_IdCli_Arrive;
        private System.Windows.Forms.Label lab_NumCham;
        private System.Windows.Forms.Label lab_Telephone;
        private System.Windows.Forms.Label lab_Adresse;
        private System.Windows.Forms.Label lab_Nom;
        private System.Windows.Forms.Label lab_IdCli_Arrive;
        private System.Windows.Forms.DataGridView DGV_Arrivee;
        private DataSet_Arrivee DataSet_Arrivee;
        private System.Windows.Forms.BindingSource BS_Reser;
        private DataSet_ArriveeTableAdapters.ReservationTableAdapter TA_Reservation;
        private System.Windows.Forms.BindingSource BS_De;
        private DataSet_ArriveeTableAdapters.DeTableAdapter TA_De;
        private DataSet_ArriveeTableAdapters.ClientTableAdapter TA_Client;
        private System.Windows.Forms.BindingSource BS_Client;
        private DataSet_ArriveeTableAdapters.ChambreTableAdapter TA_Chambre;
        private System.Windows.Forms.BindingSource BS_Chambre;
        private System.Windows.Forms.DateTimePicker date_DateReser;
        private System.Windows.Forms.BindingSource BS_TypeCham;
        private DataSet_ArriveeTableAdapters.TypeChamTableAdapter TA_TypeCham;
        private DataSet_ArriveeTableAdapters.ArriveTableAdapter TA_Arrive;
        private System.Windows.Forms.BindingSource BS_Arrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPECHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn attribueeDataGridViewTextBoxColumn;
        private Prj_lib_graphique.txtBox_name txtBox_IdArrive;
        private Prj_lib_graphique.lab_format lab_IdArrive;
    }
}
