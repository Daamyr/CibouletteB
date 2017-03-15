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
        private ListeChambre listechambre;

        public Chambre()
        {
            InitializeComponent();
        }

        private void Chambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Chambre.Ayant' table. You can move, or remove it, as needed.
            Fill();
            Lien_Chambre();
            FKType();
            FKLocalisation();
            Lien_Ayant();
            listechambre = new ListeChambre();
            listechambre._DataGridView_ListeChambre.DataSource = BS_Chambre;
        }
        private void Fill()
        {
            try { this.TA_Ayant.Fill(this.dataSet_Chambre.Ayant); }
            catch (Exception ee) {
                MessageBox.Show(ee.Message);
            }
            this.TA_Chambre.Fill(this.dataSet_Chambre.Chambre);
            this.TA_TypeChambre.Fill(this.dataSet_Chambre.TypeCham);
            this.TA_Localisation.Fill(this.dataSet_Chambre.Localisation);
            this.TA_Commodite.Fill(this.dataSet_Chambre.Commodite);

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

        private void Lien_Ayant()
        {

            dataSet_Chambre.Tables["Ayant"].Columns.Add("DescCom", typeof(String));

            BS_Ayant.Position = 0;

            foreach (DataRow Dtr_Ayant in dataSet_Chambre.Tables["Ayant"].Rows)
            {
                try
                {
                    dataSet_Chambre.Tables["Ayant"].Rows[BS_Ayant.Position]["DescCom"] = dataSet_Chambre.Tables["Ayant"].Rows[BS_Ayant.Position].GetParentRow("FK_AYANTCOM")["DescCom"].ToString();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                BS_Ayant.Position++;
            }
            this.BS_Ayant.DataSource = this.BS_Chambre;
            BS_Ayant.DataMember = "FK_AYANTCHAM";
            DGV_Chambre.DataSource = BS_Ayant;
        }

        private void FKType()
        {
            this.BS_TypeChambre.DataMember = "TypeCham";
            this.BS_TypeChambre.DataSource = this.dataSet_Chambre;


            this.TextBox_TypeChambre.Text = dataSet_Chambre.Tables["Chambre"].Rows[BS_Chambre.Position].GetParentRow("FK_CHAMTYP")["CodTypCham"].ToString();
            this.TextBox_DescChambre.Text = dataSet_Chambre.Tables["Chambre"].Rows[BS_Chambre.Position].GetParentRow("FK_CHAMTYP")["DescTyp"].ToString();

        }

        private void FKLocalisation()
        {
            this.BS_Localisation.DataMember = "Localisation";
            this.BS_Localisation.DataSource = this.dataSet_Chambre;
            this.TextBox_LocChambre.Text = dataSet_Chambre.Tables["Chambre"].Rows[BS_Chambre.Position].GetParentRow("FK_CHAMLOC")["CodLoc"].ToString();
            this.TextBox_DescLocCham.Text = dataSet_Chambre.Tables["Chambre"].Rows[BS_Chambre.Position].GetParentRow("FK_CHAMLOC")["DescLoc"].ToString();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            BS_Chambre.MoveNext();
            FKType();
            FKLocalisation();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            BS_Chambre.MovePrevious();
            FKType();
            FKLocalisation();
        }


        private void TextBox_NoCham_DoubleClick(object sender, EventArgs e)
        {
            int oldposition = BS_Chambre.Position;
            if (listechambre.ShowDialog() != DialogResult.OK)
                BS_Chambre.Position = oldposition;
            FKType();
            FKLocalisation();
        }

        private void btn_add1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("fonctionnalité en création");
            
        }

        private void btn_delete1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("fonctionnalité en création");
        }

        private void btn_edit1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("fonctionnalité en création");
        }
    }
}
