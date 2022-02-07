using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dao
{
    interface IUserDao:IDao<User>
    {
        List<User> findAllLivreurs();
        User findUserByLoginPassword(string login, string password);
    }
}
