using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prj_Chambre_Janie
{
    public partial class Chambre : Prj_lib_graphique.Form1
    {
        public Chambre()
        {
            InitializeComponent();
        }

        private void Chambre_Load(object sender, EventArgs e)
        {
            Fill();
            Lien_Chambre();
        }
        private void Fill()
        {
            this.TA_Chambre.Fill(this.dataSet_Chambre.Chambre);
        }
        private void Lien_Chambre()
        {
            this.BS_Chambre.DataMember = "Chambre";
            this.BS_Chambre.DataSource = this.dataSet_Chambre;
            this.TextBox_NoCham.DataBindings.Add("Text", BS_Chambre, "NoCham");
            this.TextBox_Etage.DataBindings.Add("Text", BS_Chambre, "Etage");
            this.TextBox_Etat.DataBindings.Add("Text", BS_Chambre, "Etat");
            this.TextBox_Memo.DataBindings.Add("Text", BS_Chambre, "Memo");
            this.TextBox_Prix.DataBindings.Add("Text", BS_Chambre, "Prix");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
