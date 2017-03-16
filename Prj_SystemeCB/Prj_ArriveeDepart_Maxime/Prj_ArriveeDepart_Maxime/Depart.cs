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
            this.departTableAdapter.Fill(this.dataSet_Depart.Depart);

        }
    }
}
