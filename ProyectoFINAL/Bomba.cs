using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFINAL
{
    internal class Bomba
    {
        private static int count = 0;
        public int id {  get; set; }
        public string name { get; set; }
        public double cantidadLitros { get; set; }
        public double precioSolicitado { get; set; }
        public static double precioLitros { get; set; }

        public bool estado {  get; set; }

        public Bomba(string name, double cantidadLitr)
        {
            id = count++;
            this.name = name;
            this.cantidadLitros = cantidadLitr;
            
        }



    }
}
