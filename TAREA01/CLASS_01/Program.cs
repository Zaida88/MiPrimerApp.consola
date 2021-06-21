using System;

namespace Tarea01
{
    class Videojuego
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Bienvenido");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();

            Console.Write("Ingrese su segundo nombre: ");
            var nombre2 = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            var apellido = Console.ReadLine();

            Console.Write("Ingrese su segundo apellido: ");
            var apellido2 = Console.ReadLine();

            int edad = IngresarEdad();

            Console.Write("En que país vives: ");
            var país = Console.ReadLine();

            Console.Write("Ingrese ciudad de recidencia: ");
            var ciudadRecidencia = Console.ReadLine();

            Console.Write("¿Cual es tu videojuego favorito?: ");
            var juegoFavorito = Console.ReadLine();

            int TiempoDedicado = IngresarTiempoDedicado();

            int juegoPorDia = IngresarjuegoPorDia();

            var Videojuego = new VideojuegoBase
            {
                nombre = nombre,
                nombre2 = nombre2,
                apellido = apellido,
                apellido2 = apellido2,
                edad = edad,
                país = país,
                ciudadRecidencia = ciudadRecidencia,
                juegoFavorito = juegoFavorito,
                TiempoDedicado = TiempoDedicado,
                juegoPorDia = juegoPorDia,
            };

            Console.WriteLine("Usted ingreso lo siguiente: ");
            Console.WriteLine($"Nombre: {Videojuego.nombre}");
            Console.Write($"Segundo nombre: {Videojuego.nombre2}" + "\n");
            Console.WriteLine($"Apellido: {Videojuego.apellido}");
            Console.Write($"Segundo apellido: {Videojuego.apellido2}" + "\n");
            Console.Write($"Edad: {Videojuego.edad}" + "\n");
            Console.Write($"Peso: {Videojuego.país}" + "\n");
            Console.Write($"Estatura: {Videojuego.ciudadRecidencia}" + "\n");
            Console.Write($"Ciudad: {Videojuego.juegoFavorito }" + "\n");
            Console.Write($"Telefono: {Videojuego.TiempoDedicado}" + "\n");
            Console.Write($"Cuantos juegos juegas al dia: {Videojuego.juegoPorDia}" + "\n" + "\n");
            Console.Write("Muchas gracias :D \nDigite cualquier tecla para finalizar. ");
            Console.ReadKey();          
        }
        static int IngresarEdad()
        {
            Console.Write("Ingrese su edad: ");
            int edad1;
            while (true)
            {
                string edad = Console.ReadLine();
                if (!int.TryParse(edad, out edad1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };
            };
            return edad1;
        }
        static int IngresarTiempoDedicado()
        {
            Console.Write("¿Cuantas horas dedicas a tu juego faborito?: ");
            int TiempoDedicado1;
            while (true)
            {
                string TiempoDedicado = Console.ReadLine();
                if (!int.TryParse(TiempoDedicado, out TiempoDedicado1))
                {
                    Console.Write("Ingrese un valor numerico entero:");
                }
                else
                {
                    break;
                };
            };
            return TiempoDedicado1;
        }
        static int IngresarjuegoPorDia()
        {
            Console.Write("¿Cuantos videojuegos juegas al dia?: ");
            int juegoPorDia1;
            while (true)
            {
                string juegoPorDia = Console.ReadLine();
                if (!int.TryParse(juegoPorDia, out juegoPorDia1))
                {
                    Console.Write("Ingrese un valor numerico entero:");
                }
                else
                {
                    break;
                };
            };
            return juegoPorDia1;
        }
    }
}
       