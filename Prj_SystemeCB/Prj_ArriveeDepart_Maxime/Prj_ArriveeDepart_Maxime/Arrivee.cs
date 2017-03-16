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
            // TODO: This line of code loads data into the 'DataSet_Arrivee.TypeCham' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'DataSet_Arrivee.De' table. You can move, or remove it, as needed.
            System.Windows.Forms.ToolTip tooltip_Add = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip tooltip_Delete = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip tooltip_Edit = new System.Windows.Forms.ToolTip();
            tooltip_Add.SetToolTip(this.btn_add, "Cliquez pour ajouter une arrivée");
            tooltip_Delete.SetToolTip(this.btn_delete, "Cliquez pour supprimer une arrivée");
            tooltip_Edit.SetToolTip(this.btn_edit, "Cliquez pour  modifier une arrivée");
            
            fill();

            BS_Arrive.Position = 0;

            trouve_ReservClient();
            lien_Reservation();
            lien_De();
            lien_Arrive();
            lien_Client();


        }

        //rempli les tables
        private void fill()
        {
            this.TA_De.Fill(this.DataSet_Arrivee.De);
            this.TA_Reservation.Fill(this.DataSet_Arrivee.Reservation);
            this.TA_Client.Fill(this.DataSet_Arrivee.Client);
            this.TA_Chambre.Fill(this.DataSet_Arrivee.Chambre);
            this.TA_TypeCham.Fill(this.DataSet_Arrivee.TypeCham);
            this.TA_Arrive.Fill(this.DataSet_Arrivee.Arrive);
        }

        private void lien_Arrive()
        {
            txtBox_IdReser.DataBindings.Add("Text", BS_Arrive, "IdReser");

            txtBox_IdCli_Arrive.DataBindings.Add("Text", BS_Arrive, "IdCli");
            txtBox_IdArrive.DataBindings.Add("Text", BS_Arrive, "IdArrive");

            txtBox_NumCham.DataBindings.Add("Text", BS_Arrive, "NoCHam");

        }

        private void lien_Reservation()
        {
            this.BS_Reser.DataMember = "Reservation";
            this.BS_Reser.DataSource = this.DataSet_Arrivee;


            date_ReserDebut.DataBindings.Add("Value", BS_Reser, "DateDebut");
            date_ReserFin.DataBindings.Add("Value", BS_Reser, "DateFin");
            txtBox_IdCli_Reser.DataBindings.Add("Text", BS_Reser, "IdCli");
            date_DateReser.DataBindings.Add("Value", BS_Reser, "DateReser");


        }

        private void lien_Client()
        {
            txtBox_Nom_Arrive.DataBindings.Add("Text", BS_Client, "Nom");
            txtBox_Adresse.DataBindings.Add("Text", BS_Client, "Adresse");
            //txtBox_Telephone.DataBindings.Add("Text", BS_Client, "Telephone");
            txtBox_Telephone.Text = String.Format("{0:(###) ###-####}",
                    Convert.ToInt64(DataSet_Arrivee.Tables["Reservation"].Rows[BS_Reser.Position].GetParentRow("FK_RESCLI")["Telephone"].ToString()));
        }

        private void trouve_ReservClient()
        {
            try
            {
                BS_Reser.Position = BS_Reser.Find("IdReser", DataSet_Arrivee.Tables["Arrive"].Rows[BS_Arrive.Position]["IdReser"]);

                BS_Client.Position = BS_Client.Find("IdCli", DataSet_Arrivee.Tables["Arrive"].Rows[BS_Arrive.Position]["IdCli"]);

            }
            catch(Exception) { }
        }

        private void lien_De()
        {
            DataSet_Arrivee.Tables["De"].Columns.Add("DesTyp", typeof(String));
            DataSet_Arrivee.Tables["De"].Columns.Add("Prix", typeof(Decimal));

            BS_De.Position = 0;
            //' pour initialiser les valeurs des nouvelles colonnes 

            String codtypcham1;
            foreach (DataRow Dtr_De in DataSet_Arrivee.Tables["De"].Rows)
            {
                codtypcham1 = DataSet_Arrivee.Tables["De"].Rows[BS_De.Position].GetParentRow("FK_DECHAM")["CodTypCham"].ToString();

                BS_TypeCham.Position = BS_TypeCham.Find("CodTypCham", codtypcham1);

                DataSet_Arrivee.Tables["De"].Rows[BS_De.Position]["DesTyp"] = DataSet_Arrivee.Tables["TYPECHAM"].Rows[BS_TypeCham.Position]["DescTyp"];

                DataSet_Arrivee.Tables["De"].Rows[BS_De.Position]["Prix"] = DataSet_Arrivee.Tables["De"].Rows[BS_De.Position].GetParentRow("FK_DECHAM")["Prix"];

                BS_De.Position += 1;


            }
            DataSet_Arrivee.Tables["De"].AcceptChanges();

            BS_De.Position = 0;

            try
            {
                BS_De.Position = 0;
                this.BS_De.DataSource = BS_Reser;
                this.BS_De.DataMember = "FK_DERES";
                DGV_Arrivee.DataSource = BS_De;

            }
            catch (Exception) { }
        }        

        private void btn_next1_Click(object sender, EventArgs e)
        {
            BS_Arrive.MoveNext();
        }

        private void btn_previous1_Click(object sender, EventArgs e)
        {
            BS_Arrive.MovePrevious();
        }

        private void txtBox_IdArrive_TextChanged(object sender, EventArgs e)
        {
            trouve_ReservClient();
            txtBox_Nom_Reser.Text = DataSet_Arrivee.Tables["Reservation"].Rows[BS_Reser.Position].GetParentRow("FK_RESCLI")["Nom"].ToString();
            try
            {
                this.DGV_Arrivee.Sort(DGV_Arrivee.Columns["attribueeDataGridViewTextBoxColumn"], ListSortDirection.Descending);
            }
            catch (Exception) { }
        }

        private void onNonImplemented(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction n'est pas encore implémentée.", "Impossible d'accèder à votre requette!");
        }

    }
}
