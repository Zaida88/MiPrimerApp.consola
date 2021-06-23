using System;

namespace MiPrimeraApp.consola 
{
    class Programcd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();

            Console.Write("Ingrese su segundo nombre: ");
            var nombre2 = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            var apellido = Console.ReadLine();

            Console.Write("Ingrese su segundo apellido: ");
            var apellido2 = Console.ReadLine();

            int edad = IngresarEdad();

            Console.Write("Ingrese su peso: ");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("Ingrese su estatura: ");
            float estatura = float.Parse(Console.ReadLine());

            Console.Write("Ingrese ciudad de nacimiento: ");
            var ciudad = Console.ReadLine();

            int telefono = IngresarTelefono();

            Console.Write("Ingrese tipo de sangre");
            var tipo_Snagre = Console.ReadLine();


            var persona = new Persona
            {
                nombre = nombre,
                nombre2 = nombre2,
                apellido = apellido,
                apellido2 = apellido2,
                edad = edad,
                peso = peso,
                estatura = estatura,
                ciudad = ciudad,
                telefono = telefono,
                tipo_Sangre = tipo_Snagre
            };
            Console.WriteLine("Usted ingreso lo siguiente: ");
            Console.WriteLine($"Nombre: {persona.nombre}");
            Console.Write($"Segundo nombre: {persona.nombre2}" + "\n");
            Console.WriteLine($"Apellido: {persona.apellido}");
            Console.Write($"Segundo apellido: {persona.apellido2}" + "\n");
            Console.Write($"Edad: {persona.edad}" + "\n");
            Console.Write($"Peso: {persona.peso}" + "\n");
            Console.Write($"Estatura: {persona.estatura}" + "\n");
            Console.Write($"Ciudad: {persona.ciudad }" + "\n");
            Console.Write($"Telefono: {persona.telefono}" + "\n");
            Console.Write($"Cual estu pasatiempo fvoarto: {persona.tipo_Sangre}" + "\n");
            Console.Write("Muchas gracias :) \nDigite cualquier tecla para terminar. ");
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
        static int IngresarTelefono()
        {
            Console.Write("Ingrese su numero de telefono: ");
            int telefono1;
            while (true)
            {
                string edad = Console.ReadLine();
                if (!int.TryParse(edad, out telefono1))
                {
                    Console.Write("Ingrese un valor numerico:");
                }
                else
                {
                    break;
                };
            };
            return telefono1;
        }
    }
}