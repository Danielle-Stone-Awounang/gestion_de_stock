using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionDeMonStock
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
            panel_menu.Size = new Size(83, 788);
            panelParametre.Visible = false;
        }

        private void btn_produit_Click(object sender, EventArgs e)
        {
            panelBtn.Top = btn_produit.Top;
        }

        private void btn_categorie_Click(object sender, EventArgs e)
        {
            panelBtn.Top = btn_categorie.Top;
        }

        private void btn_commande_Click(object sender, EventArgs e)
        {
            panelBtn.Top = btn_commande.Top;
        }

        private void btn_utilisateur_Click(object sender, EventArgs e)
        {
            panelBtn.Top=btn_utilisateur.Top;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (panel_menu.Width == 247)
            {
                panel_menu.Size = new Size(83, 788);
            }
            else
            {
                panel_menu.Size = new Size(247, 788);
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            panelBtn.Top = btn_client.Top;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_parametre_Click(object sender, EventArgs e)
        {
            panelParametre.Size = new Size(400, 202);
            panelParametre.Visible = !panelParametre.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_connexion connect = new form_connexion();
            connect.ShowDialog();
        }
    }
}
