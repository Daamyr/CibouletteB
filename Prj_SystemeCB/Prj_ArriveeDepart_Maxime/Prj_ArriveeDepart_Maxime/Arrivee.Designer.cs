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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pan_Reser = new System.Windows.Forms.Panel();
            this.lab_InfoReser = new Prj_lib_graphique.lab_format();
            this.txtBox_Nom_Reser = new Prj_lib_graphique.txtBox_name();
            this.txtBox_IdCli_Reser = new Prj_lib_graphique.txtBox_name();
            this.date_DateReser = new System.Windows.Forms.DateTimePicker();
            this.date_ReserFin = new System.Windows.Forms.DateTimePicker();
            this.date_ReserDebut = new System.Windows.Forms.DateTimePicker();
            this.txtBox_IdReser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_Nom_Reser = new System.Windows.Forms.Label();
            this.lab_IdCli_Reser = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_DateReser = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pan_Arrivee = new System.Windows.Forms.Panel();
            this.lab_InfoCli = new Prj_lib_graphique.lab_format();
            this.txtBox_NumCham = new Prj_lib_graphique.txtBox_name();
            this.txtBox_Telephone = new Prj_lib_graphique.txtBox_name();
            this.txtBox_Adresse = new Prj_lib_graphique.txtBox_name();
            this.txtBox_IdArrive = new Prj_lib_graphique.txtBox_name();
            this.lab_IdArrive = new Prj_lib_graphique.lab_format();
            this.txtBox_Nom_Arrive = new System.Windows.Forms.TextBox();
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
            this.pan_principal.SuspendLayout();
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
            this.pan_principal.Controls.Add(this.DGV_Arrivee);
            this.pan_principal.Controls.Add(this.pan_Reser);
            this.pan_principal.Controls.Add(this.pan_Arrivee);
            // 
            // pan_Reser
            // 
            this.pan_Reser.Controls.Add(this.lab_InfoReser);
            this.pan_Reser.Controls.Add(this.txtBox_Nom_Reser);
            this.pan_Reser.Controls.Add(this.txtBox_IdCli_Reser);
            this.pan_Reser.Controls.Add(this.date_DateReser);
            this.pan_Reser.Controls.Add(this.date_ReserFin);
            this.pan_Reser.Controls.Add(this.date_ReserDebut);
            this.pan_Reser.Controls.Add(this.txtBox_IdReser);
            this.pan_Reser.Controls.Add(this.label6);
            this.pan_Reser.Controls.Add(this.lab_Nom_Reser);
            this.pan_Reser.Controls.Add(this.lab_IdCli_Reser);
            this.pan_Reser.Controls.Add(this.label8);
            this.pan_Reser.Controls.Add(this.lab_DateReser);
            this.pan_Reser.Controls.Add(this.label10);
            this.pan_Reser.Location = new System.Drawing.Point(701, 3);
            this.pan_Reser.Name = "pan_Reser";
            this.pan_Reser.Size = new System.Drawing.Size(453, 180);
            this.pan_Reser.TabIndex = 7;
            // 
            // lab_InfoReser
            // 
            this.lab_InfoReser.AutoSize = true;
            this.lab_InfoReser.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_InfoReser.Location = new System.Drawing.Point(116, 4);
            this.lab_InfoReser.Name = "lab_InfoReser";
            this.lab_InfoReser.Size = new System.Drawing.Size(187, 18);
            this.lab_InfoReser.TabIndex = 12;
            this.lab_InfoReser.Text = "Informations sur la réservation";
            // 
            // txtBox_Nom_Reser
            // 
            this.txtBox_Nom_Reser.Enabled = false;
            this.txtBox_Nom_Reser.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Nom_Reser.Location = new System.Drawing.Point(81, 152);
            this.txtBox_Nom_Reser.Name = "txtBox_Nom_Reser";
            this.txtBox_Nom_Reser.Size = new System.Drawing.Size(238, 25);
            this.txtBox_Nom_Reser.TabIndex = 9;
            this.txtBox_Nom_Reser.Text = "txtBox";
            // 
            // txtBox_IdCli_Reser
            // 
            this.txtBox_IdCli_Reser.Enabled = false;
            this.txtBox_IdCli_Reser.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_IdCli_Reser.Location = new System.Drawing.Point(100, 124);
            this.txtBox_IdCli_Reser.Name = "txtBox_IdCli_Reser";
            this.txtBox_IdCli_Reser.Size = new System.Drawing.Size(63, 25);
            this.txtBox_IdCli_Reser.TabIndex = 9;
            this.txtBox_IdCli_Reser.Text = "txtBox";
            // 
            // date_DateReser
            // 
            this.date_DateReser.Enabled = false;
            this.date_DateReser.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.date_DateReser.Location = new System.Drawing.Point(281, 24);
            this.date_DateReser.Name = "date_DateReser";
            this.date_DateReser.Size = new System.Drawing.Size(155, 25);
            this.date_DateReser.TabIndex = 8;
            // 
            // date_ReserFin
            // 
            this.date_ReserFin.Enabled = false;
            this.date_ReserFin.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.date_ReserFin.Location = new System.Drawing.Point(119, 94);
            this.date_ReserFin.Name = "date_ReserFin";
            this.date_ReserFin.Size = new System.Drawing.Size(200, 25);
            this.date_ReserFin.TabIndex = 7;
            // 
            // date_ReserDebut
            // 
            this.date_ReserDebut.Enabled = false;
            this.date_ReserDebut.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.date_ReserDebut.Location = new System.Drawing.Point(119, 58);
            this.date_ReserDebut.Name = "date_ReserDebut";
            this.date_ReserDebut.Size = new System.Drawing.Size(200, 25);
            this.date_ReserDebut.TabIndex = 7;
            // 
            // txtBox_IdReser
            // 
            this.txtBox_IdReser.Enabled = false;
            this.txtBox_IdReser.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_IdReser.Location = new System.Drawing.Point(123, 27);
            this.txtBox_IdReser.Name = "txtBox_IdReser";
            this.txtBox_IdReser.Size = new System.Drawing.Size(59, 25);
            this.txtBox_IdReser.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date de fin :";
            // 
            // lab_Nom_Reser
            // 
            this.lab_Nom_Reser.AutoSize = true;
            this.lab_Nom_Reser.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Nom_Reser.Location = new System.Drawing.Point(30, 155);
            this.lab_Nom_Reser.Name = "lab_Nom_Reser";
            this.lab_Nom_Reser.Size = new System.Drawing.Size(45, 18);
            this.lab_Nom_Reser.TabIndex = 3;
            this.lab_Nom_Reser.Text = "Nom :";
            // 
            // lab_IdCli_Reser
            // 
            this.lab_IdCli_Reser.AutoSize = true;
            this.lab_IdCli_Reser.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_IdCli_Reser.Location = new System.Drawing.Point(26, 128);
            this.lab_IdCli_Reser.Name = "lab_IdCli_Reser";
            this.lab_IdCli_Reser.Size = new System.Drawing.Size(68, 18);
            this.lab_IdCli_Reser.TabIndex = 3;
            this.lab_IdCli_Reser.Text = "Client no°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date de début :";
            // 
            // lab_DateReser
            // 
            this.lab_DateReser.AutoSize = true;
            this.lab_DateReser.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_DateReser.Location = new System.Drawing.Point(203, 27);
            this.lab_DateReser.Name = "lab_DateReser";
            this.lab_DateReser.Size = new System.Drawing.Size(71, 18);
            this.lab_DateReser.TabIndex = 1;
            this.lab_DateReser.Text = "Réservé le :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "N° Réservation :";
            // 
            // pan_Arrivee
            // 
            this.pan_Arrivee.Controls.Add(this.lab_InfoCli);
            this.pan_Arrivee.Controls.Add(this.txtBox_NumCham);
            this.pan_Arrivee.Controls.Add(this.txtBox_Telephone);
            this.pan_Arrivee.Controls.Add(this.txtBox_Adresse);
            this.pan_Arrivee.Controls.Add(this.txtBox_IdArrive);
            this.pan_Arrivee.Controls.Add(this.lab_IdArrive);
            this.pan_Arrivee.Controls.Add(this.txtBox_Nom_Arrive);
            this.pan_Arrivee.Controls.Add(this.txtBox_IdCli_Arrive);
            this.pan_Arrivee.Controls.Add(this.lab_NumCham);
            this.pan_Arrivee.Controls.Add(this.lab_Telephone);
            this.pan_Arrivee.Controls.Add(this.lab_Adresse);
            this.pan_Arrivee.Controls.Add(this.lab_Nom);
            this.pan_Arrivee.Controls.Add(this.lab_IdCli_Arrive);
            this.pan_Arrivee.Location = new System.Drawing.Point(3, 3);
            this.pan_Arrivee.Name = "pan_Arrivee";
            this.pan_Arrivee.Size = new System.Drawing.Size(514, 180);
            this.pan_Arrivee.TabIndex = 6;
            // 
            // lab_InfoCli
            // 
            this.lab_InfoCli.AutoSize = true;
            this.lab_InfoCli.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_InfoCli.Location = new System.Drawing.Point(79, 4);
            this.lab_InfoCli.Name = "lab_InfoCli";
            this.lab_InfoCli.Size = new System.Drawing.Size(214, 18);
            this.lab_InfoCli.TabIndex = 12;
            this.lab_InfoCli.Text = "Informations sur le client qui arrive";
            // 
            // txtBox_NumCham
            // 
            this.txtBox_NumCham.Enabled = false;
            this.txtBox_NumCham.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_NumCham.Location = new System.Drawing.Point(144, 144);
            this.txtBox_NumCham.Name = "txtBox_NumCham";
            this.txtBox_NumCham.Size = new System.Drawing.Size(77, 25);
            this.txtBox_NumCham.TabIndex = 11;
            this.txtBox_NumCham.Text = "txtBox";
            // 
            // txtBox_Telephone
            // 
            this.txtBox_Telephone.Enabled = false;
            this.txtBox_Telephone.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Telephone.Location = new System.Drawing.Point(93, 104);
            this.txtBox_Telephone.Name = "txtBox_Telephone";
            this.txtBox_Telephone.Size = new System.Drawing.Size(197, 25);
            this.txtBox_Telephone.TabIndex = 10;
            this.txtBox_Telephone.Text = "txtBox";
            // 
            // txtBox_Adresse
            // 
            this.txtBox_Adresse.Enabled = false;
            this.txtBox_Adresse.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Adresse.Location = new System.Drawing.Point(82, 69);
            this.txtBox_Adresse.Name = "txtBox_Adresse";
            this.txtBox_Adresse.Size = new System.Drawing.Size(378, 25);
            this.txtBox_Adresse.TabIndex = 9;
            this.txtBox_Adresse.Text = "txtBox";
            // 
            // txtBox_IdArrive
            // 
            this.txtBox_IdArrive.Enabled = false;
            this.txtBox_IdArrive.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_IdArrive.Location = new System.Drawing.Point(423, 104);
            this.txtBox_IdArrive.Name = "txtBox_IdArrive";
            this.txtBox_IdArrive.Size = new System.Drawing.Size(37, 25);
            this.txtBox_IdArrive.TabIndex = 8;
            this.txtBox_IdArrive.Text = "txtBox";
            this.txtBox_IdArrive.TextChanged += new System.EventHandler(this.txtBox_IdArrive_TextChanged);
            // 
            // lab_IdArrive
            // 
            this.lab_IdArrive.AutoSize = true;
            this.lab_IdArrive.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_IdArrive.Location = new System.Drawing.Point(343, 107);
            this.lab_IdArrive.Name = "lab_IdArrive";
            this.lab_IdArrive.Size = new System.Drawing.Size(74, 18);
            this.lab_IdArrive.TabIndex = 7;
            this.lab_IdArrive.Text = "N° Arrivée :";
            // 
            // txtBox_Nom_Arrive
            // 
            this.txtBox_Nom_Arrive.Enabled = false;
            this.txtBox_Nom_Arrive.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_Nom_Arrive.Location = new System.Drawing.Point(227, 33);
            this.txtBox_Nom_Arrive.Name = "txtBox_Nom_Arrive";
            this.txtBox_Nom_Arrive.Size = new System.Drawing.Size(233, 25);
            this.txtBox_Nom_Arrive.TabIndex = 5;
            // 
            // txtBox_IdCli_Arrive
            // 
            this.txtBox_IdCli_Arrive.Enabled = false;
            this.txtBox_IdCli_Arrive.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.txtBox_IdCli_Arrive.Location = new System.Drawing.Point(90, 36);
            this.txtBox_IdCli_Arrive.Name = "txtBox_IdCli_Arrive";
            this.txtBox_IdCli_Arrive.Size = new System.Drawing.Size(59, 25);
            this.txtBox_IdCli_Arrive.TabIndex = 5;
            // 
            // lab_NumCham
            // 
            this.lab_NumCham.AutoSize = true;
            this.lab_NumCham.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_NumCham.Location = new System.Drawing.Point(15, 147);
            this.lab_NumCham.Name = "lab_NumCham";
            this.lab_NumCham.Size = new System.Drawing.Size(123, 18);
            this.lab_NumCham.TabIndex = 3;
            this.lab_NumCham.Text = "Numéro Chambre :";
            // 
            // lab_Telephone
            // 
            this.lab_Telephone.AutoSize = true;
            this.lab_Telephone.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Telephone.Location = new System.Drawing.Point(16, 107);
            this.lab_Telephone.Name = "lab_Telephone";
            this.lab_Telephone.Size = new System.Drawing.Size(76, 18);
            this.lab_Telephone.TabIndex = 2;
            this.lab_Telephone.Text = "Téléphone :";
            // 
            // lab_Adresse
            // 
            this.lab_Adresse.AutoSize = true;
            this.lab_Adresse.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Adresse.Location = new System.Drawing.Point(16, 72);
            this.lab_Adresse.Name = "lab_Adresse";
            this.lab_Adresse.Size = new System.Drawing.Size(60, 18);
            this.lab_Adresse.TabIndex = 1;
            this.lab_Adresse.Text = "Adresse :";
            // 
            // lab_Nom
            // 
            this.lab_Nom.AutoSize = true;
            this.lab_Nom.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Nom.Location = new System.Drawing.Point(176, 36);
            this.lab_Nom.Name = "lab_Nom";
            this.lab_Nom.Size = new System.Drawing.Size(45, 18);
            this.lab_Nom.TabIndex = 0;
            this.lab_Nom.Text = "Nom :";
            // 
            // lab_IdCli_Arrive
            // 
            this.lab_IdCli_Arrive.AutoSize = true;
            this.lab_IdCli_Arrive.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_IdCli_Arrive.Location = new System.Drawing.Point(16, 36);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.noChamDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.noChamDataGridViewTextBoxColumn.HeaderText = "NoCham";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            this.noChamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TYPECHAM
            // 
            this.TYPECHAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TYPECHAM.DataPropertyName = "DesTyp";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.TYPECHAM.DefaultCellStyle = dataGridViewCellStyle2;
            this.TYPECHAM.HeaderText = "Type de Chambre";
            this.TYPECHAM.Name = "TYPECHAM";
            this.TYPECHAM.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prix.DataPropertyName = "Prix";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.Prix.DefaultCellStyle = dataGridViewCellStyle3;
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // attribueeDataGridViewTextBoxColumn
            // 
            this.attribueeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attribueeDataGridViewTextBoxColumn.DataPropertyName = "Attribuee";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Californian FB", 11.25F);
            this.attribueeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.pan_principal.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtBox_IdReser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_Nom_Reser;
        private System.Windows.Forms.Label lab_IdCli_Reser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_DateReser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pan_Arrivee;
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
        private System.Windows.Forms.TextBox txtBox_Nom_Arrive;
        private Prj_lib_graphique.txtBox_name txtBox_NumCham;
        private Prj_lib_graphique.txtBox_name txtBox_Telephone;
        private Prj_lib_graphique.txtBox_name txtBox_Adresse;
        private Prj_lib_graphique.txtBox_name txtBox_IdCli_Reser;
        private Prj_lib_graphique.txtBox_name txtBox_Nom_Reser;
        private Prj_lib_graphique.lab_format lab_InfoReser;
        private Prj_lib_graphique.lab_format lab_InfoCli;
    }
}
