using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFINAL
{
    public partial class CambiarPrecio : Form
    {
        public CambiarPrecio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double precio = double.Parse(textBox1.Text);
                Precio.precio = precio;
            }catch { }
        }
    }
}
