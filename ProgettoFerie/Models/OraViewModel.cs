using System;

namespace ProgettoFerie.Models
{
    public class OraViewModel
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }
        public int NumeroOra { get; set; }

        public virtual UserViewModel InsegnanteDisposizione { get; set; }
        public virtual UserViewModel InsegnanteUtilizzo { get; set; }
    }
}