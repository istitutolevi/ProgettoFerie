using System;
using System.Data.Entity.ModelConfiguration;
using ProgettoFerie.Entities;

namespace ProgettoFerie.EntitiesMappings
{
    public class RicorsioneMapping : EntityTypeConfiguration<Ricorsione>
    {
        public RicorsioneMapping()
        {
            ToTable("Ricorsioni");

            HasRequired(_ => _.InsegnanteDisposizione)
                .WithMany(_ => _.RicorsioniADisposizione)
                .Map(d => d.MapKey("IdInsegnanteDisposizione"));
        }
    }
}