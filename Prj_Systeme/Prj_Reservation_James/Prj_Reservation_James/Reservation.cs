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

        private void reservationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BS_Res.EndEdit();
            this.TA_Res.UpdateAll(this.CBDataSet);

        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cBDataSet.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.CBDataSet.Reservation);

            Lien_Res();
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
    }
}
