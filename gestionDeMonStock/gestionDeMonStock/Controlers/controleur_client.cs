using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestionDeMonStock.Services;

namespace gestionDeMonStock.Controlers
{
    public class controleur_client
    {
        public service_client serviceClient;
        public Client client;

        public controleur_client()
        {
            serviceClient = new service_client();
            client = new Client();
        }

        public Client save(string nom, string prenom, string adresse, string tel, string email, string pays, string ville)
        {
            //try
            //{
                serviceClient.save(client);
                return client;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}

        }
    }
}
