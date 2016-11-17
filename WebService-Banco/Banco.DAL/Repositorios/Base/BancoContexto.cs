using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Banco.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Banco.DAL.Repositorios.Base
{
    public class BancoContexto : DbContext
    {
        public BancoContexto() : base("ConMysql") { }

        public DbSet<Login> login { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
