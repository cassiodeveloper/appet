using System.Data.Entity.ModelConfiguration;

namespace Appet.API.Models.Mappings
{
    public class ConsultaMap : EntityTypeConfiguration<Consulta>
    {
        public ConsultaMap()
        {
            ToTable("Consulta");

            HasKey(x => x.Id);

            Property(x => x.Confirmada).IsRequired();
            Property(x => x.Data).IsRequired();
            Property(x => x.ObservacaoEstabelecimento).HasMaxLength(500);
            Property(x => x.ObservacaoPaciente).HasMaxLength(500);
            Property(x => x.Realizada).IsRequired();

            //HasRequired(x => x.Estabelecimento)
            //   .WithOptional(x => x.Consulta)
            //   .Map(m => m.MapKey("EstabelecimentoId"));

            //HasRequired(x => x.Pet)
            //   .WithOptional(x => x.Consulta)
            //   .Map(m => m.MapKey("PetId"));
        }
    }
}