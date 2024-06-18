using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioCRUDMvvm.Data;
using EjercicioCRUDMvvm.Models;

public class ProductoService
{
    private readonly ProductoDbContext _context;

    public ProductoService(ProductoDbContext context)
    {
        _context = context;
    }

    public async Task<List<Producto>> GetProductosAsync()
    {
        return await _context.Productos.ToListAsync();
    }

    public async Task<Producto> GetProductoAsync(int id)
    {
        return await _context.Productos.FindAsync(id);
    }

    public async Task CreateProductoAsync(Producto producto)
    {
        _context.Productos.Add(producto);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProductoAsync(Producto producto)
    {
        _context.Productos.Update(producto);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProductoAsync(int id)
    {
        var producto = await GetProductoAsync(id);
        if (producto != null)
        {
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
        }
    }
}