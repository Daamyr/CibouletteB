using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prj_ArriveeDepart_Maxime
{

    public partial class Arrivee : Prj_lib_graphique.Form1
    {
        DataRow dtr_Client;
        

        public Arrivee()
        {
            InitializeComponent();
        }

        private void Arrivee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_Arrivee.De' table. You can move, or remove it, as needed.
            fill();


            lien_Reservation();
            lien_De();
            //lien_Client();

            BS_Client.Position = 0;
            foreach(DataRow dtr_Client in DataSet_Arrivee.Tables["Client"].Rows)
            {
                //DataSet_Arrivee.Tables["Client"].Rows[BS_Client.Position]["IdCli"] = DataSet_Arrivee.Tables[""]//------------------------------
            }

        }

        //rempli les tables
        private void fill()
        {
            this.TA_De.Fill(this.DataSet_Arrivee.De);
            this.TA_Reservation.Fill(this.DataSet_Arrivee.Reservation);
            this.TA_Client.Fill(this.DataSet_Arrivee.Client);
            this.TA_Chambre.Fill(this.DataSet_Arrivee.Chambre);
        }

        private void lien_Reservation()
        {
            this.BS_Reser.DataMember = "Reservation";
            this.BS_Reser.DataSource = this.DataSet_Arrivee;


            textBox2.DataBindings.Add("Text", BS_Reser, "IdReser");
            dateTimePicker1.DataBindings.Add("Value", BS_Reser, "DateDebut");
            dateTimePicker2.DataBindings.Add("Value", BS_Reser, "DateFin");
            label22.DataBindings.Add("Text", BS_Reser, "IdCli");
            dateTimePicker3.DataBindings.Add("Value", BS_Reser, "DateReser");

            //label24.Text = DataSet_Arrivee.Tables["Reservation"].Rows[BS_Reser.Position].GetParentRow("FK_RESCLI")["Nom"].ToString();


            //DataSet_Arrivee.Tables["De"].Columns.Add("Nom", typeof(String));

        }

        private void lien_De()
        {
            try
            {
                BS_De.Position = 0;
                this.BS_De.DataSource = BS_Reser;
                this.BS_De.DataMember = "FK_DERES";
                dataGridView1.DataSource = BS_De;

            }
            catch (Exception) { }
        }

        //private void lien_De()
        //{
        //    this.BS_Reser.DataMember = "De";
        //    this.BS_Reser.DataSource = this.DataSet_Arrivee;

        //    textBox2.DataBindings.Add("Text", BS_De, "IdReser");
        //    dateTimePicker1.DataBindings.Add("Value", BS_Reser, "DateDebut");
        //    dateTimePicker2.DataBindings.Add("Value", BS_Reser, "DateFin");
        //    label22.DataBindings.Add("Text", BS_Reser, "IdCli");
        //}

        
        //private void lien_Client()
        //{
        //    try
        //    {
        //        BS_Client.Position = 0;
        //        this.BS_Client.DataSource = BS_Reser;
        //        this.BS_Client.DataMember = "FK_RESCLI";
        //        dataGridView1.DataSource = BS_De;
        //        label24.DataBindings.Add("Text", BS_Client, "Nom");

        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        private void lien_Chambre()
        {

        }
        

        private void btn_next1_Click(object sender, EventArgs e)
        {
           // BS_De.Position++;
            BS_Reser.Position++;
        }

        private void btn_previous1_Click(object sender, EventArgs e)
        {
            //BS_De.Position--;
            BS_Reser.Position--;
        }

        private void onIdReserChanged(object sender, EventArgs e)
        {
            label24.Text = DataSet_Arrivee.Tables["Reservation"].Rows[BS_Reser.Position].GetParentRow("FK_RESCLI")["Nom"].ToString();
        }


    }
}
