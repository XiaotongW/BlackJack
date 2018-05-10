using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partie
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNbPaquet_KeyPress(object sender, KeyPressEventArgs e)
        {
            int indInt = 2;
            bool trouver = false;
            if (int.TryParse(txtNbPaquet.Text, out int NbPaquet))
            {
                while ((indInt != NbPaquet && indInt < 10) || trouver == false)
                {
                    if (indInt == NbPaquet)
                    {
                        txtNbPaquet.Text = NbPaquet.ToString();
                        trouver = true;
                    }

                    indInt++;
                }
                MessageBox.Show("Veuiller entrer un chiffre de 2 à 9");
            }
            else
            {
                MessageBox.Show("Veuiller entrer un chiffre de 2 à 9");
            }
        }

        private void txtArgent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (int.TryParse(txtArgent.Text, out int NbArgent))
            {
                txtArgent.Text = NbArgent.ToString();
            }
            else
            {
                txtArgent.Text = "";
                MessageBox.Show("Veuiller entrer un nombre");
            }
        }

        private void txtMiseMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (int.TryParse(txtMiseMin.Text, out int NbMiseMin))
            {
                txtMiseMin.Text = NbMiseMin.ToString();
            }
            else
            {
                txtArgent.Text = "";
                MessageBox.Show("Veuiller entrer un nombre");
            }
        }

        private void txtMiseMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (int.TryParse(txtMiseMax.Text, out int NbMiseMax))
            {
                txtMiseMax.Text = NbMiseMax.ToString();
            }
            else
            {
                txtArgent.Text = "";
                MessageBox.Show("Veuiller entrer un nombre");
            }
        }
    }
}
