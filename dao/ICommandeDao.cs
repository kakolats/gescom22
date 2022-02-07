using gescom22.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dao
{
    interface ICommandeDao:IDao<Commande>
    {
        void addCommande(Commande cmde, List<DetailsCommandeDTO> details);
        List<Commande> findAllCommandesByEtat(string etat);
        List<DetailsCommande> showDetailsCommandeByIdCommande(int idCom);
        int updateCommandeStatus(int idCom, string status);
    }
}
