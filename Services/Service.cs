using gescom22.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.Services
{
    class Service : IService
    {
        private GesDataContainer data = new GesDataContainer();

        public int addClient(Client client)
        {
            data.User.Add(client);
            return data.SaveChanges();
        }

        public void addCommande(Commande cmde, List<DetailsCommandeDTO> details)
        {
            data.Commande.Add(cmde);
            foreach(DetailsCommandeDTO detail in details)
            {
                DetailsCommande de = new DetailsCommande()
                {
                    Quantite=detail.Quantite,
                    Produit=findProduitById(detail.Produit.Id),
                    Commande=cmde
                };
                data.DetailCommande.Add(de);
            }
            data.SaveChanges();

        }

        public int addLivraison(Livraison livraison,int idCom,int idLiv)
        {
            Livreur liv = (Livreur)data.User.Find(idLiv);
            Commande com = data.Commande.Find(idCom);
            Livraison livr = new Livraison()
            {
                Date=livraison.Date,
                Etat="EN COURS",
                Livreur=liv,
                Commande=com
            };
            
            data.Livraison.Add(livr);
            return data.SaveChanges();
        }

        public int addProduit(Produit produit)
        {
            data.Produit.Add(produit);

            try
            {
                return data.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        public int deleteProduit(int  idProduit)
        {
            Produit prodDel = data.Produit.Where(prod => prod.Id == idProduit).FirstOrDefault();
            data.Produit.Remove(prodDel);
            return data.SaveChanges();
        }

        public List<Commande> findAllCommandesByEtat(string etat)
        {
            return data.Commande.Where(c => c.Etat == etat).ToList();
        }

        public List<User> findAllLivreurs()
        {
            return data.User.Where(r => r.Role == "ROLE_LIVREUR").ToList();
        }

        public Client findClientById(int id)
        {
            return (Client)data.User.Where(u => u.Id == id).FirstOrDefault();
        }

        public Produit findProduitById(int id)
        {
            return data.Produit.Where(p => p.Id == id).FirstOrDefault();
        }

        public User findUserByLoginPassword(string login, string password)
        {
            return data.User.Where(s=>s.Login==login & s.Password==password).FirstOrDefault();
        }

        public List<Categorie> showAllCategories()
        {
            return data.Categorie.ToList();
        }


        public List<Produit> showAllProduit()
        {
            return data.Produit.ToList();
        }

        public List<DetailsCommande> showDetailsCommandeByIdCommande(int idCat)
        {
            return data.DetailCommande.Where(d => d.Commande.Id == idCat).ToList();
        }

        public int updateCommandeStatus(int idCom,string status)
        {
            Commande commande = data.Commande.Find(idCom);
            commande.Etat = status;
            return data.SaveChanges();
        }

        public int updateProduit(int idProd,int stockM)
        {
            Produit pro = data.Produit.Find(idProd);
            pro.Stock = stockM;
            return data.SaveChanges();
        }
    }
}
