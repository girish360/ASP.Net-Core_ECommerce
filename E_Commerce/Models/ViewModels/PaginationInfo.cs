using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.ViewModels
{
    public class PaginationInfo
    {
        public int NombreProduits { get; set; }
        public int ProduitsParPages { get; set; }
        public int PageCourante { get; set; }

        public int NbPage(int NbProduits, int ProduitPage)
        {
            int NombrePage = 0;

            if (NombreProduits % ProduitPage == 0)
            {
                NombrePage = NombreProduits / ProduitPage;
            }
            else
            {
                NombrePage = (NombreProduits / ProduitPage) + 1;
            }

            return NombrePage; 
        }
    }
}
