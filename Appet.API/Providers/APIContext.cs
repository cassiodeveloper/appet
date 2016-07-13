using Appet.API.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Appet.API.Providers
{
    public class APIContext : DbContext
    {
        #region Construtor

        public APIContext() : base("name=APIContext")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        #endregion

        #region Tabelas

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Pet> Pet { get; set; }

        #endregion

        #region Métodos Sobrescritos

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        #endregion
    }
}