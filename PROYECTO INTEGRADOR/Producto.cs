using System.Collections.Generic;

namespace ProyectoIntegrador
{

    public class Producto
    {
        public int IdProduc { get; set; }
        public List<Producto> Tipo { get; set; }
        public string Marca { get; set; }
        public string EnalaceProduc { get; set; }
        public string Descripcion { get; set; }
    }
}
