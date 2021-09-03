using System;

namespace Arbol3
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new()
            {
                Valor = "",
                Hijos =
                {

                  new Nodo
                  {
                   Valor="1"
                  },
                  new Nodo
                  {
                   Valor ="2"
                  },
                  new Nodo
                  {
                   Valor ="3"
                  }
                }
            };
            ManejadorArbol manejadorArbol = new();
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz));
        }
    }
}
