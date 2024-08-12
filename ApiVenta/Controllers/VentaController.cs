using ApiVenta.Modelo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVenta.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Venta> Get()
        {
            List<Venta> lista = new List<Venta>();
            for (int i = 0; i < 5; i++)
            {
                lista.Add(new Venta { id = i,Nombre="Laptop"+i });
            }
            return lista;
        }
    }
}
