using System;
using System.Collections.Generic;

namespace ProgettoFerie.Entities
{
    public class Ricorsione
    {
        public Ricorsione()
        {
            Ore = new List<Ora>();
        }

        public int Id { get; set; }
        public DayOfWeek Giorno { get; set; }
        public int NumeroOra { get; set; }

        public DateTime DataInizio;
        public DateTime DataFine;

        public ICollection<Ora> Ore { get; set; }

        public virtual ApplicationUser InsegnanteDisposizione { get; set; }
    }
}