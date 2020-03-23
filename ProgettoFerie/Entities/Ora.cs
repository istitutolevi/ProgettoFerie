using System;

namespace ProgettoFerie.Entities
{
    public class Ora
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }
        public int NumeroOra { get; set; }

        public string IdInsegnanteDisposizione { get; set; }
        public virtual ApplicationUser InsegnanteDisposizione { get; set; }
        public virtual ApplicationUser InsegnanteUtilizzo { get; set; }
        public virtual Ricorsione Ricorsione { get; set; }
    }
}