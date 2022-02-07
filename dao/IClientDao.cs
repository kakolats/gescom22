﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dao
{
    interface IClientDao:IDao<Client>
    {
        int addClient(Client client);
        Client findClientById(int id);
    }
}
