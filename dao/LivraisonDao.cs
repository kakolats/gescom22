using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dao
{
    class LivraisonDao : ILivraisonDao
    {
        GesDataContainer data = new GesDataContainer();
        public int addLivraison(Livraison livraison, int idCom, int idLiv)
        {
            Livreur liv = (Livreur)data.User.Find(idLiv);
            Commande com = data.Commande.Find(idCom);
            Livraison livr = new Livraison()
            {
                Date = livraison.Date,
                Etat = "EN COURS",
                Livreur = liv,
                Commande = com
            };

            data.Livraison.Add(livr);
            return data.SaveChanges();
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public Livraison findById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Livraison> findLivraisonsByLivreurAndEtat(int idUser, string etat)
        {
            return data.Livraison.Where(l => l.Livreur.Id == idUser & l.Etat == etat).ToList();
        }

        public int insert(Livraison obj)
        {
            throw new NotImplementedException();
        }

        public int update(Livraison obj)
        {
            throw new NotImplementedException();
        }

        public int updateLivraisonStatus(int idLiv, string etat)
        {
            Livraison liv = data.Livraison.Find(idLiv);
            liv.Etat = etat;
            return data.SaveChanges();
        }
    }
}
