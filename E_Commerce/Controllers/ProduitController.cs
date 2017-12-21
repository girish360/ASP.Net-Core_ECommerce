using E_Commerce.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
using PagedList.Mvc;
using E_Commerce.Models.ViewModels;

namespace E_Commerce.Controllers
{
    public class ProduitController : Controller
    {
        IProductRepository MyRepository;

        public ProduitController(IProductRepository Repository)
        {
            this.MyRepository = Repository;
        }

        public ActionResult List(int? page = 1)
        {
            ListeProduitsViewModels listeproduit = new ListeProduitsViewModels
            {
                ProduitList = MyRepository.Produits.OrderBy(s => s.IDProduct).ToList<Produit>()
            };

            listeproduit.PageInfo = new PaginationInfo { PageCourante = page ?? 1, NombreProduits = listeproduit.ProduitList.Count(),  ProduitsParPages = 3};

            if (!(page == null))
            {
                listeproduit.ProduitList = listeproduit.ProduitList.Skip((listeproduit.PageInfo.PageCourante - 1) * listeproduit.PageInfo.ProduitsParPages).Take(listeproduit.PageInfo.ProduitsParPages).ToList<Produit>();
                return View(listeproduit);
            }
            else
            {
                return View(listeproduit);
            }

        }

    }
}
