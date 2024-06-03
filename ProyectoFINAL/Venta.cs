using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFINAL
{
    internal class Venta
    {
        private static int NoVetasLlevadas = 0;
        public int NoVenta { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public double cantidad { get; set; } 
        public double precio { get; set; }

        public string cliente { get; set; }

        public int tipo { get; set; }

        public Venta(string clienten, string fecha, string hora, double cantidad, double precio, int t)
        {
            NoVenta = NoVetasLlevadas++;
            this.fecha = fecha;
            this.hora = hora;
            this.cantidad = cantidad;
            this.precio = precio;
            this.cliente = clienten;
            this.tipo = t;
        }
    }
}
