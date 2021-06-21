using System;

namespace class05
{
    class PeliculasAccion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido \n Preguntas sobre peliculas de accion:");
            Console.Write("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            var apellido = Console.ReadLine();

            int edad = IngresarEdad();

            Console.Write("Cual es su pelicula de accion favorita: ");
            string peliFavori = Console.ReadLine();

            int repeticionPeli = IngresarRepeticionPeli();

            int AñoEstreno = IngresarAñoEstreno();

            Console.Write("¿Usted a visto Avengers?: ");
            bool pregunta1 = Console.ReadLine().ToUpper() == " SI ";

            Console.Write("¿Que pelicula de accion no le gusto?: ");
            var dislikepeli = Console.ReadLine();

            int AccionVistas = IngresarAccionVistas();

            int AvengersVistas = IngresarAvengersVistas();

            var peliculasAccion = new peliculasAccionBase
            {
                nombre = nombre,
                apellido = apellido,
                edad = edad,
                peliFavori = peliFavori,
                repeticionPeli = repeticionPeli,
                AñoEstreno = AñoEstreno,
                pregunta1 = pregunta1,
                dislikepeli = dislikepeli,
                AccionVistas = AccionVistas,
                AvengersVistas = AvengersVistas,
            };

            Console.WriteLine("Usted ingreso lo sigiente sobre peliculas de accion: ");
            Console.WriteLine($"Nombre: {peliculasAccion.nombre}");
            Console.WriteLine($"Apellido: {peliculasAccion.apellido}");
            Console.Write($"Edad: {peliculasAccion.edad}" + "\n");
            Console.Write($"Pelicula favorita de accion: {peliculasAccion.peliFavori}");
            Console.Write($"¿Cuantas veces se vio su pelicula favorita?: {peliculasAccion.repeticionPeli}");
            Console.Write($"Año de estreno de su pelicula favorita {peliculasAccion.AñoEstreno}" + "\n");
            Console.Write($"¿Usted a visto Avengers?: {peliculasAccion.pregunta1} " + "\n");
            Console.Write($"Cual fue la pelicula que menos le gusto: {peliculasAccion.dislikepeli}" + "\n");
            Console.Write($"Cuantas peliculas de accion a visto: {peliculasAccion.AccionVistas}" + "\n");
            Console.Write($"Cuantas de las 9 peliculas de avengers a visto: {peliculasAccion.AvengersVistas}" + "\n");
            Console.Write("Muchas gracias por su participacion :D \nDigite cualquier tecla para finalizar. ");
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
        static int IngresarRepeticionPeli()
        {
            Console.Write("¿Cuantas veces se vio su pelicula favorita?: ");
            int repeticionPeli1;
            while (true)
            {
                string repeticionPeli = Console.ReadLine();
                if (!int.TryParse(repeticionPeli, out repeticionPeli1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };
            };
            return repeticionPeli1;
        }
        static int IngresarAñoEstreno()
        {
            Console.Write("¿En que año se estreno su la pelicula favorita?: ");
            int AñoEstreno1;
            while (true)
            {
                string AñoEstreno = Console.ReadLine();
                if (!int.TryParse(AñoEstreno, out AñoEstreno1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };
            };
            return AñoEstreno1;
        }
        static int IngresarAccionVistas()
        {
            Console.Write("¿Cuantas peliculas de accion a visto hasta el moemnto?: ");
            int AccionVistas1;
            while (true)
            {
                string AccionVistas = Console.ReadLine();
                if (!int.TryParse(AccionVistas, out AccionVistas1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };
            };
            return AccionVistas1;
        }
        static int IngresarAvengersVistas()
        {
            Console.Write("¿Cuantas de las 9 peliculas de avenger se a visto?: ");
            int AvengersVistas1;
            while (true)
            {
                string AvengersVistas = Console.ReadLine();
                if (!int.TryParse(AvengersVistas, out AvengersVistas1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };
            };
            return AvengersVistas1;
        }
    }
}
