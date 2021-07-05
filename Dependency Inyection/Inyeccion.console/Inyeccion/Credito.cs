using Inyeccion.SALE;
using System;

namespace Inyeccion
{
    public class Credito: IPay
    {
       public string Pay(Sale sale)
       {
            return $"Tarjeta de credito número: {sale.IdTarjeta}, Su pago fue de: {sale.Monto}";
       }
    }
}
