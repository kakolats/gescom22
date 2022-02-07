using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dao
{
    public interface IProduitDao : IDao<Produit>
    {
        int addProduit(Produit produit);
        int updateProduit(int idProd, int stockM);
        int deleteProduit(int idProduit);
        List<Produit> showAllProduit();
        Produit findProduitById(int id);
    }
}
