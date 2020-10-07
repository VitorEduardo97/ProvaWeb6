using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProvaWEB4.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProvaWEB4.Context
{
    public class Contexto : DbContext
    {
        public DbSet<AlunoModel> aluno { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}