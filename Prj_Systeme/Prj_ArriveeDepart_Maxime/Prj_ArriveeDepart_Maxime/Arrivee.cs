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
        public Arrivee()
        {
            InitializeComponent();
        }

        private void Arrivee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_Arrivee.De' table. You can move, or remove it, as needed.
            this.TA_de.Fill(this.DataSet_Arrivee.De);

            this.TA_Reser.Fill(this.DataSet_Arrivee.Reservation);

            lien_Reserv();
            lien_De();

        }
        private void lien_Reserv()
        {
            this.BS_Reser.DataSource = this.DataSet_Arrivee;
            this.BS_Reser.DataMember = "Reservation";

            textBox2.DataBindings.Add("Text", BS_De, "IdReser");
            dateTimePicker1.DataBindings.Add("Value", BS_Reser, "DateDebut");
            dateTimePicker2.DataBindings.Add("Value", BS_Reser, "DateFin");
            label22.DataBindings.Add("Text", BS_Reser, "IdCli");

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
            catch (Exception)
            {
            }
        }

        private void lien_Client()
        {
            try
            {
                BS_Client.Position = 0;
                this.BS_Client.DataSource = BS_Reser;
                this.BS_Client.DataMember = "FK_RESCLI";
                dataGridView1.DataSource = BS_De;

            }
            catch (Exception)
            {
            }
        }

        private void lien_Chambre()
        {

        }

        private void btn_next1_Click(object sender, EventArgs e)
        {
            BS_De.Position++;
            BS_Reser.Position++;
        }

        private void btn_previous1_Click(object sender, EventArgs e)
        {
            BS_De.Position--;
            BS_Reser.Position--;
        }



    }
}
