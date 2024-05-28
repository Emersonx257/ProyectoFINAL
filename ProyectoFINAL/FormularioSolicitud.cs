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
    public partial class FormularioSolicitud : Form
    {

        public FormularioSolicitud(double precio)
        {
            InitializeComponent();
            txtInfoPrecio.Text = precio.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtLitros_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrecio.Text) || !string.IsNullOrEmpty(txtLitros.Text))
            {
                Solicitud.id = (int)numericBomba.Value;
                Solicitud.precio = double.Parse(txtPrecio.Text);
                Solicitud.litros = double.Parse(txtLitros.Text);
                this.Dispose();
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text.CompareTo("") != 0)
            {
                txtLitros.ReadOnly = true;
                txtLitros.Text = (double.Parse(txtPrecio.Text) * (1 / double.Parse(txtInfoPrecio.Text))).ToString();
            }
            else
                txtLitros.Text = "";
        }

        private void numericBomba_ValueChanged(object sender, EventArgs e)
        {
            if(numericBomba.Value > 4)
            {
                numericBomba.Value = 1;
            }
            else if(numericBomba.Value < 1)
            {
                numericBomba.Value = 1;
            }
        }
    }
}
