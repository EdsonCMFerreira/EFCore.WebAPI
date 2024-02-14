using EFCore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Data
{
    public class HeroiContext : DbContext
    {
        public DbSet<Heroi> Heroi { get; set; }
        public DbSet<Batalha> Batalha { get; set; }
        public DbSet<Arma> Arma { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=master;Data Source=DESKTOP-E764S5K");
        }

    }
}
