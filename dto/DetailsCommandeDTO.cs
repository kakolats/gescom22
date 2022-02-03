using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gescom22.dto
{
    public class DetailsCommandeDTO
    {
        private int quantite;
        private Produit produit;

        public int Quantite { get => quantite; set => quantite = value; }
        public Produit Produit { get => produit; set => produit = value; }
    }
}
