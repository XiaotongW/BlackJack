using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
   public partial class MenuPartie : Form
   {
      public MenuPartie()
      {
         InitializeComponent();
      }

        private void button2_Click(object sender, EventArgs e)
        {
            lblNom.Visible = true;
            txtNom.Visible = true;
            btnCreer.Visible = true;
            btnRejoindre.Visible = true;
            txtIP.Visible = false;
            btnConnection.Visible = false;
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            lblNom.Visible = false;
            txtNom.Visible = false;
            btnCreer.Visible = false;
            btnRejoindre.Visible = false;
            cmbJoueur.Visible = true;
            btnHeberger.Visible = true;
            btnOption.Visible = true;
        }

        private void btnHeberger_Click(object sender, EventArgs e)
        {
            lblNom.Visible = true;
            txtNom.Visible = true;
            btnCreer.Visible = true;
            btnRejoindre.Visible = true;
            cmbJoueur.Visible = false;
            btnHeberger.Visible = false;
        }

        private void btnRejoindre_Click(object sender, EventArgs e)
        {
            lblNom.Visible = false;
            txtNom.Visible = false;
            btnCreer.Visible = false;
            btnRejoindre.Visible = false;
            txtIP.Visible = true;
            btnConnection.Visible = true;
        }
    }
}
