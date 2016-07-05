using System.Data.Entity.ModelConfiguration;

namespace Appet.API.Models.Mappings
{
    public class EstadoMap : EntityTypeConfiguration<EstadoModel>
    {
        public EstadoMap()
        {
            ToTable("Estado");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(20).IsRequired();
            Property(x => x.Sigla).HasMaxLength(2).IsRequired();

            HasRequired(x => x.Pais)
               .WithMany(x => x.Estados)
               .Map(m => m.MapKey("PaisId"));
        }
    }
}