using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Appet.API.Models;
using Appet.API.Providers;

namespace Appet.API.Controllers
{
    public class EstabelecimentoController : ApiController
    {
        private APIContext db = new APIContext();

        // GET: api/Estabelecimento
        public IQueryable<Estabelecimento> GetEstabelecimentoes()
        {
            return db.Estabelecimento;
        }

        // GET: api/Estabelecimento/5
        [ResponseType(typeof(Estabelecimento))]
        public async Task<IHttpActionResult> GetEstabelecimento(int id)
        {
            Estabelecimento estabelecimento = await db.Estabelecimento.FindAsync(id);

            if (estabelecimento == null)
                return NotFound();

            return Ok(estabelecimento);
        }

        // PUT: api/Estabelecimento/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEstabelecimento(int id, Estabelecimento estabelecimento)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != estabelecimento.Id)
                return BadRequest();

            db.Entry(estabelecimento).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstabelecimentoExists(id))
                    return NotFound();
                else
                    throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Estabelecimento
        [ResponseType(typeof(Estabelecimento))]
        public async Task<IHttpActionResult> PostEstabelecimento(Estabelecimento estabelecimento)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Estabelecimento.Add(estabelecimento);

            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = estabelecimento.Id }, estabelecimento);
        }

        // DELETE: api/Estabelecimento/5
        [ResponseType(typeof(Estabelecimento))]
        public async Task<IHttpActionResult> DeleteEstabelecimento(int id)
        {
            Estabelecimento estabelecimento = await db.Estabelecimento.FindAsync(id);
            if (estabelecimento == null)
                return NotFound();

            db.Estabelecimento.Remove(estabelecimento);

            await db.SaveChangesAsync();

            return Ok(estabelecimento);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();

            base.Dispose(disposing);
        }

        private bool EstabelecimentoExists(int id)
        {
            return db.Estabelecimento.Count(e => e.Id == id) > 0;
        }
    }
}