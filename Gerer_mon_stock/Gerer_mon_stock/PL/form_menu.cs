using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerer_mon_stock.PL
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
            pan_parametre.Visible = false;
            panel1.Size = new Size(93, 563);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pan_btn.Top = btn_client.Top;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 245)
            {
                panel1.Size = new Size(93, 563);
            }
            else
            {
                panel1.Size = new Size(245, 563);
            }
        }

        private void btn_produit_Click(object sender, EventArgs e)
        {
            pan_btn.Top = btn_produit.Top;
        }

        private void btn_categorie_Click(object sender, EventArgs e)
        {
            pan_btn.Top = btn_categorie.Top;
        }

        private void btn_commande_Click(object sender, EventArgs e)
        {
            pan_btn.Top = btn_commande.Top;
        }

        private void btn_utilisateur_Click(object sender, EventArgs e)
        {
            pan_btn.Top = btn_utilisateur.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pan_parametre.Size = new Size(371, 208);
            pan_parametre.Visible = !pan_parametre.Visible;
        }
    }
}
