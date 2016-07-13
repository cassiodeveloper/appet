using System.Data.Entity.ModelConfiguration;

namespace Appet.API.Models.Mappings
{
    public class AvaliacaoMap : EntityTypeConfiguration<Avaliacao>
    {
        public AvaliacaoMap()
        {
            ToTable("Avaliacao");

            HasKey(x => x.Id);

            Property(x => x.Atendimento).IsRequired();
            Property(x => x.Comentario).HasMaxLength(250);
            Property(x => x.Data).IsRequired();
            Property(x => x.Localizacao).IsRequired();
            Property(x => x.Qualidade).IsRequired();

            //HasRequired(x => x.Usuario)
            //    .WithMany(x => x.Avaliacoes)
            //    .Map(m => m.MapKey("UsuarioId"));

            //HasRequired(x => x.Estabelecimento)
            //    .WithMany(x => x.Avaliacoes)
            //    .Map(m => m.MapKey("EstabelecimentoId"));
        }
    }
}