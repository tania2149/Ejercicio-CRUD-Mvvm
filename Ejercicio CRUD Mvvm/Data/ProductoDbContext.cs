using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_CRUD_Mvvm.Data
{
    using Ejercicio_CRUD_Mvvm.Models;

    public class ProductoDbContext : DbContext
    {
        public ProductoDbContext(DbContextOptions<ProductoDbContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
