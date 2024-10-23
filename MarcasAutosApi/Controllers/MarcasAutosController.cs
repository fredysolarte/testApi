using MarcasAutosApi.Data;
using MarcasAutosApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarcasAutosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarcasAutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MarcasAutosController(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); // validate inject dependences
        }

        [HttpGet]
        public ActionResult<IEnumerable<MarcaAuto>> GetMarcasAutos()
        {
            var marcas = _context.MarcasAutos.ToList(); 
            return Ok(marcas);
        }
    }
}
