using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class DetalledeFactura
    {
         public DetalledeFactura()
         {
            
         }

        public  Producto ProductoCarrito { get; set; }
        public int Cantidad { get; set; }

    }
}
