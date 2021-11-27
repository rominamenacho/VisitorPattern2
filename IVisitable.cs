using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatter2Impuestos
{
    interface IVisitable
    {
         double Aceptar(IVisitor v);
    }
}
