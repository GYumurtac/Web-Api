using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiBitirme.Models.Context;
using WebApiBitirme.Models.Entities;

namespace WebApiBitirme.DesignPatterns.StrategyPattern
{
    public class MyInit : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                Category c = new Category();

                c.CategoryName = new Commerce("tr").Categories(1)[0];
                c.Description = new Lorem("tr").Sentence(100);
                context.Categories.Add(c);
                context.SaveChanges();
                for (int j = 0; j < 12; j++)
                {
                    Product p = new Product();

                    p.ProductName = new Commerce("tr").ProductName();
                    p.UnitPrice = Convert.ToDecimal(new Commerce("tr").Price());
                    p.UnitsInStock = rnd.Next(5, 500);
                    p.ImagePath = new Images().City();


                    context.Products.Add(p);
                    context.SaveChanges();


                    ProductCategory pc = new ProductCategory();
                    pc.ProductID = p.ID;
                    pc.CategoryID = c.ID;
                    context.ProductCategories.Add(pc);
                    context.SaveChanges();


                    if (i == 16)
                    {
                        ProductCategory pc2 = new ProductCategory();
                        pc2.ProductID = p.ID;
                        pc2.CategoryID = c.ID - 1;
                        context.ProductCategories.Add(pc2);
                    }
                    context.SaveChanges();


                    


                }
            }
        }

                    



                

            

        
    }
}
