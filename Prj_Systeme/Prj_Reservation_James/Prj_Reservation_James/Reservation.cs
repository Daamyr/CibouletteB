using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prj_Reservation_James
{
    public partial class Reservation : Prj_lib_graphique.Form1
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            Fill();
            Lien_Res();
            FKClient();
        }

        private void Fill()
        {
            // TODO: This line of code loads data into the 'CBDataSet.Chambre' table. You can move, or remove it, as needed.
            this.TA_Cham.Fill(this.CBDataSet.Chambre);
            // TODO: This line of code loads data into the 'cBDataSet.Reservation' table. You can move, or remove it, as needed.
            this.TA_Res.Fill(this.CBDataSet.Reservation);
            // TODO: This line of code loads data into the 'CBDataSet.Client' table. You can move, or remove it, as needed.
            this.TA_Client.Fill(this.CBDataSet.Client);
        }

        private void Lien_Res()
        {
            this.BS_Res.DataMember = "Reservation";
            this.BS_Res.DataSource = this.CBDataSet;
            this.TextBox_NoRes.DataBindings.Add("Text", BS_Res, "IdReser");
            this.TextBox_ResLe.DataBindings.Add("Text", BS_Res, "DateReser");
            this.TextBox_Debut.DataBindings.Add("Text", BS_Res, "DateDebut");
            this.TextBox_Fin.DataBindings.Add("Text", BS_Res, "DateFin");
        }

        private void FKClient()
        {
            this.TextBox_IdCli.Text     = CBDataSet.Tables["Reservation"].Rows[BS_Client.Position].GetParentRow("FK_RESCLI")["IdCli"].ToString();
            this.TextBox_Nom.Text       = CBDataSet.Tables["Reservation"].Rows[BS_Client.Position].GetParentRow("FK_RESCLI")["Nom"].ToString();
            this.TextBox_Adresse.Text   = CBDataSet.Tables["Reservation"].Rows[BS_Client.Position].GetParentRow("FK_RESCLI")["Adresse"].ToString();
            this.TextBox_Telephone.Text = String.Format("{0:(###) ###-####}", Convert.ToInt64(CBDataSet.Tables["Reservation"].Rows[BS_Client.Position].GetParentRow("FK_RESCLI")["Telephone"].ToString()));
            this.TextBox_TypeCarte.Text = CBDataSet.Tables["Reservation"].Rows[BS_Client.Position].GetParentRow("FK_RESCLI")["TypeCarte"].ToString();
            this.TextBox_DateExp.Text   = CBDataSet.Tables["Reservation"].Rows[BS_Client.Position].GetParentRow("FK_RESCLI")["DateExp"].ToString();
            //this.TextBox_Fax.Text     = CBDataSet.Tables["Reservation"].Rows[BS_Client.Position].GetParentRow("FK_RESCLI")["Fax"].ToString();
            this.TextBox_Solde_Du.Text  = CBDataSet.Tables["Reservation"].Rows[BS_Client.Position].GetParentRow("FK_RESCLI")["Solde_Du"].ToString();
        }
    }
}
