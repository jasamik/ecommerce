using ECommerce.Entities;
using ECommerce.Model;
using ECommerceAPI.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Data
{
    public class EcommerceContext: IdentityDbContext<AplicationUser>
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
        DbSet<Deseo> Deseos { get; set; }
        DbSet<Notificacion> Notificaciones { get; set; }
        DbSet<Producto> Productos { get; set; }
        DbSet<Slide> Slides { get; set; }
        DbSet<Subcategoria> subcategorias { get; set; }
        public DbSet<ECommerce.Entities.Usuario> Usuario { get; set; }
       

    }
}
