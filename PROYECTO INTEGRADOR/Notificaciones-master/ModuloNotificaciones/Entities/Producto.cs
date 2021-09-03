using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloNotificaciones.Entities
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public DateTime FechaRegistro { get; set; }
        [ForeignKey("Usuario")]
        [DisplayName("Cedula")]
        public string UsuarioId { get; set; }
        [DisplayName("Cedula")]
        public Usuario Usuario { get; set; }
    }
}
