using System.Linq;

namespace Arbol3
{
    internal class manejadorArbol
    {
        internal static int ContarHojas(Nodo nodo)
        {
            int acumulador = 0;
            foreach (Nodo actual in nodo.Hijos)
            {
                acumulador += actual.Valor.Length + actual.Hijos.Count;
            }
            return acumulador;
        }
        internal static int ContarNodos(Nodo nodo)
        {
            int acumulador = 0;
            acumulador += nodo.nodoRaiz + nodo.Hijos.Count;
            foreach (Nodo actual in nodo.Hijos)
            {
                acumulador += actual.Hijos.Count;
            }
            return acumulador;
        }
        internal static int ContarNiveles(Nodo nodo)
        {
            int acumulador = 0;
            foreach (Nodo actual in nodo.Hijos)
            {
                acumulador += actual.Valor.Length;
            }
            return acumulador;
        }
    }
}