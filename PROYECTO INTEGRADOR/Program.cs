using System;

namespace ProyectoIntegrador
{
    partial class UmbrellaTechnology
    {
        public static void Main(string[] argumentos)
        {
            Console.Write(" Bienvenido a Umbrella Tecnology ");

            Usuario usuario = new();
            usuario.Cedula = 146525256;
            usuario.Nombre = "Liseth";
            usuario.Edad = 21;
            usuario.Correo = "";
            usuario.Contraseña = "cvgcg25879";

            Producto producto = new();
            producto.IdProduc = 2;
            producto.Marca = "Asus";
            producto.EnalaceProduc = "";
            producto.Descripcion = "";
        }
    }

}
