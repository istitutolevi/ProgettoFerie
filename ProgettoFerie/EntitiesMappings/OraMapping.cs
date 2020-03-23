using System;
using System.Data.Entity.ModelConfiguration;
using ProgettoFerie.Entities;

namespace ProgettoFerie.EntitiesMappings
{
    public class OraMapping : EntityTypeConfiguration<Ora>
    {
        public OraMapping()
        {
            ToTable("Ore");

            HasRequired(_ => _.InsegnanteDisposizione)
                .WithMany(_ => _.OreADisposizione)
                .HasForeignKey(d => d.IdInsegnanteDisposizione);

            HasOptional(_ => _.InsegnanteUtilizzo)
                .WithMany(_ => _.OreUtilizzate)
                .Map(d => d.MapKey("IdInsegnanteUtilizzo"));

            HasOptional(_ => _.Ricorsione)
                .WithMany(_ => _.Ore)
                .Map(d => d.MapKey("IdRicorsione"));
        }
    }
}