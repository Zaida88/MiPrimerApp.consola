using Inyeccion.SALE;
using System;

namespace Inyeccion
{
    public class Pago
    {
        IPay _Pay;
        public Pago(IPay Pay)
        {
            _Pay = Pay;
        }
        public string MakePay(Sale sale)
        {
            return _Pay.Pay(sale);
        }
    }
}
