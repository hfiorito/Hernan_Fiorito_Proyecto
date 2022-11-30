using Microsoft.AspNetCore.Mvc;
using Hernan_Fiorito.Models;
using Hernan_Fiorito.Repositories;
namespace Hernan_Fiorito.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        
        private Usuariorepository repository = new Usuariorepository();
        [HttpGet]
        public ActionResult<List<Usuario>> Get()
        {
            try
            {
                List<Usuario> lista = repository.ListaUsuarios();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
