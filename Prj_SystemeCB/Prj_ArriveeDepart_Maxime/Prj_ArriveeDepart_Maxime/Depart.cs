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
            // TODO: This line of code loads data into the 'dataSet_Depart.Depart' table. You can move, or remove it, as needed.
            fill();
            BS_Arrive.Position = 0;
        }

        private void fill()
        {
            this.TA_Depart.Fill(this.dataSet_Depart.Depart);
            this.TA_Arrive.Fill(this.dataSet_Depart.Arrive);
            this.TA_Client.Fill(this.dataSet_Depart.Client);
            this.TA_Reser.Fill(this.dataSet_Depart.Reservation);
        }

        private void btn_next1_Click(object sender, EventArgs e)
        {
            BS_Depart.MoveNext();
        }

        private void btn_previous1_Click(object sender, EventArgs e)
        {
            BS_Depart.MovePrevious();
        }
    }
}
