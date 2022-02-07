using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dao
{
    interface ILivraisonDao:IDao<Livraison>
    {
        int addLivraison(Livraison livraison, int idCom, int idLiv);
        List<Livraison> findLivraisonsByLivreurAndEtat(int idUser, string etat);
        int updateLivraisonStatus(int idLiv, string etat);
    }
}
