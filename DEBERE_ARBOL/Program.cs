using System;

namespace Arbol3
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new()
            {

                Valor = "+",
                nivel = 0,
                Hijos ={
                    new Nodo{
                        Valor="/",
                        Hijos={
                            new Nodo{
                                Valor="5"
                            },
                            new Nodo{
                                Valor ="9"
                            }
                        }
                    },
                    new Nodo{
                        Valor ="*",
                        Hijos={
                            new Nodo{
                                Valor="7"
                            },
                            new Nodo{
                                Valor="3"
                            }
                        }
                    },
                    new Nodo{
                        Valor="+",
                        Hijos={
                            new Nodo{
                                Valor="1"
                            },
                            new Nodo{
                                Valor="6"
                            }
                        }
                    }
                },
            };
            manejadorArbol manejadorArbol = new();
            Console.WriteLine($"El número de hojas es de : {Arbol3.manejadorArbol.ContarHojas(raiz)}");
            Console.WriteLine($"El número de niveles es de : {Arbol3.manejadorArbol.ContarNiveles(raiz)}");
            Console.WriteLine($"El número de nodos es de : {Arbol3.manejadorArbol.ContarNodos(raiz)}");
        }
    }
}
