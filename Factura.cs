using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Factura  
    {
      
        public decimal SubTotal { get; set; }
        public decimal Descuento{ get; set; }
        public decimal SubTotal2 { get; set; }
        public decimal Total{ get; set; }
        public decimal Iva { get; set; }
       
        public Factura()
        {
            this.Detalle = new List<DetalledeFactura>();
        }
      

        public List<DetalledeFactura> Detalle { get; set; }

       
        public void CalcularSubtotal()
        {
            decimal subtotal = 0;
            foreach (var item in this.Detalle)
            {
                subtotal = subtotal + (item.Cantidad * item.ProductoCarrito.Precio);
            }
            this.SubTotal = subtotal;
        }
        public void CalcularDescuento()
        {
            if (this.SubTotal > 100)
            {
                this.Descuento = this.SubTotal * 0.05M;
            }   
            else
            {
                this.Descuento = 0;
            }
        }

        public void CalcularTotal()
        {
            this.Total =( this.SubTotal - this.Descuento )+this.Iva;
        }
        
    }
}
