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
            fill();
            lienReserve();
            lienClient();
            lienChambre();
            totCashCalc();
        }

        private void lienReserve()
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
            txtBox_dateStart.DataBindings.Add("Text", BS_Reserve, "DateDebut");      //.. date debut
            txtBox_dateEnd.DataBindings.Add("Text", BS_Reserve, "DateFin");       //.. date fin
        }

        private void lienClient()
        {
            txtBox_nameCli.Text = dataSet_Transaction1.Tables["Trx"].Rows[BS_Trx.Position].GetParentRow("FK_TRXCLI")["Nom"].ToString();        //.. nom client
            txtBox_phone.Text = String.Format("{0:(###) ###-####}", Convert.ToInt64(dataSet_Transaction1.Tables["Trx"].Rows[BS_Trx.Position].GetParentRow("FK_TRXCLI")["Telephone"].ToString())); //.. telephone
        }

        private void lienChambre()
        {
            txtBox_roomNum.Text = dataSet_Transaction1.Tables["Trx"].Rows[BS_Trx.Position].GetParentRow("FK_TRXCHAM")["NoCham"].ToString();     //.. numéro chambre
        }

        private void totCashCalc()
        {
            double result = 0;
            foreach (DataGridViewRow tot in DGV_Trx.Rows)
            {
                result += Convert.ToDouble(tot.Cells["dataGridViewTextBoxColumn3"].Value);
            }

            txtBox_tot.Text = result.ToString() + " $";
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            BS_Reserve.MovePrevious();
            totCashCalc();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            BS_Reserve.MoveNext();
            totCashCalc();
        }

        private void fill()
        {
            this.TA_Client.Fill(this.dataSet_Transaction1.Client);
            this.TA_Trx.Fill(this.dataSet_Transaction1.Trx);
            this.TA_Chambre.Fill(this.dataSet_Transaction1.Chambre);
            this.TA_Reserve.Fill(this.dataSet_Transaction1.Reservation);
        }
    }        
}
