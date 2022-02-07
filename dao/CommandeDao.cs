using gescom22.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dao
{
    class CommandeDao : ICommandeDao
    {
        GesDataContainer data = new GesDataContainer();
        ProduitDao pro = new ProduitDao();
        
        public void addCommande(Commande cmde, List<DetailsCommandeDTO> details)
        {
            data.Commande.Add(cmde);
            foreach (DetailsCommandeDTO detail in details)
            {
                DetailsCommande de = new DetailsCommande()
                {
                    Quantite = detail.Quantite,
                    Produit = pro.findProduitById(detail.Produit.Id),
                    Commande = cmde
                };
                data.DetailCommande.Add(de);
            }
            data.SaveChanges();
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Commande> findAllCommandesByEtat(string etat)
        {
            throw new NotImplementedException();
        }

        public Commande findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(Commande obj)
        {
            throw new NotImplementedException();
        }

        public List<DetailsCommande> showDetailsCommandeByIdCommande(int idCom)
        {
            throw new NotImplementedException();
        }

        public int update(Commande obj)
        {
            throw new NotImplementedException();
        }

        public int updateCommandeStatus(int idCom, string status)
        {
            Commande commande = data.Commande.Find(idCom);
            commande.Etat = status;
            return data.SaveChanges();
        }
    }
}
