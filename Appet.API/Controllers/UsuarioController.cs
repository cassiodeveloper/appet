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
    public class UsuarioController : ApiController
    {
        private APIContext db = new APIContext();

        // GET: api/Usuario
        public IQueryable<Usuario> GetUsuarios()
        {
            return db.Usuario;
        }

        // GET: api/Usuario/5
        [ResponseType(typeof(Usuario))]
        public async Task<IHttpActionResult> GetUsuario(int id)
        {
            Usuario usuarioModel = await db.Usuario.FindAsync(id);
            if (usuarioModel == null)
            {
                return NotFound();
            }

            return Ok(usuarioModel);
        }

        // PUT: api/Usuario/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUsuario(int id, Usuario usuarioModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != usuarioModel.Id)
                return BadRequest();

            db.Entry(usuarioModel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioModelExists(id))
                    return NotFound();
                else
                    throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Usuario
        [ResponseType(typeof(Usuario))]
        public async Task<IHttpActionResult> PostUsuario(Usuario usuarioModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Usuario.Add(usuarioModel);

            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = usuarioModel.Id }, usuarioModel);
        }

        // DELETE: api/Usuario/5
        [ResponseType(typeof(Usuario))]
        public async Task<IHttpActionResult> DeleteUsuario(int id)
        {
            Usuario usuarioModel = await db.Usuario.FindAsync(id);

            if (usuarioModel == null)
                return NotFound();

            db.Usuario.Remove(usuarioModel);

            await db.SaveChangesAsync();

            return Ok(usuarioModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();

            base.Dispose(disposing);
        }

        private bool UsuarioModelExists(int id)
        {
            return db.Usuario.Count(e => e.Id == id) > 0;
        }
    }
}