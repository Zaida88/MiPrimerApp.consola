using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ModuloNotificaciones.Entities;

namespace ModuloNotificaciones.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ModuloNotificaciones.Entities.Usuario> Usuario { get; set; }
        public DbSet<ModuloNotificaciones.Entities.Producto> Producto { get; set; }
    }
}
