using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFINAL
{
    internal class Bomba
    {
        public int id {  get; set; }
        public string name { get; set; }
        public double cantidadLitros { get; set; }
        public bool estado {  get; set; }

        public int Usado { get; set; }
        public int NoVenta { get; set; }

        public Bomba(string name, double cantidadLitr)
        {
            
            this.name = name;
            this.cantidadLitros = cantidadLitr;
            
        }



    }
}
