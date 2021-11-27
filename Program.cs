using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatter2Impuestos
{
    class Program
    {
        static void Main(string[] args)
        {
            IVisitor visitor = new IVA();
            Producto prod1 = new ProductoClase1(100);
            Producto prod2 = new ProductoClase2(100);

            Console.WriteLine ("iva en prod1: $" + prod1.Aceptar(visitor));

            Console.WriteLine("iva en prod2: $" + prod2.Aceptar(visitor));

            Console.ReadKey();
        }
    }
}
