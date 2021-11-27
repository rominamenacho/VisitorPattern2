﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatter2Impuestos
{
    public class ProductoClase1 : Producto
    {
        public ProductoClase1(double _precio) : base(_precio)
        {
        }

        public override double Aceptar(IVisitor v)
        {
            return v.Visitar(this);
        }
    }
}
