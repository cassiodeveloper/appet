using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Appet.API.Models.Mappings
{
    public class UsuarioMap : EntityTypeConfiguration<UsuarioModel>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(25).IsRequired();
            Property(x => x.Sobrenome).HasMaxLength(25).IsRequired();
            Property(x => x.Email).HasMaxLength(50).IsRequired();
            Property(x => x.Senha).HasMaxLength(20).IsRequired();
            Property(x => x.DataCadastro).IsRequired();
            Property(x => x.UltimaAtualizacao).IsRequired();
        }
    }
}