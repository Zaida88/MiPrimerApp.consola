using System;

namespace class03
{
    class peliculasAnimadas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la seccion de peliculas Animadas");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            var apellido = Console.ReadLine();

            Console.Write("Ingrese el nombre de la primera pelicula animada que vio: ");
            var nombrePelicula = Console.ReadLine();

            int edad = IngresarEdad();

            Console.Write("¿Que peñicula animada te hizo llorar?: ");
            var peliculaTriste = Console.ReadLine();

            Console.Write("¿Cual fue la pelicula que mas veces viste?: ");
            var peliculaVista = Console.ReadLine();

            int VecesPElicula = IngresarVecesPElicula();

            Console.Write("¿Viste la pelicula de los pitufos?:");
            bool PeliPreg = Console.ReadLine().ToUpper() == "SI";

            Console.Write("¿En que plataforma ves mas peliculas?: ");
            string plataformas = Console.ReadLine();

            int peliDia = IngresarpeliDia();

            var peliculasAnimadas = new peliculasAnimadasBase
            {
                nombre = nombre,
                apellido = apellido,
                nombrePelicula = nombrePelicula,
                edad = edad,
                peliculaTriste = peliculaTriste,
                peliculaVista = peliculaVista,
                VecesPElicula = VecesPElicula,
                PeliPreg = PeliPreg,
                plataformas = plataformas,
                peliDia = peliDia,

            };

            Console.WriteLine("Usted ingreso lo siguiente: ");
            Console.WriteLine($"Nombre: {peliculasAnimadas.nombre}");
            Console.Write($"Apellido: {peliculasAnimadas.apellido}" + "\n");
            Console.WriteLine($"Su primer pelicula animada: {peliculasAnimadas.nombrePelicula}");
            Console.Write($"Edad en que la vio: {peliculasAnimadas.edad}" + "\n");
            Console.Write($"La pelicula que te hizo llorar: {peliculasAnimadas.peliculaTriste}" + "\n");
            Console.Write($"La pelicula que mas veces viste: {peliculasAnimadas.peliculaVista}" + "\n");
            Console.Write($"Cuantas veces la viste: {peliculasAnimadas.VecesPElicula}" + "\n");
            Console.Write($"Viste la pelicula los pitufos: {peliculasAnimadas.PeliPreg }" + "\n");
            Console.Write($"En que plataforma ves peliculas: {peliculasAnimadas.plataformas}" + "\n");
            Console.Write($"Cual estu pasatiempo fvoarto: {peliculasAnimadas.peliDia}" + "\n");
            Console.Write("Muchas gracias :D \nDigite cualquier tecla para terminar. ");
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
                    Console.Write("Ingrese un valor numerico:");
                }
                else
                {
                    break;
                };
            };
            return edad1;
        }
        static int IngresarVecesPElicula()
        {
            Console.Write("¿Cuantas peiculas asvisto asta el momento?: ");
            int VecesPElicula1;
            while (true)
            {
                string VecesPElicula = Console.ReadLine();
                if (!int.TryParse(VecesPElicula, out VecesPElicula1))
                {
                    Console.Write("Ingrese un valor numerico:");
                }
                else
                {
                    break;
                };
            };
            return VecesPElicula1;
        }
        static int IngresarpeliDia()
        {
            Console.Write("¿Cuantas peiculas ves por día?: ");
            int peliDia1;
            while (true)
            {
                string peliDia = Console.ReadLine();
                if (!int.TryParse(peliDia, out peliDia1))
                {
                    Console.Write("Ingrese un valor numerico:");
                }
                else
                {
                    break;
                };
            };
            return peliDia1;
        }
    };

}