using System;
using Inyeccion.SALE;
using Unity;

namespace Inyeccion
{
    partial class Program
    {
        static Pago _pago;
        static void Main(string[] args)
        {
            Init();
            Console.WriteLine("Enviando pago...");
            Console.WriteLine(_pago.MakePay(new SALE.Sale { Monto = 1250, IdTarjeta = "1236567238" }));
            Console.WriteLine(_pago.MakePay(new SALE.Sale { Monto = 1500, IdTarjeta = "5123655608" }));
            Console.WriteLine("Su pago se realizado con exito con tarjeta de credito y tarjeta corriente.");
            Console.ReadKey();
        }
        static void Init()
        {
            var _container = new UnityContainer();
            _container.RegisterType<IPay, Pacifico >();
            _pago = _container.Resolve<Pago>();
        }
    }
}
