using System;

namespace class04
{
    class tiraComicaMafalda
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido \nConoces a mafalda:");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            var apellido = Console.ReadLine();

            int edad = IngresarEdad();

            Console.Write("¿Conoces a Mafalda?: ");
            bool laConoces = Console.ReadLine().ToUpper() == "SI";

            int AñoEstreno = IngresarAñoEstreno();

            int UltimaEdicion = IngresarUltimaEdicion();

            int CuantasLeiste = IngresarCuantasLeiste();

            Console.Write("¿Que te parece la muñeca que protagoniza Mafalda?: ");
            string Muñeca = Console.ReadLine();

            Console.Write("¿Conservas las tiras de Mafalda?: ");
            bool conservas = Console.ReadLine().ToUpper() == "SI";

            int LeidasPorDia = IngresarLeidasPorDia();


            var tiraComicaMafalda = new tiraComicaMafaldaBase
            {
                nombre = nombre,
                apellido = apellido,
                edad = edad,
                laConoces = laConoces,
                AñoEstreno = AñoEstreno,
                UltimaEdicion = UltimaEdicion,
                CuantasLeiste = CuantasLeiste,
                Muñeca = Muñeca,
                conservas = conservas,
                LeidasPorDia = LeidasPorDia,
            };

            Console.WriteLine("Usted ingreso lo siguiente: ");
            Console.WriteLine($"Nombre: {tiraComicaMafalda.nombre}");
            Console.Write($"Segundo nombre: {tiraComicaMafalda.apellido}" + "\n");
            Console.WriteLine($"Apellido: {tiraComicaMafalda.edad}" + "\n");
            Console.Write($"Edad: {tiraComicaMafalda.laConoces}" + "\n");
            Console.Write($"Peso: {tiraComicaMafalda.AñoEstreno}" + "\n");
            Console.Write($"Estatura: {tiraComicaMafalda.UltimaEdicion}" + "\n");
            Console.Write($"Ciudad: {tiraComicaMafalda.CuantasLeiste}" + "\n");
            Console.Write($"Telefono: {tiraComicaMafalda.conservas}" + "\n");
            Console.Write($"Cual estu pasatiempo fvoarto: {tiraComicaMafalda.LeidasPorDia}" + "\n");
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
        static int IngresarAñoEstreno()
        {
            Console.Write("Cuando se estreno Mafalda: ");
            int AñoEstreno1;
            while (true)
            {
                string AñoEstreno = Console.ReadLine();
                if (!int.TryParse(AñoEstreno, out AñoEstreno1))
                {
                    Console.Write("Ingrese un valor numerico:");
                }
                else
                {
                    break;
                };
            };
            return AñoEstreno1;
        }
        static int IngresarUltimaEdicion()
        {
            Console.Write("Cuando fue el ultima estrno de Mafalda: ");
            int UltimaEdicion1;
            while (true)
            {
                string UltimaEdicion = Console.ReadLine();
                if (!int.TryParse(UltimaEdicion, out UltimaEdicion1))
                {
                    Console.Write("Ingrese un valor numerico:");
                }
                else
                {
                    break;
                };
            };
            return UltimaEdicion1;
        }
        static int IngresarCuantasLeiste()
        {
            Console.Write("Cuantas tiras leiste de Mafalda durante toda tu vida: ");
            int CuantasLeiste1;
            while (true)
            {
                string CuantasLeiste = Console.ReadLine();
                if (!int.TryParse(CuantasLeiste, out CuantasLeiste1))
                {
                    Console.Write("Ingrese un valor numerico:");
                }
                else
                {
                    break;
                };
            };
            return CuantasLeiste1;
        }
        static int IngresarLeidasPorDia()
        {
            Console.Write("Cuantas tiras leiste de Mafalda por dia: ");
            int LeidasPorDia1;
            while (true)
            {
                string LeidasPorDia = Console.ReadLine();
                if (!int.TryParse(LeidasPorDia, out LeidasPorDia1))
                {
                    Console.Write("Ingrese un valor numerico:");
                }
                else
                {
                    break;
                };
            };
            return LeidasPorDia1;
        }
    }
}
