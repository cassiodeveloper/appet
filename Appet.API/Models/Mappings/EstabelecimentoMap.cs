using System.Data.Entity.ModelConfiguration;

namespace Appet.API.Models.Mappings
{
    public class EstabelecimentoMap : EntityTypeConfiguration<EstabelecimentoModel>
    {
        public EstabelecimentoMap()
        {
            ToTable("Estabelecimento");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(50).IsRequired();

            //HasOptional(x => x.Endereco)
            //    .WithRequired(x => x.Estabelecimento);
        }
    }
}