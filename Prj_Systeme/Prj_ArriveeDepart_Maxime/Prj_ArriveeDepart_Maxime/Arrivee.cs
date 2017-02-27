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

            lien_idReserv();

        }
        private void lien_idReserv()
        {
            this.bs_Reser.DataSource = this.DataSet_Arrivee;
            this.bs_Reser.DataMember = "Reservation";

            textBox2.DataBindings.Add("Text", bs_De, "IdReser");
            dateTimePicker1.DataBindings.Add("Value", bs_Reser, "DateDebut");
            dateTimePicker2.DataBindings.Add("Value", bs_Reser, "DateFin");
            label22.DataBindings.Add("Text", bs_Reser, "IdCli");

        }



    }
}
