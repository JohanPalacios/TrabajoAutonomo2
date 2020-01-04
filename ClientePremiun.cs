using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class ClientePremiun: Cliente , IUsuarioC ,IDescuento
    {
       public int Decsuento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Apellidos()
        {
            throw new NotImplementedException();
        }

        // Aqui se esta implementando la interfaz


        public decimal CalcularDescuento()
        {
            return 0;
        }

        public string Cedula()
        {
            throw new NotImplementedException();
        }

        public string Contrasena()
        {
            throw new NotImplementedException();
        }

        string IUsuarioC.Email()
        {
            throw new NotImplementedException();
        }

        string IUsuarioC.Nombres()
        {
            throw new NotImplementedException();
        }
    }
}

