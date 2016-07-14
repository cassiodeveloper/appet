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
    public class EnderecoController : ApiController
    {
        private APIContext db = new APIContext();

        // GET: api/Endereco
        public IQueryable<Endereco> GetEnderecoes()
        {
            return db.Endereco;
        }

        // GET: api/Endereco/5
        [ResponseType(typeof(Endereco))]
        public async Task<IHttpActionResult> GetEndereco(int id)
        {
            Endereco endereco = await db.Endereco.FindAsync(id);
            if (endereco == null)
            {
                return NotFound();
            }

            return Ok(endereco);
        }

        // PUT: api/Endereco/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEndereco(int id, Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != endereco.Id)
            {
                return BadRequest();
            }

            db.Entry(endereco).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
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

        // POST: api/Endereco
        [ResponseType(typeof(Endereco))]
        public async Task<IHttpActionResult> PostEndereco(Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Endereco.Add(endereco);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = endereco.Id }, endereco);
        }

        // DELETE: api/Endereco/5
        [ResponseType(typeof(Endereco))]
        public async Task<IHttpActionResult> DeleteEndereco(int id)
        {
            Endereco endereco = await db.Endereco.FindAsync(id);
            if (endereco == null)
            {
                return NotFound();
            }

            db.Endereco.Remove(endereco);
            await db.SaveChangesAsync();

            return Ok(endereco);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EnderecoExists(int id)
        {
            return db.Endereco.Count(e => e.Id == id) > 0;
        }
    }
}