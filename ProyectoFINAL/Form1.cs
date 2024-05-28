using System.IO.Ports;
using System.Text.Json;

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
            ventaList = new List<Venta>();

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
                    bombas[0].precioSolicitado = Solicitud.precio;


                    label4.Text = Solicitud.litros.ToString();
                    label5.Text = Solicitud.precio.ToString();
                }
                else if (Solicitud.id == 2)
                {
                    bombas[1].id = 2;
                    bombas[1].estado = true;

                    label7.Text = Solicitud.litros.ToString();
                    label6.Text = Solicitud.precio.ToString();
                }
                else if (Solicitud.id == 3)
                {
                    bombas[2].id = 3;
                    bombas[2].estado = true;

                    label11.Text = Solicitud.litros.ToString();
                    label10.Text = Solicitud.precio.ToString();
                }
                else if (Solicitud.id == 4)
                {
                    bombas[3].id = 4;
                    bombas[3].estado = true;

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
            string solicitud = JsonSerializer.Serialize(bombas[0]);

            Venta venta = new Venta(bombas[0].id, DateTime.Now.ToString("d"), DateTime.Now.ToString("s"), Solicitud.litros, Solicitud.precio);
            try
            {

                serialPort.Open();

                serialPort.WriteLine(solicitud);
                MessageBox.Show("" + solicitud);
                Console.WriteLine($"Sent message: {solicitud}");

                serialPort.Close();
                VerificarEntradas.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string solicitud = JsonSerializer.Serialize(bombas[1]);


            try
            {




                serialPort.Open();

                serialPort.WriteLine(solicitud);
                MessageBox.Show("" + solicitud);
                Console.WriteLine($"Sent message: {solicitud}");

                serialPort.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string solicitud = JsonSerializer.Serialize(bombas[2]);


            try
            {




                serialPort.Open();

                serialPort.WriteLine(solicitud);
                MessageBox.Show("" + solicitud);
                Console.WriteLine($"Sent message: {solicitud}");

                serialPort.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string solicitud = JsonSerializer.Serialize(bombas[3]);


            try
            {




                serialPort.Open();

                serialPort.WriteLine(solicitud);
                MessageBox.Show("" + solicitud);
                Console.WriteLine($"Sent message: {solicitud}");

                serialPort.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void VerificarEntradas_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    string indata = serialPort.ReadExisting();
                    if (!string.IsNullOrEmpty(indata))
                    {
                        int value;
                        if (int.TryParse(indata.Trim(), out value))
                        {
                            if (value < 100)
                            {
                                progressBar1.Invoke((MethodInvoker)delegate
                                {
                                    progressBar1.Value = value;
                                });
                            }
                            else
                            {
                                progressBar1.Invoke((MethodInvoker)delegate
                                {
                                    progressBar1.Value = 0;
                                });
                                serialPort.Close();
                                VerificarEntradas.Stop();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    VerificarEntradas.Stop();
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                serialPort.Open();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
