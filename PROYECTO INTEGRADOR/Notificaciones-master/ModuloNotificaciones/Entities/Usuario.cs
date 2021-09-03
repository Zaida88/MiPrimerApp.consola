using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloNotificaciones.Entities
{
    public class Usuario
    {
        [DisplayName("Cedula")]
        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public List<Producto> Productos { get; set; }
        [NotMapped]
        public string CedulaNombre
        {
            get { return $"{UsuarioId} {"-"} {Nombre}"; }
        }
    }
}
