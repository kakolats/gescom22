using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dao
{
    class DetailsCommandeDao : IDetailsCommande
    {
        GesDataContainer data = new GesDataContainer();
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public DetailsCommande findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(DetailsCommande obj)
        {
            throw new NotImplementedException();
        }

        public List<DetailsCommande> showDetailsCommandeByIdCommande(int idCat)
        {
            return data.DetailCommande.Where(d => d.Commande.Id == idCat).ToList();
        }

        public int update(DetailsCommande obj)
        {
            throw new NotImplementedException();
        }
    }
}
