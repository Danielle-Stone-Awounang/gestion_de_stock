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
    public partial class form_connexion : Form
    {
        public form_connexion()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //quitons du formulaire
            this.Close();
        }

        private void txt_nom_user_Enter(object sender, EventArgs e)
        {
            if (txt_nom_user.Text == "Nom d'utilisateur")
            {
                txt_nom_user.Text = "";
                txt_nom_user.ForeColor = Color.White;
            }
            else if (txt_nom_user.Text == "")
            {
                txt_nom_user.Text = "Nom d'utilisateur";
                txt_nom_user.ForeColor = Color.Silver;
            }
        }

        private void txt_mot_de_passe_Enter(object sender, EventArgs e)
        {
            if (txt_mot_de_passe.Text == "Mot de passe")
            {
                txt_mot_de_passe.Text = "";
                txt_mot_de_passe.ForeColor = Color.White;
            }
            else if(txt_mot_de_passe.Text == "")
            {
                txt_mot_de_passe.Text = "Mot de passe";
                txt_mot_de_passe.ForeColor = Color.Silver;
            }
        }
    }
}
