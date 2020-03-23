using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using ProgettoFerie.Entities;
using ProgettoFerie.Mappings;
using ProgettoFerie.Models;

namespace ProgettoFerie.Controllers
{
    public class OreController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Ore
        [ResponseType(typeof(List<OraViewModel>))]
        public IHttpActionResult GetOre()
        {
            List<OraViewModel> list = new List<OraViewModel>();
            List<Ora> oreSulDatabase = db.Ore.ToList();
            foreach (Ora ora in oreSulDatabase)
            {
                list.Add(OraMapper.Map(ora));
            }

            return Ok(list);
        }

        [ResponseType(typeof(List<OraViewModel>))]
        public IHttpActionResult GetOre(DateTime data, int ora)
        {
            List<OraViewModel> list = new List<OraViewModel>();
            List<Ora> oreSulDatabase = db.Ore
                .Where(_ => _.Data == data && _.NumeroOra == ora)
                .ToList();

            foreach (Ora o in oreSulDatabase)
            {
                list.Add(OraMapper.Map(o));
            }

            return Ok(list);
        }

        // GET: api/Ore/5
        [ResponseType(typeof(OraViewModel))]
        public IHttpActionResult GetOra(int id)
        {
            Ora ora = db.Ore.Find(id);
            if (ora == null)
            {
                return NotFound();
            }

            OraViewModel oraViewModel = OraMapper.Map(ora);

            return Ok(oraViewModel);
        }

        // PUT: api/Ore/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOra(int id, Ora ora)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ora.Id)
            {
                return BadRequest();
            }

            db.Entry(ora).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OraExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Ore
        [ResponseType(typeof(Ora))]
        public IHttpActionResult PostOra(OraViewModel oraViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Ora ora = new Ora();
            ora.Data = oraViewModel.Data;
            ora.NumeroOra = oraViewModel.NumeroOra;
#warning Da sistemare con autenticazione
            //ora.IdInsegnanteDisposizione = User.Identity.GetUserId();
            ora.IdInsegnanteDisposizione = oraViewModel.InsegnanteDisposizione.Id;

            db.Ore.Add(ora);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ora.Id }, ora);
        }

        // DELETE: api/Ore/5
        [ResponseType(typeof(Ora))]
        public IHttpActionResult DeleteOra(int id)
        {
            Ora ora = db.Ore.Find(id);
            if (ora == null)
            {
                return NotFound();
            }

            db.Ore.Remove(ora);
            db.SaveChanges();

            return Ok(ora);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OraExists(int id)
        {
            return db.Ore.Count(e => e.Id == id) > 0;
        }
    }
}