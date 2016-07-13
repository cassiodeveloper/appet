using System.Data.Entity.ModelConfiguration;

namespace Appet.API.Models.Mappings
{
    public class CidadeMap : EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            ToTable("Cidade");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(25).IsRequired();

            HasRequired(x => x.Estado)
               .WithMany(x => x.Cidades)
               .Map(m => m.MapKey("CidadeId"));
        }
    }
}