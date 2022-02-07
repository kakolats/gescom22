using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dao
{
    interface ICategorieDao:IDao<Categorie>
    {
        List<Categorie> showAllCategories();
    }
}
