using System.Data.Entity;
using Appet.API.Models;

namespace Appet.API.Providers
{
    public class APIContext : DbContext
    {   
        public APIContext() : base("name=APIContext")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<UsuarioModel> UsuarioModels { get; set; }
        public DbSet<PetModel> PetModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}