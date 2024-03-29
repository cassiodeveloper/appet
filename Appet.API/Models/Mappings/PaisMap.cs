﻿using System.Data.Entity.ModelConfiguration;

namespace Appet.API.Models.Mappings
{
    public class PaisMap : EntityTypeConfiguration<Pais>
    {
        public PaisMap()
        {
            ToTable("Pais");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(30).IsRequired();
        }
    }
}