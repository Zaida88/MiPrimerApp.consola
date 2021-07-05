using Inyeccion.SALE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Inyeccion
{
    public interface IPay
    {
        public string Pay(Sale sale);
    }
}
