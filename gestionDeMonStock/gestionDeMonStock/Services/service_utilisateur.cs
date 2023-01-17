using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionDeMonStock.DAL;

namespace gestionDeMonStock.Services
{
    public class service_utilisateur
    {
        public dal_utilisateur dalUtilisateur;
        public service_utilisateur()
        {
            dalUtilisateur = new dal_utilisateur();
        }

        //verifier connexion
        public bool connexionIsValide(string nom, string passwd)
        {
            return dalUtilisateur.connexionIsValide(nom, passwd);
        }
    }
}
