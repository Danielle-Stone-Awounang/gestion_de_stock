using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestionDeMonStock.Vues;

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

        //desactiver le formulaire
        void desactiverForm()
        {
            btn_client.Enabled = false;
            btn_produit.Enabled = false;
            btn_commande.Enabled = false;
            btn_categorie.Enabled = false;
            btn_utilisateur.Enabled = false;
            btn_connecter.Enabled = true;
            btn_copier.Enabled = false;
            btn_restaurer.Enabled = false;
            btn_deconnecter.Enabled = false;
            panelBtn.Enabled = false;
        }

        //activer le formulaire
        public void activerForm()
        {
            btn_client.Enabled = true;
            btn_produit.Enabled = true;
            btn_commande.Enabled = true;
            btn_categorie.Enabled = true;
            btn_utilisateur.Enabled = true;
            btn_connecter.Enabled = false;
            btn_copier.Enabled = true;
            btn_restaurer.Enabled = true;
            btn_deconnecter.Enabled = true;
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
            if (!panelAfficher.Controls.Contains(user_liste_client.instance))
            {
                panelAfficher.Controls.Add(user_liste_client.instance);
                user_liste_client.instance.Dock = DockStyle.Fill;
                user_liste_client.instance.BringToFront();
            }
            else
            {
                user_liste_client.instance.BringToFront();
            }
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
            form_connexion connect = new form_connexion(this);
            connect.ShowDialog();
        }

        private void form_menu_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void btn_deconnecter_Click(object sender, EventArgs e)
        {
            desactiverForm();
        }
    }
}
