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
    public partial class ListeChambre : Form
    {
        public ListeChambre()
        {
            InitializeComponent();
        }

        private void ListeChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Chambre.Chambre' table. You can move, or remove it, as needed.
            this.chambreTableAdapter.Fill(this.dataSet_Chambre.Chambre);

        }

        public DataGridView _DataGridView_ListeChambre
        {
            get
            {
                return DGV_ListeChambre;
            }

            set
            {
                DGV_ListeChambre = value;
            }
        }

    }
}
