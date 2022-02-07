using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dao
{
    class ClientDao : IClientDao
    {
        GesDataContainer data = new GesDataContainer();
        public int addClient(Client client)
        {
            throw new NotImplementedException();
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public Client findById(int id)
        {
            return (Client)data.User.Where(u => u.Id == id).FirstOrDefault();
        }

        public Client findClientById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(Client client)
        {
            data.User.Add(client);
            return data.SaveChanges();
        }

        public int update(Client obj)
        {
            throw new NotImplementedException();
        }
    }
}
