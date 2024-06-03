using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFINAL
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Venta> list = new List<Venta>();
            foreach (Venta venta in Diaria.ventasDia)
            {
                list.Add(venta);
            }
            VentasDias.ventasDias.Add(list);
            Diaria.ventasDia.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cantidades = 0, index = 0;
            cantidades = ListBombas.Bombas[0].Usado;
            foreach (Bomba b in ListBombas.Bombas)
            {
                if (cantidades < b.Usado)
                {
                    cantidades = b.Usado;
                    index = ListBombas.Bombas.IndexOf(b);
                }
            }

            Bomba masUsada = ListBombas.Bombas[index];

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = masUsada;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int cantidades = 0, index = 0;
            cantidades = ListBombas.Bombas[0].Usado;
            foreach (Bomba b in ListBombas.Bombas)
            {
                if (cantidades > b.Usado)
                {
                    cantidades = b.Usado;
                    index = ListBombas.Bombas.IndexOf(b);
                }
            }

            Bomba menosUsada = ListBombas.Bombas[index];

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = menosUsada;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Venta> TanqueLleno = new List<Venta>();
            List<Venta> Listado = new List<Venta>();
            foreach (List<Venta> dias in VentasDias.ventasDias)
            {
                Listado = dias;
                foreach (Venta v in Listado)
                {
                    if (v.tipo == 1)
                    {
                        TanqueLleno.Add(v);
                    }
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = TanqueLleno;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Venta> Prepago = new List<Venta>();
            List<Venta> Listado = new List<Venta>();
            foreach (List<Venta> dias in VentasDias.ventasDias)
            {
                Listado = dias;
                foreach (Venta v in Listado)
                {
                    if (v.tipo == 0)
                    {
                        Prepago.Add(v);
                    }
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = Prepago;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = Diaria.ventasDia;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            if (VentasDias.ventasDias != null)
            {
                List<Venta> vv = new List<Venta>();
                foreach (List<Venta> listVenta in VentasDias.ventasDias)
                {
                    foreach (Venta v in listVenta)
                    {
                        vv.Add(v);
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = vv;
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = Diaria.ventasDia;
            }
        }
    }
}
