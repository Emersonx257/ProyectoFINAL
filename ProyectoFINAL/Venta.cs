using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFINAL
{
    internal class Venta
    {
        public int NoVenta { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public double cantidad { get; set; } 
        public double precio { get; set; }

        public Venta(int noVenta, string fecha, string hora, double cantidad, double precio)
        {
            NoVenta = noVenta;
            this.fecha = fecha;
            this.hora = hora;
            this.cantidad = cantidad;
            this.precio = precio;
        }
    }
}
