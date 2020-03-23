using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProgettoFerie.Entities;
using ProgettoFerie.Models;

namespace ProgettoFerie.Mappings
{
    public class OraMapper
    {
        public static void Map(Ora ora, OraViewModel oraViewModel)
        {
            oraViewModel.Id = ora.Id;
            oraViewModel.Data = ora.Data;
            oraViewModel.NumeroOra = ora.NumeroOra;
            oraViewModel.InsegnanteUtilizzo = UserMapper.Map(ora.InsegnanteUtilizzo);
            oraViewModel.InsegnanteDisposizione = UserMapper.Map(ora.InsegnanteDisposizione);
        }

        public static OraViewModel Map(Ora ora)
        {
            OraViewModel oraViewModel = new OraViewModel();
            Map(ora, oraViewModel);
            return oraViewModel;
        }
    }
}