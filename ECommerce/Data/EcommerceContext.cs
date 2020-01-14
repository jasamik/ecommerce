using ECommerce.Entities;
using ECommerce.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Data
{
    public class EcommerceContext: DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options): base(options)
        {
                
        }

        DbSet<Administrador> Administratores { get; set; }
        DbSet<Banner> Banners { get; set; }
        DbSet<Cabecera> Cabeceras { get; set; }
        DbSet<Categoria> Categorias { get; set; }
        DbSet<Comercio> Comercios { get; set; }
        DbSet<Compra> Compras { get; set; }
        DbSet<Compra> Slides { get; set; }

    }
}
