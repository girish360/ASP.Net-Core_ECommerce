using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class FauxDepotProduit : IProductRepository
    {
        public IQueryable<Produit> Produits => new List<Produit> {
            new Produit { IDProduct = 1, Name = "Kayak", Description = "Bateau pour une personne", Category = "Sport Aquatique", Price = 275M },
            new Produit { IDProduct = 2, Name = "Voilier", Description = "Bateau pour quatres personnes", Category = "Sport Aquatique", Price = 150000M },
            new Produit { IDProduct = 3, Name = "Catamaran", Description = "Bateau pour deux personnes", Category = "Sport Aquatique", Price = 15000M }
        }.AsQueryable<Produit>();
    }
}
