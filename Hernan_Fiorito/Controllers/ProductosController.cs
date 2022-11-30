using Hernan_Fiorito.Models;
using Hernan_Fiorito.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hernan_Fiorito.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    // si la ruta pongo api/v1/[controller] me va a aparecer la palabra Productos en el swager
    //[Route("api/v1/[controller]/[action]") me permite temer mas de un get en la api
    public class ProductosController : Controller
    {
        private ProductosRepository repository = new ProductosRepository();
        [HttpGet]//identifico el método que voy a utilizar
        public ActionResult<List<Producto>> Get()
        {
            try
            {
                List<Producto> lista = repository.listarProductos();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        /*
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }


        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

        [HttpGet]//identifico el método que voy a utilizar
        public IActionResult Get()
        {
            return Ok("Hola desde la API");
        }*/
        //esto aparece en la acction
    }
}
