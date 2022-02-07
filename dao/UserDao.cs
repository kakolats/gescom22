using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dao
{
    class UserDao : IUserDao
    {
        GesDataContainer data = new GesDataContainer();
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> findAllLivreurs()
        {
            return data.User.Where(r => r.Role == "ROLE_LIVREUR").ToList();
        }

        public User findById(int id)
        {
            throw new NotImplementedException();
        }

        public User findUserByLoginPassword(string login, string password)
        {
            throw new NotImplementedException();
        }

        public int insert(User obj)
        {
            throw new NotImplementedException();
        }

        public int update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
