using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiBitirme.DesignPatterns.StrategyPattern;
using WebApiBitirme.Models.Entities;

namespace WebApiBitirme.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext(): base("MyConnection")
        {
            Database.SetInitializer(new MyInit());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<BaseEntity>().Property(x => x.CreatedDate).HasColumnName("OlusturulmaTarihi").HasColumnType("datetime2");
            //modelBuilder.Entity<BaseEntity>().Property(x => x.DeletedDate).HasColumnName("SilinmeTarihi").HasColumnType("datetime2");
            //modelBuilder.Entity<BaseEntity>().Property(x => x.UpdatedDate).HasColumnName("GuncellenmeTarihi").HasColumnType("datetime2");
            //modelBuilder.Entity<BaseEntity>().Property(x => x.Status).HasColumnName("VeriDurumu");


            modelBuilder.Entity<Product>().ToTable("Urunler");
            modelBuilder.Entity<Product>().Property(x => x.ProductName).HasColumnName("UrunIsmi");
            modelBuilder.Entity<Product>().Property(x => x.ImagePath).HasColumnName("UrunResmi");
            modelBuilder.Entity<Product>().Property(x => x.UnitsInStock).HasColumnName("UrunStok");
            modelBuilder.Entity<Product>().Property(x => x.UnitPrice).HasColumnName("UrunFiyatı").HasColumnType("money");


            modelBuilder.Entity<Category>().ToTable("Kategoriler");
            modelBuilder.Entity<Category>().Property(x => x.CategoryName).HasColumnName("KategoriAdi");
            modelBuilder.Entity<Category>().Property(x => x.Description).HasColumnName("KategoriAÇiklamasi");


           

            modelBuilder.Entity<ProductCategory>().ToTable("UrunKategorileri");
        }

        public DbSet<Category> Categories { get; set; }


        public DbSet<Product> Products { get; set; }


        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}