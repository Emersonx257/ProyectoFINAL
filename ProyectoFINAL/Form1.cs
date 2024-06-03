using System.IO.Ports;
using Newtonsoft.Json; 

namespace ProyectoFINAL
{
    public partial class Form1 : Form
    {



        Bomba[] bombas;
        string portName = "COM7";
        int baudRate = 9600;
        SerialPort serialPort;
        List<Venta> ventaList;
        public Form1()
        {
            InitializeComponent();
            Precio.precio = 10;
            bombas = new Bomba[4];
            bombas[0] = new Bomba("Bomba 1", 0);
            bombas[1] = new Bomba("Bomba 2", 0);
            bombas[2] = new Bomba("Bomba 3", 0);
            bombas[3] = new Bomba("Bomba 4", 0);

            serialPort = new SerialPort();
            serialPort.BaudRate = baudRate;
            serialPort.PortName = portName;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            try
            {
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.DataBits = 8;
                serialPort.Handshake = Handshake.None;
                serialPort.RtsEnable = true;
                serialPort.Open();
            }
            catch { }
            ventaList = new List<Venta>();





        }



        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadLine();
                this.BeginInvoke(new Action(() =>
                {
                    ProcesarDatos(data);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los datos: " + ex.Message);
            }
        }
        public struct Bomb
        {
            public bool active;
            public bool Canceled;
            public float initialDistance;
            public float targetPercentage;
            public float targetDistance;
            public float LitrosLlevados;
            public int NoVenta;
            public int tipo;
        };

        private void ProcesarDatos(string data)
        {
            try
            {
                // Intentar deserializar el JSON
                var datas = JsonConvert.DeserializeObject<Bomb>(data);

                // Si la deserialización tiene éxito, procesar los datos JSON
               
                    double LL = datas.LitrosLlevados;
                    int idVenta = datas.NoVenta;
                    int tipos = datas.tipo;
                    if (tipos == 1)
                    {
                        
                        {
                        
                        if (idVenta == (Diaria.ventasDia.Count - 1))
                            {
                            Venta v = Diaria.ventasDia[idVenta];
                            v.cantidad = LL;
                                v.precio = LL * Precio.precio;
                                int index = Diaria.ventasDia.IndexOf(v);
                                Diaria.ventasDia[index] = v;
                                
                            }
                        }
                    }
                    // Muestra los datos en un MessageBox o actualiza la UI
                    MessageBox.Show($"Litros {LL} IDventa {idVenta}");

                
            }
            catch (JsonException)
            {
                // Si la deserialización falla, mostrar el mensaje como texto plano
                MessageBox.Show(data);
            }
            catch (Exception ex)
            {
                // Manejar cualquier otro tipo de excepción
                MessageBox.Show("Error al procesar los datos: " + ex.Message);
            }
        }





        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Llenarinfo()
        {
            try
            {
                if (Solicitud.id == 1)
                {
                    bombas[0].id = 1;
                    bombas[0].estado = true;
                    bombas[0].cantidadLitros = Solicitud.litros;
                    bombas[0].tipo = Solicitud.tipo;
                    bombas[0].Usado++;

                    Venta venta = new Venta(Solicitud.cliente, DateTime.Now.ToString("d"), DateTime.Now.ToString("t"), Solicitud.litros, Solicitud.precio, Solicitud.tipo);
                    Diaria.ventasDia.Add(venta);
                    // label4.Text = Solicitud.litros.ToString();
                    // label5.Text = Solicitud.precio.ToString();
                }
                else if (Solicitud.id == 2)
                {
                    bombas[1].id = 2;
                    bombas[1].estado = true;
                    bombas[1].cantidadLitros = Solicitud.litros;
                    bombas[1].tipo = Solicitud.tipo;
                    bombas[1].Usado++;

                    Venta venta = new Venta(Solicitud.cliente, DateTime.Now.ToString("d"), DateTime.Now.ToString("t"), Solicitud.litros, Solicitud.precio, Solicitud.tipo);
                    Diaria.ventasDia.Add(venta);
                    // label7.Text = Solicitud.litros.ToString();
                    // label6.Text = Solicitud.precio.ToString();
                }
                else if (Solicitud.id == 3)
                {
                    bombas[2].id = 3;
                    bombas[2].estado = true;
                    bombas[2].cantidadLitros = Solicitud.litros;
                    bombas[2].tipo = Solicitud.tipo;
                    bombas[2].Usado++;

                    Venta venta = new Venta(Solicitud.cliente, DateTime.Now.ToString("d"), DateTime.Now.ToString("t"), Solicitud.litros, Solicitud.precio, Solicitud.tipo);
                    Diaria.ventasDia.Add(venta);
                    // label11.Text = Solicitud.litros.ToString();
                    //   label10.Text = Solicitud.precio.ToString();
                }
                else if (Solicitud.id == 4)
                {
                    bombas[3].id = 4;
                    bombas[3].estado = true;
                    bombas[3].cantidadLitros = Solicitud.litros;
                    bombas[3].tipo = Solicitud.tipo;
                    bombas[3].Usado++;
                    Venta venta = new Venta(Solicitud.cliente, DateTime.Now.ToString("d"), DateTime.Now.ToString("t"), Solicitud.litros, Solicitud.precio, Solicitud.tipo);
                    Diaria.ventasDia.Add(venta);
                    //  label15.Text = Solicitud.litros.ToString();
                    //  label14.Text = Solicitud.precio.ToString();
                }
                Solicitud.cliente = null;
                Solicitud.precio = 0;
                Solicitud.litros = 0;
                Solicitud.id = 0;
                Solicitud.tipo = 0;

            }
            catch { }
        }

        private void realizarSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioSolicitud solicitud = new FormularioSolicitud(Precio.precio);
            solicitud.ShowDialog();
            if (Solicitud.id != 0)
            {
                Llenarinfo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //  Venta venta = new Venta(bombas[0].id, DateTime.Now.ToString("d"), DateTime.Now.ToString("s"), Solicitud.litros, Solicitud.precio);
            if (serialPort.IsOpen)
            {
                try
                {
                    string mesanje = JsonConvert.SerializeObject(bombas, Formatting.Indented); ;
                    // MessageBox.Show(mesanje);
                    serialPort.WriteLine(mesanje);

                    // textBox1.Text = (mesanje);

                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    serialPort.Open();
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    string mesanje = JsonConvert.SerializeObject(bombas, Formatting.Indented); ;
                    // MessageBox.Show(mesanje);
                    serialPort.WriteLine(mesanje);

                    //   textBox1.Text = (mesanje);
                    for (int i = 0; i < 4; i++)
                    {
                        bombas[i].id = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    serialPort.Open();
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    string mesanje = JsonConvert.SerializeObject(bombas, Formatting.Indented); ;
                    // MessageBox.Show(mesanje);
                    serialPort.WriteLine(mesanje);

                    // textBox1.Text = (mesanje);
                    for (int i = 0; i < 4; i++)
                    {
                        bombas[i].id = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    serialPort.Open();
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    string mesanje = JsonConvert.SerializeObject(bombas, Formatting.Indented); ;
                    // MessageBox.Show(mesanje);
                    serialPort.WriteLine(mesanje);

                    // textBox1.Text = (mesanje);
                    for (int i = 0; i < 4; i++)
                    {
                        bombas[i].id = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    serialPort.Open();
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void VerificarEntradas_Tick(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort.Close();
            }
            catch { }
        }

        private void verVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBombas.Bombas = new List<Bomba>(bombas);
            Ventas ventas = new Ventas();
            ventas.Show();
        }

        private void precioLitroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
