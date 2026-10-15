using Microsoft.VisualBasic;
using System.Net;
using System.Net.Sockets;

namespace Sockets
{
    public partial class Form1 : Form
    {

        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        public void IniciarServidor()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 6400);

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(endPoint);
            server.Listen(10);

            while (true)
            {
                Socket conexion = server.Accept();

                string idCliente = conexion.RemoteEndPoint.ToString();
                AgregarLog($"[CONEXIÓN] Cliente conectado: {idCliente}");
                Task.Run(() => AtenderCliente(conexion, idCliente));
            }
        }

        public void AtenderCliente(Socket conexion, string idCliente)
        {
            byte[] buffer = new byte[1024];


            while (true)
            {

                int bytesRecibidos = conexion.Receive(buffer);

                if (bytesRecibidos == 0)
                {
                    break;
                }

                string mensaje = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRecibidos);
                AgregarLog(mensaje);
                //MessageBox.Show(mensaje);
            }
            conexion.Close();
        }

        private void AgregarLog(string texto)

        {

            if (txtMensajes.InvokeRequired)

            {

                txtMensajes.Invoke(new Action(() => AgregarLog(texto)));

            }

            else

            {

                txtMensajes.AppendText($"[{DateTime.Now:HH:mm:ss}] {texto}{Environment.NewLine}");

            }

        }

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void btnIniciarServidor_Click(object sender, EventArgs e)
        {
            Task.Run(() => IniciarServidor());
        }
    }
}