using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDeMonStock.BL
{
    public class class_connexion
    {
        //fonction pour verifier la connexion
        public bool connexionIsValide(dbStockContext db, string nom, string motPasse)
        {
            User user = new User();
            user.mot_de_passe = motPasse;
            user.nom_utilisateur = nom;

            //si le nom et le mot de passe entré dans le formulaire de connexion correspondent à une
            ////paire de nom et mot de passe présent dans labase de données
            if(db.Users.SingleOrDefault(s=>s.nom_utilisateur == nom && s.mot_de_passe == motPasse)!= null)
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
