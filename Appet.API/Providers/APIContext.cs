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
        public DbSet<Estabelecimento> Estabelecimento { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        #endregion

        #region Métodos Sobrescritos

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<APIContext>(null);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        #endregion
    }
}