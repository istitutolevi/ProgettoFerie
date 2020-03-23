using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProgettoFerie.Entities;
using ProgettoFerie.Models;

namespace ProgettoFerie.Mappings
{
    public static class UserMapper
    {
        public static void Map(ApplicationUser applicationUser, UserViewModel userViewModel)
        {
            userViewModel.Id = applicationUser.Id;
            userViewModel.UserName = applicationUser.UserName;
        }

        public static UserViewModel Map(ApplicationUser applicationUser)
        {
            if (applicationUser == null)
                return null;

            UserViewModel userViewModel = new UserViewModel();
            Map(applicationUser, userViewModel);
            return userViewModel;
        }

    }
}