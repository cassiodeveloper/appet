using System.Data.Entity.ModelConfiguration;

namespace Appet.API.Models.Mappings
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            ToTable("Endereco");

            HasKey(x => x.Id);

            Property(x => x.Bairro).HasMaxLength(30).IsRequired();
            Property(x => x.CEP).IsRequired();
            Property(x => x.Complemento).HasMaxLength(30);
            Property(x => x.Latitude).IsRequired();
            Property(x => x.Longitude).IsRequired();
            Property(x => x.Numero).HasMaxLength(5).IsRequired();

            //HasRequired(x => x.Estado)
            //   .WithMany(x => x.Cidades)
            //   .Map(m => m.MapKey("CidadeId"));
        }
    }
}