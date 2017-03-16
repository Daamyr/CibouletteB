using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prj_ArriveeDepart_Maxime
{
    public partial class Depart : Prj_lib_graphique.Form1
    {
        public Depart()
        {
            InitializeComponent();
        }

        private void Depart_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tooltip_Add = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip tooltip_Delete = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip tooltip_Edit = new System.Windows.Forms.ToolTip();
            tooltip_Add.SetToolTip(this.btn_add, "Cliquez pour ajouter un départ");
            tooltip_Delete.SetToolTip(this.btn_delete, "Cliquez pour supprimer un départ");
            tooltip_Edit.SetToolTip(this.btn_edit, "Cliquez pour  modifier un départ");
            // TODO: This line of code loads data into the 'dataSet_Depart.Depart' table. You can move, or remove it, as needed.
            fill();
            BS_Arrive.Position = 0;

            lien_Reservation();
            lien_Client();
            lien_Depart();
        }

        private void fill()
        {
            this.TA_Depart.Fill(this.dataSet_Depart.Depart);
            this.TA_Arrive.Fill(this.dataSet_Depart.Arrive);
            this.TA_Client.Fill(this.dataSet_Depart.Client);
            this.TA_Reser.Fill(this.dataSet_Depart.Reservation);
        }

        private void lien_Client()
        {

        }

        private void lien_Reservation()
        {
            this.BS_Reser.DataMember = "Reservation";
            this.BS_Reser.DataSource = this.dataSet_Depart;

            txtBox_IdReser.DataBindings.Add("Text", BS_Reser, "IdReser");
            date_DateReser.DataBindings.Add("Value", BS_Reser, "DateReser");
            date_DateDebut.DataBindings.Add("Value", BS_Reser, "DateDebut");
            date_DateFin.DataBindings.Add("Value", BS_Reser, "DateFin");

        }

        private void lien_Depart()
        {

        }

        private void btn_next1_Click(object sender, EventArgs e)
        {
            BS_Depart.MoveNext();
        }

        private void btn_previous1_Click(object sender, EventArgs e)
        {
            BS_Depart.MovePrevious();
        }

        private void onNonImplemented(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction n'est pas encore implémentée.", "Impossible d'accèder à votre requette!");
        }
    }
}
