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

        private void lien_Reservation()
        {
            this.BS_Reser.DataMember = "Reservation";
            this.BS_Reser.DataSource = this.dataSet_Depart;

            txtBox_IdReser.DataBindings.Add("Text", BS_Reser, "IdReser");
            date_DateReser.DataBindings.Add("Value", BS_Reser, "DateReser");
            date_DateDebut.DataBindings.Add("Value", BS_Reser, "DateDebut");
            date_DateFin.DataBindings.Add("Value", BS_Reser, "DateFin");

            

        }

        private void trouveClient()
        {
            BS_Client.Position = BS_Client.Find("IdCli", dataSet_Depart.Tables["Depart"].Rows[BS_Depart.Position]["IdCli"]);
        }

        private void lien_Client()
        {
            txtBox_IdCli.DataBindings.Add("Text", BS_Client, "IdCli");
            txtBox_Nom.DataBindings.Add("Text", BS_Client, "Nom");
            txtBox_Adresse.DataBindings.Add("Text", BS_Client, "Adresse");
            txtBox_Telephone.DataBindings.Add("Text", BS_Client, "Telephone");
            txtBox_TypeCarte.DataBindings.Add("Text", BS_Client, "TypeCarte");
            date_DateCarte.DataBindings.Add("Text", BS_Client, "DateExp");
        }

        private void lien_Depart()
        {
            try
            {
                this.BS_Depart.Position = 0;
                this.BS_Depart.DataSource = BS_Reser;
                this.BS_Depart.DataMember = "FK_DEPRES";
                this.DGV_Depart.DataSource = BS_Depart;

            }
            catch (Exception) { }
        }

        private void btn_next1_Click(object sender, EventArgs e)
        {
            if (BS_Depart.Position+1 == BS_Depart.Count)
                BS_Reser.MoveNext();
            else
                BS_Depart.MoveNext();

        }

        private void btn_previous1_Click(object sender, EventArgs e)
        {
            if (BS_Depart.Position - 1 < 0)
                BS_Reser.MovePrevious();
            else
                BS_Depart.MovePrevious();
        }

        private void onNonImplemented(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction n'est pas encore implémentée.", "Impossible d'accèder à votre requette!");
        }

        private void onBS_DepartChanged(object sender, EventArgs e)
        {
            if (BS_Depart.Count <= 0)
            {
                DGV_Depart.BackgroundColor = Color.Red;
            }
            else
            {
                trouveClient();
                DGV_Depart.BackgroundColor = Color.Gray;
            }
        }
    }
}
