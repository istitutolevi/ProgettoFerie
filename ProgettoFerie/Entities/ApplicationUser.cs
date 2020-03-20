using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ProgettoFerie.Entities
{
    /// <summary>
    /// Questa classe rappresenta l'utente del sistema che è un insegnante
    /// </summary>
    /// <seealso cref="Microsoft.AspNet.Identity.EntityFramework.IdentityUser" />
    public class ApplicationUser : IdentityUser
    {

        public ApplicationUser()
        {
            OreADisposizione = new List<Ora>();
            OreUtilizzate = new List<Ora>();
            RicorsioniADisposizione = new List<Ricorsione>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }

        public virtual ICollection<Ora> OreADisposizione { get; set; }
        public virtual ICollection<Ora> OreUtilizzate { get; set; }
        public virtual ICollection<Ricorsione> RicorsioniADisposizione { get; set; }

    }
}