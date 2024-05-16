namespace ProyectoFINAL
{
    public partial class Form1 : Form
    {

        Bomba[] bombas;
        public Form1()
        {
            InitializeComponent();
            bombas = new Bomba[4];
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
