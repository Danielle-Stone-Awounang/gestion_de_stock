using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionDeMonStock.DAL;

namespace gestionDeMonStock.Services
{
    public class service_client
    {
        public Client Client { get; set; }
        dal_client dalClient;

        public service_client()
        {
            dalClient = new dal_client();
            Client = new Client();
        }
        public void save(Client client)
        {
            if (!dalClient.exist(client.email_client))
            {
                dalClient.addClient(client);
            }
            else
            {
                throw new Exception("L'email que vous voulez ajouter existe déjà!");
            }

        }
    }
}
