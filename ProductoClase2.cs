using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatter2Impuestos
{
    public class ProductoClase2 : Producto
    {
        public ProductoClase2(double _precio) : base(_precio)
        {
        }
        public override double Aceptar(IVisitor v)
        {
           return v.Visitar(this);
        }
    }
}
