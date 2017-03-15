using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Chambre_Janie
{
    public partial class ListeLocalisation : Form
    {
        public ListeLocalisation()
        {
            InitializeComponent();
        }

        private void ListeLocalisation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Chambre.Localisation' table. You can move, or remove it, as needed.
            this.TA_Localisation.Fill(this.dataSet_Chambre.Localisation);

        }
    }
}
