using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class SeedData
    {
        public static void MyProductDataBase(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Produits.Any())
            {
                context.Produits.AddRange(
                    new Produit { Name = "Kayak", Description="Bateau pour une personne", Category="Sport Nautique", Price=275M},
                    new Produit { Name = "Catamaran", Description = "Bateau pour deux personnes", Category = "Sport Nautique", Price = 15000M },
                    new Produit { Name = "Voilier", Description = "Bateau pour quatre personnes", Category = "Sport Nautique", Price = 150000M },
                    new Produit { Name = "Arc", Description = "Système pour lancer des fléches", Category = "Sport Précision", Price = 150M },
                    new Produit { Name = "Fleches", Description = "Accessoire servant a l'arc", Category = "Sport Précision", Price = 10M },
                    new Produit { Name = "Gilet de sauvetage", Description = "Gilet permettant de sauver des vies", Category = "Sécurité", Price = 25M },
                    new Produit { Name = "Ballon de foot", Description = "ballon pour la pratique du football", Category = "Sport collectif", Price = 10M },
                    new Produit { Name = "Kimono", Description = "Accessoire pour le judo", Category = "Sport Combat", Price = 10M },
                    new Produit { Name = "Gant de boxes", Description = "Accessoire pour la boxe", Category = "Sport Combat", Price = 10M },
                    new Produit { Name = "Cordes a sauté", Description = "Accessoire divertissant", Category = "Sport Exterieur", Price = 10M }
                    );
                context.SaveChanges();
            }
        }
    }
}
