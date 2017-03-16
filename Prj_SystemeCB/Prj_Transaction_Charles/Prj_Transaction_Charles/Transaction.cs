using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prj_Transaction_Charles
{
    public partial class Transaction : Prj_lib_graphique.Form1
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

            System.Windows.Forms.ToolTip tooltip_Add = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip tooltip_Delete = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip tooltip_Edit = new System.Windows.Forms.ToolTip();
            tooltip_Add.SetToolTip(this.btn_add, "Cliquez pour ajouter une transaction");
            tooltip_Delete.SetToolTip(this.btn_delete, "Cliquez pour supprimer une transaction");
            tooltip_Edit.SetToolTip(this.btn_edit, "Cliquez pour  modifier une transaction");

            fill();
            lien_Trx();
            lien_Reserve();
            lien_Client();
            lien_Chambre();
            totalTrx();
        }

        private void lien_Reserve()
        {

            try
            {
                BS_Trx.Position = 0;
                this.BS_Trx.DataSource = BS_Reserve;
                this.BS_Trx.DataMember = "FK_TRXRES";
                DGV_Trx.DataSource = BS_Trx;
            }
            catch (Exception) { }

            txtBox_noReserve.DataBindings.Add("Text", BS_Reserve, "IdReser");         //.. no reservation
            txtBox_numCli.DataBindings.Add("Text", BS_Reserve, "IdCli");             //.. numero client 
            txtBox_dateReserve.DataBindings.Add("Text", BS_Reserve, "DateReser");   //.. date reserve
            txtBox_dateStart.DataBindings.Add("Text", BS_Reserve, "DateDebut");    //.. date debut
            txtBox_dateEnd.DataBindings.Add("Text", BS_Reserve, "DateFin");       //.. date fin
        }

        private void lien_Client()
        {
            //txtBox_nameCli.Text = DataSet_Transaction.Tables["Trx"].Rows[BS_Trx.Position].GetParentRow("FK_TRXCLI")["Nom"].ToString();        //.. nom client
            //txtBox_phone.Text = String.Format("{0:(###) ###-####}", Convert.ToInt64(DataSet_Transaction.Tables["Trx"].Rows[BS_Trx.Position].GetParentRow("FK_TRXCLI")["Telephone"].ToString())); //.. telephone

            txtBox_nameCli.DataBindings.Add("Text", BS_Cli, "Nom");
            txtBox_phone.DataBindings.Add("Text", BS_Cli, "Telephone");
        }

        private void lien_Chambre()
        {
            //txtBox_roomNum.Text = DataSet_Transaction.Tables["Trx"].Rows[BS_Trx.Position].GetParentRow("FK_TRXCHAM")["NoCham"].ToString();     //.. numéro chambre
            txtBox_roomNum.DataBindings.Add("Text", BS_Trx, "NoCham");
        }

        private void lien_Trx()
        {
            DataSet_Transaction.Tables["Trx"].Columns.Add("Description", typeof(String));
            BS_Trx.Position = 0;
            foreach (DataRow Dtr_Trx in DataSet_Transaction.Tables["Trx"].Rows)
            {
                
                    DataSet_Transaction.Tables["Trx"].Rows[BS_Trx.Position]["Description"] = DataSet_Transaction.Tables["Trx"].Rows[BS_Trx.Position].GetParentRow("FK_TRXTYP")["DescTrx"];
                
                
                BS_Trx.Position++;
            }
            DataSet_Transaction.Tables["Trx"].AcceptChanges();

            BS_Trx.Position = 0;
        }
                

        private void totalTrx()
        {
            double result = 0;
            foreach (DataGridViewRow total in DGV_Trx.Rows)
            {
                result += Convert.ToDouble(total.Cells["dataGridViewTextBoxColumn3"].Value);
            }

            txtBox_tot.Text = result.ToString() + " $";
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            BS_Reserve.MovePrevious();
            totalTrx();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            BS_Reserve.MoveNext();
            totalTrx();
        }

        private void fill()
        {
            this.TA_Client.Fill(this.DataSet_Transaction.Client);
            this.TA_Trx.Fill(this.DataSet_Transaction.Trx);
            this.TA_Chambre.Fill(this.DataSet_Transaction.Chambre);
            this.TA_Reserve.Fill(this.DataSet_Transaction.Reservation);
            this.TA_TypeTrx.Fill(this.DataSet_Transaction.TypeTrx);
        }

        private void onNonImplemented(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction n'est pas encore implémentée.", "Impossible d'accèder à votre requette!");
        }

        private void onIdCliChanged(object sender, EventArgs e)
        {
            //txtBox_nameCli.Text = DataSet_Transaction.Tables["Trx"].Rows[BS_Trx.Position].GetParentRow("FK_TRXCLI")["Nom"].ToString();        //.. nom client
            //txtBox_phone.Text = String.Format("{0:(###) ###-####}", Convert.ToInt64(DataSet_Transaction.Tables["Trx"].Rows[BS_Trx.Position].GetParentRow("FK_TRXCLI")["Telephone"].ToString())); //.. telephone

            BS_Cli.Position = BS_Cli.Find("IdCli", Convert.ToInt64(txtBox_numCli.Text));
        }
    }        
}
