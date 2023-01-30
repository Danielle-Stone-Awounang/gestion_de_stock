using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDeMonStock.DAL
{
    public class dal_client
    {
        public dbStockContext data { get; set; }
        public Client client { get; set; }

        public dal_client()
        {
            data = new dbStockContext();
            client = new Client();
        }
        public List<Client> GetClients()
        {
            return data.Clients.ToList();
        }
        public void addClient(Client client)
        {
            this.client = data.Clients.Add(client);
            data.SaveChanges();
        }
        public bool exist(string email)
        {
            List<Client> clients = GetClients();
            List<Client> newClients = clients.FindAll(delegate (Client client)
            {
                return client.email_client == email;
            });
            return newClients.Count > 0 ? true:false;

            //if(data.Clients.SingleOrDefault(s => s.email_client == email) == null){
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
