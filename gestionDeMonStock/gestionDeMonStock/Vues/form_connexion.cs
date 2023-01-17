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
    public partial class form_connexion : Form
    {
        public dbStockContext db;
        BL.class_connexion conn = new BL.class_connexion();
        private Form formMenu;
        public form_connexion(Form menu)
        {
            InitializeComponent();
            db = new dbStockContext();
            formMenu = menu;
        }

        //verifier les champs obligatoires
        string testObligatoire()
        {
            if (txt_nom_utilisateur.Text == "" || txt_nom_utilisateur.Text == "Nom d'utilisateur")
            {
                return "Entrez un nom d'utilisateur!";
            }
            else if(txt_mot_de_passe.Text == "" || txt_mot_de_passe.Text == "Mot de passe")
            {
                return "Entrer un mot de passe!";
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
            if (txt_nom_utilisateur.Text == "Nom d'utilisateur")
            {
                txt_nom_utilisateur.Text = "";
                txt_nom_utilisateur.ForeColor = Color.White;
            }
        }

        private void txt_mot_de_passe_Enter(object sender, EventArgs e)
        {
            if (txt_mot_de_passe.Text == "Mot de passe")
            {
                txt_mot_de_passe.Text = "";
                txt_mot_de_passe.UseSystemPasswordChar = false;
                txt_mot_de_passe.PasswordChar = '*';
                txt_mot_de_passe.ForeColor = Color.White;
            }
        }

        private void txt_nom_utilisateur_Leave(object sender, EventArgs e)
        {
            if(txt_nom_utilisateur.Text == "")
            {
                txt_nom_utilisateur.Text = "Nom d'utilisateur";
                txt_nom_utilisateur.ForeColor = Color.Silver;
            }
        }

        private void txt_mot_de_passe_Leave(object sender, EventArgs e)
        {
            if(txt_mot_de_passe.Text == "")
            {
                txt_mot_de_passe.ForeColor= Color.Silver;
                txt_mot_de_passe.Text = "Mot de passe";
                txt_mot_de_passe.UseSystemPasswordChar =true;
            }
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            if(testObligatoire() == null)
            {
               if(conn.connexionIsValide(db,txt_nom_utilisateur.Text,txt_mot_de_passe.Text) == true)
                {
                    MessageBox.Show("connexion réussit","connexion",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    (formMenu as form_menu).activerForm();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("connexion échoué!", "connexion", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(testObligatoire(),"obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
