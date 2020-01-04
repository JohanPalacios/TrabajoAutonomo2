using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    interface IUsuarioC
    {


        /*PRINCIPIO SEGREGACION DE INTERFACES
        */

        string Cedula();
        string Nombres();
        string Apellidos();
        string Email();
        string Contrasena();
    }
}
