using Microsoft.AspNetCore.Mvc;
using ProductosApi.Data;
using ProductosApi.Models;

namespace ProductosApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductosController(AppDbContext context)
        {
            _context = context;
        }

        // GET /api/productos
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Productos.ToList());
        }

        // POST /api/productos
        [HttpPost]
        public IActionResult Post(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();

            return Ok(producto);
        }

        // DELETE /api/productos/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var producto = _context.Productos.Find(id);

            if (producto == null)
                return NotFound();

            _context.Productos.Remove(producto);
            _context.SaveChanges();

            return Ok();
        }
    }
}