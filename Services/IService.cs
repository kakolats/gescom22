using gescom22.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.Services
{
    public interface IService
    {
        //Gerer Produit
        int addProduit(Produit produit);
        int updateProduit(int idProd,int stockM);
        int deleteProduit(int idProduit);
        List<Produit> showAllProduit();
        Produit findProduitById(int id);


        //Gerer Commande
        void addCommande(Commande cmde, List<DetailsCommandeDTO> details);
        List<Commande> findAllCommandesByEtat(string etat);

        //Gerer Details Commande
        List<DetailsCommande> showDetailsCommandeByIdCommande(int idCom);
        int updateCommandeStatus(int idCom,string status);

        //Gerer Categorie
        List<Categorie> showAllCategories();


        //Gerer User
        User findUserByLoginPassword(string login, string password);
        int addClient(Client client);
        Client findClientById(int id);
        List<User> findAllLivreurs();


        //Gerer Livraison
        int addLivraison(Livraison livraison,int idCom,int idLiv);
        List<Livraison> findLivraisonsByLivreurAndEtat(int idUser,string etat);
    }
}
