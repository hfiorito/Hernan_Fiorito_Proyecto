using Hernan_Fiorito.Repositories;
using Microsoft.AspNetCore.Mvc;
using Hernan_Fiorito.Models;

namespace Hernan_Fiorito.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class VentasController : Controller
    {
        private VentasRepository repository = new VentasRepository();
        [HttpGet]

        public ActionResult<List<Venta>> Get()
        {
            try
            {
                List<Venta> lista = repository.listaVentas();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        
    }
}
