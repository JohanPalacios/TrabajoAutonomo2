using System;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientesSinRegistro clientesSinReistro = new ClientesSinRegistro();
            clientesSinReistro.Nombres = "johan p";
            clientesSinReistro.Apellido = "palaciios";
            clientesSinReistro.NumeroCedula = "11112";
            clientesSinReistro.Email = "aaaaa.com";
            clientesSinReistro.Contrasenia = "aaa";
            clientesSinReistro.CiudadDeFacturacion = "Esmeraldas";
            clientesSinReistro.FechaActual = "23/12/2019";

            Imprimir listadoClientes = new Imprimir();
            listadoClientes.ListaClientes.Add(clientesSinReistro);
            listadoClientes.ImprimirlistadoCliente();

            CrearStockProductos crearStockProductos = new CrearStockProductos();
            crearStockProductos.GeneraProductos();
            crearStockProductos.ImprimirListaProductos();

            Factura carrito = new Factura();
             
            string opcion;
            do
            {
                Console.WriteLine("inrese el codio de producto");
                int codio = int.Parse(Console.ReadLine());
                DetalledeFactura detallecarrito = new DetalledeFactura();
                detallecarrito.ProductoCarrito = crearStockProductos.StockProductos[codio - 1];
                Console.WriteLine("inrese la cantidad de productos eleidos");
                detallecarrito.Cantidad = Convert.ToInt32(Console.ReadLine());
                carrito.Detalle.Add(detallecarrito);
                Console.WriteLine("escriba A para seuir areando productos y S para salir");
                opcion = Console.ReadLine();
            } while (opcion != "S");

             
            listadoClientes.ImprimirlistadoCliente();
            Console.WriteLine("productos en el carrito de compras");
            Console.WriteLine("Descripcion\t\tCantidad\tPrecio");
           
            foreach (var item in carrito.Detalle)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}",
                    item.ProductoCarrito.Codigo, item.ProductoCarrito.Descripcion, item.Cantidad, item.ProductoCarrito.Precio);
            }
                carrito.CalcularSubtotal();
                carrito.CalcularDescuento();          
                carrito.CalcularTotal();
                Console.WriteLine("SUBTOTAL");
                Console.WriteLine(carrito.SubTotal);
                Console.WriteLine("DESCUENTO");
                Console.WriteLine(carrito.Descuento);
                Console.WriteLine("TOTAL");
                Console.WriteLine(carrito.Total);
               
            }          
        }
    }

