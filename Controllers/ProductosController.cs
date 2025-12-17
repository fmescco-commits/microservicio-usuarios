using Microsoft.AspNetCore.Mvc;
using productos.Data;
using productos.Models;
using Microsoft.EntityFrameworkCore;

namespace productos.Controllers;

[ApiController]
[Route("api/productos")]
public class ProductosController : ControllerBase
{
    private readonly ProductosDbContext _context;

    public ProductosController(ProductosDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Producto>> Get()
        => await _context.Productos.ToListAsync();

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Producto producto)
    {
        _context.Productos.Add(producto);
        await _context.SaveChangesAsync();
        return Ok(producto);
    }
}

