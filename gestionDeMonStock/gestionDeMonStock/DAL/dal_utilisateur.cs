using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDeMonStock.DAL
{
    public class dal_utilisateur
    {
        public dbStockContext database;
        User user;
        public dal_utilisateur()
        {
            database = new dbStockContext();
            user = new User();
        }
        public bool connexionIsValide( string nom, string motPasse)
        {
            user.mot_de_passe = motPasse;
            user.nom_utilisateur = nom;

            //si le nom et le mot de passe entré dans le formulaire de connexion correspondent à une
            ////paire de nom et mot de passe présent dans labase de données
            if (database.Users.SingleOrDefault(s => s.nom_utilisateur == nom && s.mot_de_passe == motPasse) != null)
            {
                return true;
            }
            //si ça ne correspond pas
            else
            {
                return false;
            }
        }
    }
}
