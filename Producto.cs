using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatter2Impuestos
{
    public abstract class Producto : IVisitable
    {
        private double precio;

        protected Producto(double _precio)
        {
            Precio = _precio;
        }

        public double Precio { get => precio; set => precio = value; }

        public abstract double Aceptar(IVisitor v);
    }
}
