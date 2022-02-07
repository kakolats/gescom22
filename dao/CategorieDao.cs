using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dao
{
    class CategorieDao : ICategorieDao
    {
        GesDataContainer data = new GesDataContainer();
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public Categorie findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(Categorie obj)
        {
            throw new NotImplementedException();
        }

        public List<Categorie> showAllCategories()
        {
            return data.Categorie.ToList();
        }

        public int update(Categorie obj)
        {
            throw new NotImplementedException();
        }
    }
}
