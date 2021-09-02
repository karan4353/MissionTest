using DomainLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class AppDBContext: IdentityDbContext<AppUser, IdentityRole, string>
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<AssetDefination> AssetDefinations { get; set; }
        public DbSet<VendorTable> VendorTables { get; set; }

        public DbSet<PurchaseTable> PurchaseTables { get; set; }

        public DbSet<AssetMasterTable> AssetMasterTables { get; set; }

    }
}
