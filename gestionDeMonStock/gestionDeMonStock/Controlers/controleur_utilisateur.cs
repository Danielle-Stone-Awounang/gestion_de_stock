using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionDeMonStock.Services;

namespace gestionDeMonStock.Controlers
{
    public class controleur_utilisateur
    {
        public service_utilisateur serviceUtilisateur;

        public controleur_utilisateur()
        {
            serviceUtilisateur = new service_utilisateur();
        }

        public bool connexionIsValide(string Nom, string passwd)
        {
            return serviceUtilisateur.connexionIsValide(Nom, passwd);
        }
    }
}
