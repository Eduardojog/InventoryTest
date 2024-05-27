PM> add-mgration AddData
PM> update-database

PARA MEJORAR Y PAGINAR UN GRID https://ankitsharmablogs.com/blazorgrid-reusable-grid-component-for-blazor/

Business CAPA DE NGOCIO QUE TIENE LOS METODS CategoryList   ,CreateCategory  , UpdateCategory

el dataaccess tiene la carga de la bd inicial y cra el modelo 

using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost; Database=InventoryDB; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Home Cleaning" },
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Personal Care" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Home" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfume" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Health" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Games" }
                );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Central Warehouse", WarehouseAddress = "8th Street and 23rd Avenue" },
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "North Warehouse", WarehouseAddress = "North Street and West Avenue" }
                );

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity { ProductId = "ASJ-98745", ProductName = "Tersa Brand Hand Cream", ProductDescription = "", CategoryId = "PRF" },
                new ProductEntity { ProductId = "VDJ-98746", ProductName = "Call Of duty", ProductDescription = "", CategoryId = "VDJ" },
                new ProductEntity { ProductId = "RPT-5465879", ProductName = "Crema", ProductDescription = "", CategoryId = "SLD" }
                );
        }
    }
}



Entities