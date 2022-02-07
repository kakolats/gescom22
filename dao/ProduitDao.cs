using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dao
{
    class ProduitDao : IProduitDao
    {
        GesDataContainer data = new GesDataContainer();

        public int addProduit(Produit produit)
        {
            throw new NotImplementedException();
        }

        public int delete(int id)
        {
            Produit prodDel = data.Produit.Where(prod => prod.Id == id).FirstOrDefault();
            data.Produit.Remove(prodDel);
            return data.SaveChanges();
        }

        public int deleteProduit(int idProduit)
        {
            throw new NotImplementedException();
        }

        public Produit findById(int id)
        {
            return data.Produit.Where(p => p.Id == id).FirstOrDefault();
        }

        public Produit findProduitById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(Produit produit)
        {
            data.Produit.Add(produit);
            return data.SaveChanges();
        }

        public List<Produit> showAllProduit()
        {
            return data.Produit.ToList();
        }

        public int update(Produit obj)
        {
            throw new NotImplementedException();
        }

        public int updateProduit(int idProd, int stockM)
        {
            Produit pro = data.Produit.Find(idProd);
            pro.Stock = stockM;
            return data.SaveChanges();
        }
    }
}
