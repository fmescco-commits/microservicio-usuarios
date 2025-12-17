using Microsoft.EntityFrameworkCore;
using productos.Models;

namespace productos.Data;

public class ProductosDbContext : DbContext
{
    public ProductosDbContext(DbContextOptions<ProductosDbContext> options) : base(options) { }

    public DbSet<Producto> Productos => Set<Producto>();
}
