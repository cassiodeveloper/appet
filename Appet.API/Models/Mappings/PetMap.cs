using System.Data.Entity.ModelConfiguration;

namespace Appet.API.Models.Mappings
{
    public class PetMap : EntityTypeConfiguration<Pet>
    {
        public PetMap()
        {
            ToTable("Pet");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(25).IsRequired();
            Property(x => x.Idade).IsRequired();
            Property(x => x.Observacao).HasMaxLength(500);
            Property(x => x.Raca).IsRequired();
            Property(x => x.Cor).IsRequired();
            Property(x => x.DataNascimento);

            HasRequired(x => x.Usuario)
               .WithMany(x => x.Pets)
               .Map(m => m.MapKey("UsuarioId"));
        }
    }
}