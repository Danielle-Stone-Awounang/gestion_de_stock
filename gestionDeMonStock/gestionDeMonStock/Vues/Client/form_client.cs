using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestionDeMonStock.Controlers;
using System.Net.Mail;

namespace gestionDeMonStock
{
    public partial class form_client : Form
    {
        public controleur_utilisateur controleurUtilisateur;
        public controleur_client controlerClient;
        public form_client()
        {
            InitializeComponent();
            controleurUtilisateur = new controleur_utilisateur();
            controlerClient = new controleur_client();
        }

        //verifier les champs obligatoires
        string testObligatoire()
        {
            if (txt_nom.Text == "" || txt_nom.Text == "Nom du client")
            {
                return "Entrez le nom du client!";
            }
            else if(txt_prenom.Text == "" || txt_prenom.Text == "Prenom du client")
            {
                return "Entrer le prenom du client!";
            }
            else if(richtxt_adresse.Text == "" || richtxt_adresse.Text == "Adresse du client")
            {
                return "Entrer l'adresse du client";
            }
            else if (txt_pays.Text == "" || txt_pays.Text == "Pays du client")
            {
                return "Entrer le pays du client";
            }
            else if(txt_tel.Text == "" || txt_tel.Text == "Téléphone du client")
            {
                return "Entrer le téléphone du client";
            }
            else if(txt_email.Text == "" || txt_email.Text == "Email du client")
            {
                return "Entrer l'email du client";
            }
            else if (txt_ville.Text == "" || txt_ville.Text == "Ville du client")
            {
                return "Entrer la ville d'un client";
            }
            else if(txt_email.Text !="" || txt_email.Text != "Email du client")
            {
                try
                {
                    new MailAddress(txt_email.Text);
                    return null;
                }catch(Exception e)
                {
                    return "Email invalide";
                }
            }
            else
            {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_nom_utilisateur_Enter(object sender, EventArgs e)
        {
            if (txt_nom.Text == "Nom du client")
            {
                txt_nom.Text = "";
                txt_nom.ForeColor = Color.White;
            }
        }

        private void txt_nom_utilisateur_Leave(object sender, EventArgs e)
        {
            if(txt_nom.Text == "")
            {
                txt_nom.Text = "Nom du client";
                txt_nom.ForeColor = Color.Silver;
            }
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            if(testObligatoire() == null)
            {
                Client client = controlerClient.save(txt_nom.Text,txt_prenom.Text,richtxt_adresse.Text,
                    txt_tel.Text,txt_email.Text,txt_pays.Text,txt_ville.Text);
                MessageBox.Show("Enregistrement réussit !", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(testObligatoire(),"obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richtxt_adresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void richtxt_adresse_Enter(object sender, EventArgs e)
        {
            if(richtxt_adresse.Text == "Adresse du client")
            {
                richtxt_adresse.Text = "";
                richtxt_adresse.ForeColor = Color.White;
            }
        }

        private void richtxt_adresse_Leave(object sender, EventArgs e)
        {
            if(richtxt_adresse.Text == "")
            {
                richtxt_adresse.Text = "Adresse du client";
                richtxt_adresse.ForeColor = Color.Silver;
            }
        }

        private void txt_pays_Enter(object sender, EventArgs e)
        {
            if(txt_pays.Text == "Pays du client")
            {
                txt_pays.Text = "";
                txt_pays.ForeColor = Color.White;
            }
        }

        private void txt_pays_Leave(object sender, EventArgs e)
        {
            if(txt_pays.Text == "")
            {
                txt_pays.Text = "Pays du client";
                txt_pays.ForeColor= Color.Silver;
            }
        }

        private void txt_prenom_Leave(object sender, EventArgs e)
        {
            if(txt_prenom.Text == "")
            {
                txt_prenom.Text = "Prenom du client";
                txt_prenom.ForeColor = Color.Silver;
            }
        }

        private void txt_prenom_Enter(object sender, EventArgs e)
        {
            if( txt_prenom.Text == "Prenom du client")
            {
                txt_prenom.Text = "";
                txt_prenom.ForeColor = Color.White;
            }
        }

        private void txt_tel_Enter(object sender, EventArgs e)
        {
            if(txt_tel.Text == "Télépone du client")
            {
                txt_tel.Text = "";
                txt_tel.ForeColor = Color.White;
            }
        }

        private void txt_tel_Leave(object sender, EventArgs e)
        {
            if(txt_tel.Text == "")
            {
                txt_tel.Text = "Télépone du client";
                txt_tel.ForeColor = Color.Silver;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if(txt_email.Text == "")
            {
                txt_email.Text = "Email du client";
                txt_email.ForeColor = Color.Silver;
            }
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if(txt_email.Text == "Email du client")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.White;
            }
        }

        private void txt_ville_Enter(object sender, EventArgs e)
        {
            if(txt_ville.Text == "ville du client")
            {
                txt_ville.Text = "";
                txt_ville.ForeColor = Color.White;
            }
        }

        private void txt_ville_Leave(object sender, EventArgs e)
        {
            if (txt_ville.Text == "")
            {
                txt_ville.Text = "ville du client";
                txt_ville.ForeColor = Color.Silver;
            }
        }

        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar <48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            else if(e.KeyChar == 8){
                e.Handled = false;
            }
        }

        private void btn_actualiser_Click(object sender, EventArgs e)
        {
            txt_nom.Text = "Nom du client"; txt_nom.ForeColor = Color.Silver;
            txt_prenom.Text = "Prenom du client"; txt_prenom.ForeColor = Color.Silver;
            richtxt_adresse.Text = "Adresse du client"; richtxt_adresse.ForeColor = Color.Silver;
            txt_pays.Text = "Pays du client"; txt_pays.ForeColor = Color.Silver;
            txt_tel.Text = "Téléphone du client"; txt_tel.ForeColor = Color.Silver;
            txt_email.Text = "Email du client"; txt_email.ForeColor = Color.Silver;
            txt_ville.Text = "Ville du client"; txt_ville.ForeColor = Color.Silver;
        }
    }
}
