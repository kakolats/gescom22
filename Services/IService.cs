using gescom22.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.Services
{
    public interface IService
    {
        //Gerer Produit
        int addProduit(Produit produit);
        int updateProduit(Produit produit);
        int deleteProduit(int idProduit);
        List<Produit> showAllProduit();
        Produit findProduitById(int id);


        //Gerer Commande
        void addCommande(Commande cmde, List<DetailsCommandeDTO> details);

        //Gerer Categorie
        List<Categorie> showAllCategories();


        //Gerer User
        User findUserByLoginPassword(string login, string password);
        int addClient(Client client);
        Client findClientById(int id);
    }
}
