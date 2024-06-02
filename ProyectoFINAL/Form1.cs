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

                    ProcesarDatosJson(data);
                }));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al leer los datos: " + ex.Message);
            }
        }

        private void ProcesarDatosJson(string data)
        {
            try
            {
                dynamic json = JsonConvert.DeserializeObject(data);
                string sensor = json.sensor;
                double valor = json.valor;
                string unidad = json.unidad;

                // Muestra los datos en un MessageBox o actualiza la UI
                MessageBox.Show($"Sensor: {sensor}\nValor: {valor}\nUnidad: {unidad}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar JSON: " + ex.Message);
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



                    label4.Text = Solicitud.litros.ToString();
                    label5.Text = Solicitud.precio.ToString();
                }
                else if (Solicitud.id == 2)
                {
                    bombas[1].id = 2;
                    bombas[1].estado = true;
                    bombas[1].cantidadLitros = Solicitud.litros;


                    label7.Text = Solicitud.litros.ToString();
                    label6.Text = Solicitud.precio.ToString();
                }
                else if (Solicitud.id == 3)
                {
                    bombas[2].id = 3;
                    bombas[2].estado = true;
                    bombas[2].cantidadLitros = Solicitud.litros;


                    label11.Text = Solicitud.litros.ToString();
                    label10.Text = Solicitud.precio.ToString();
                }
                else if (Solicitud.id == 4)
                {
                    bombas[3].id = 4;
                    bombas[3].estado = true;
                    bombas[3].cantidadLitros = Solicitud.litros;


                    label15.Text = Solicitud.litros.ToString();
                    label14.Text = Solicitud.precio.ToString();
                }
            }
            catch { }
        }

        private void realizarSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioSolicitud solicitud = new FormularioSolicitud(15.2);
            solicitud.ShowDialog();
            Llenarinfo();
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

                    textBox1.Text = (mesanje);
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

                    textBox1.Text = (mesanje);
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

                    textBox1.Text = (mesanje);
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

                    textBox1.Text = (mesanje);
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
            Ventas ventas = new Ventas();
            ventas.Show();
        }
    }
}
