using System.Linq;

namespace Arbol3
{
    class ManejadorArbol
    {
        public string ImprimirArbol(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return ImprimirArbol(nodo.Hijos[0]) + ImprimirArbol(nodo.Hijos[1]) + ImprimirArbol(nodo.Hijos[2]);
        }
    }
}