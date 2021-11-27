using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatter2Impuestos
{
   public class IVA : IVisitor
    {
        private double _iva21= 1.21d;
        private double _iva105 = 1.105d;

        public double Visitar(ProductoClase1 p)
        {
            return p.Precio * _iva21;
        }

        public double Visitar(ProductoClase2 p)
        {
            return p.Precio * _iva105;
        }
    }
}
