using Inyeccion.SALE;

namespace Inyeccion
{ 
    public class Pacifico: IPay
    {
        public string Pay(Sale sale)
        {
            return $"Tarjeta del Pacifico con número: {sale.IdTarjeta}, Su pago fue de: {sale.Monto}";
        }

    }
}
