using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void onNonImplemented(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction n'est pas encore implémentée.", "Impossible d'accèder à votre requette!");
        }
    }
}
