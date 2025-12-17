using Microsoft.AspNetCore.Mvc;
using usuarios.Data;
using usuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace usuarios.Controllers;

[ApiController]
[Route("api/usuarios")]
public class UsuariosController : ControllerBase
{
    private readonly UsuariosDbContext _context;

    public UsuariosController(UsuariosDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Usuario>> Get()
        => await _context.Usuarios.ToListAsync();

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();
        return Ok(usuario);
    }
}
