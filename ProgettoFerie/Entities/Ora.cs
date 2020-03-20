﻿using System;

namespace ProgettoFerie.Entities
{
    public class Ora
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }
        public int NumeroOra { get; set; }

        public virtual ApplicationUser InsegnanteDisposizione { get; set; }
        public virtual ApplicationUser InegnanteUtilizzo { get; set; }
        public virtual Ricorsione Ricorsione { get; set; }
    }
}