using System;

namespace MiPrimeraApp.consola //este nombre sirve para que si alguien quiere utilizar mi trabajo pueda acceder con ese nombre --> using MiPrimeraApp.consola
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
            Console.Write("Ingrese su edad: ");
            string edad = Console.ReadLine();
            int edad1 = int.Parse(edad);
            Console.Write("Ingrese su peso: ");
            float peso = float.Parse(Console.ReadLine());
            Console.Write("Ingrese su estatura: ");
            float estatura = float.Parse(Console.ReadLine());
            Console.Write("Ingrese ciudad de nacimiento: ");
            var ciudad = Console.ReadLine();
            Console.Write("Ingrese numero telefonico: ");
            string telefono = Console.ReadLine();
            int telefono1 = int.Parse(telefono);
            Console.Write("Ingrese tipo de sangre");
            var tipo_Snagre = Console.ReadLine();

            
            var persona = new PersonaBase();
            persona.nombre = nombre;
            persona.nombre2 = nombre2;
            persona.apellido = apellido;
            persona.apellido2 = apellido2;
            persona.edad = edad1;
            persona.peso = peso;
            persona.estatura = estatura;
            persona.ciudad = ciudad;
            persona.telefono = telefono1;
            persona.tipo_Sangre = tipo_Snagre;
            Console.WriteLine("Usted ingreso lo siguiente: ");
            Console.WriteLine("Nombre: " + persona.nombre);
            Console.Write("Segundo nombre: " + persona.nombre2);
            Console.WriteLine("Apellido: " + persona.apellido);
            Console.Write("Segundo apellido: " + persona.apellido2);
            Console.Write("Edad: " + persona.edad + "\n");
            Console.Write("Peso: " + persona.peso + "\n\n");
            Console.Write("Estatura: " + persona.estatura + "\n\n");
            Console.Write("Ciudad: " + persona.ciudad + "\n\n");
            Console.Write("Telefono: " + persona.telefono + "\n\n");
            Console.Write("Tipo de sangre: " + persona.tipo_Sangre + "\n\n");
            Console.Write("Muchas gracias :) \nDigite cualquier tecla para terminar. ");
            Console.ReadKey();
        }
        public void Metodo(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Hola {0} {1} {0}" + args[0] + args[1]);
            }
            else
            {
                Console.WriteLine("Hola Desconocido.");
            }
            Console.WriteLine("¿Còmo estas?");
            var estado = Console.ReadLine();
            Console.WriteLine("mmmm, entiendo ");
            Console.ReadLine();
        }
    }
}