using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.ViewModels
{
    public class ListeProduitsViewModels
    {
        public PaginationInfo PageInfo { get; set; }
        public List<Produit> ProduitList { get; set; }
    }
}
