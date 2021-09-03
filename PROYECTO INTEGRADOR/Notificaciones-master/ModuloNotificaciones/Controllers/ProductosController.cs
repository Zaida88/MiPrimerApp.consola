using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ModuloNotificaciones.Data;
using ModuloNotificaciones.Entities;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Authorization;
using IronPdf;
namespace ModuloNotificaciones.Controllers
{
    [Authorize (Roles = "Admin")]
    public class ProductosController : Controller
    {
        
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Producto.Include(p => p.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Productos/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "UsuarioId", "CedulaNombre");

            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductoId,Nombre,Precio,FechaRegistro,UsuarioId")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "UsuarioId", "CedulaNombre", producto.UsuarioId);
            return View(producto);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "UsuarioId", "CedulaNombre", producto.UsuarioId);
            return View(producto);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductoId,Nombre,Precio,FechaRegistro,UsuarioId")] Producto producto)
        {
            if (id != producto.ProductoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.ProductoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "UsuarioId", "CedulaNombre", producto.UsuarioId);
            return View(producto);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Producto.FindAsync(id);
            _context.Producto.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Producto.Any(e => e.ProductoId == id);
        }
        public async Task<IActionResult> Notificacion(int? id)
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
        public IActionResult EnviarNotificacion(int? id)
        {
            String servidor = "smtp.gmail.com";

           
            String GmailUser = "ecuarefils@gmail.com";
            String Gmailpassword = "123456proyecto";
            MimeMessage mensaje = new();
            mensaje.From.Add(new MailboxAddress("Notificacion", GmailUser));
            
            

            mensaje.Subject = "Notificacion Producto";

            BodyBuilder CuerpoMensaje = new();


            var consulta = from usuario in _context.Usuario
                           join producto in _context.Producto on usuario.UsuarioId equals producto.UsuarioId
                           where producto.ProductoId == id
                           select $"<img src='https://i.imgur.com/zccCjfN.png' width='130' height='75'/><h1> EcuaRefills Agradece su compra, su compra a sido registrada con los siguientes Detalles</h1> Nombre del Producto:{producto.Nombre}<br> Precio del producto:{producto.Precio}$ <br> Fecha De Compra Del Producto:{producto.FechaRegistro}<br> Cedula Del Cliente:{usuario.UsuarioId} <br> Nombre Del Cliente:{usuario.Nombre} <br> Correo Del Cliente: {usuario.Correo}".ToString();

            var correoconsulta = from usuario in _context.Usuario
                            join producto in _context.Producto on usuario.UsuarioId equals producto.UsuarioId
                            where producto.ProductoId == id
                            select usuario.Correo.ToString();
            string correo = correoconsulta.Single();

            var htmltopdf = new HtmlToPdf();

            var pdfdocument = htmltopdf.RenderHtmlAsPdf(consulta.Single());
            pdfdocument.SaveAs("notificacion.pdf");

            CuerpoMensaje.Attachments.Add("notificacion.pdf");
            CuerpoMensaje.HtmlBody = "<h1> EcuaRefills Agradece su compra,puede revisar los detalles de su compra en el documento adjunto </h1>";
            mensaje.To.Add(new MailboxAddress("Destinatario",correo ));
            mensaje.Body = CuerpoMensaje.ToMessageBody();
            SmtpClient ClienteSmtp = new();
            ClienteSmtp.CheckCertificateRevocation = false;
            ClienteSmtp.Connect(servidor,465,true);
            ClienteSmtp.Authenticate(GmailUser, Gmailpassword);
            ClienteSmtp.Send(mensaje);
            ClienteSmtp.Disconnect(true);
            return RedirectToAction(nameof(Index));
        }

    }
}