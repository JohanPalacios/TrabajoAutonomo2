using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    interface IDescuento
    {
        /*PRINCIPIO SUSTITUCION DE LISKOV
    * EL DESCUENTO VARIA SEGUN EL CASO DEL CLIENTE
       */
        interface IDescuento
        {
            decimal Descuento();
        }
    }
}
