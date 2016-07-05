using Appet.API.Models;
using Appet.API.Providers;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Appet.API.Controllers
{
    public class UsuarioModelsController : ApiController
    {
        private APIContext db = new APIContext();

        // GET: api/UsuarioModels
        public IQueryable<UsuarioModel> GetUsuarioModels()
        {
            return db.UsuarioModels;
        }

        // GET: api/UsuarioModels/5
        [ResponseType(typeof(UsuarioModel))]
        public async Task<IHttpActionResult> GetUsuarioModel(int id)
        {
            UsuarioModel usuarioModel = await db.UsuarioModels.FindAsync(id);
            if (usuarioModel == null)
            {
                return NotFound();
            }

            return Ok(usuarioModel);
        }

        // PUT: api/UsuarioModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUsuarioModel(int id, UsuarioModel usuarioModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usuarioModel.Id)
            {
                return BadRequest();
            }

            db.Entry(usuarioModel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioModelExists(id))
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

        // POST: api/UsuarioModels
        [ResponseType(typeof(UsuarioModel))]
        public async Task<IHttpActionResult> PostUsuarioModel(UsuarioModel usuarioModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UsuarioModels.Add(usuarioModel);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = usuarioModel.Id }, usuarioModel);
        }

        // DELETE: api/UsuarioModels/5
        [ResponseType(typeof(UsuarioModel))]
        public async Task<IHttpActionResult> DeleteUsuarioModel(int id)
        {
            UsuarioModel usuarioModel = await db.UsuarioModels.FindAsync(id);
            if (usuarioModel == null)
            {
                return NotFound();
            }

            db.UsuarioModels.Remove(usuarioModel);
            await db.SaveChangesAsync();

            return Ok(usuarioModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsuarioModelExists(int id)
        {
            return db.UsuarioModels.Count(e => e.Id == id) > 0;
        }
    }
}