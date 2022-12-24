using HepsiSuradaModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiSuradaDataAccess.Context
{
   public class HepsiBuradaDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=./SQLEXPRESS;database=HepsiSurada;trusted_connection=true;");
        }

        public DbSet<Admin> Admins { get; set; }
      
    }
}
