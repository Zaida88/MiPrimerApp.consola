using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuloNotificaciones.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloNotificaciones.Controllers
{
    [Authorize(Roles = "Admin")]
    public class notificacionController : Controller
    {
        private readonly ApplicationDbContext _context;
        public notificacionController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.ProductoId == id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }
    }
}
