using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sockets
{
    public partial class Cliente : Form
    {
        private Socket clienteSocket;
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipServidor = IPAddress.Parse("127.0.0.1");
                IPEndPoint conexion = new IPEndPoint(ipServidor, 6400);

                clienteSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clienteSocket.Connect(conexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo conectar al servidor: {ex.Message}");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteSocket == null || !clienteSocket.Connected)
                {
                    MessageBox.Show("No hay conexión con el servidor.");
                    return;
                }

                string nombre = string.IsNullOrWhiteSpace(txtNombre.Text) ? "Anónimo" : txtNombre.Text;
                string paquete = $"{nombre}: {txtMensaje.Text}";

                byte[] enviar_info = Encoding.UTF8.GetBytes(paquete);
                clienteSocket.Send(enviar_info);

                txtMensaje.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar: {ex.Message}");
            }

        }

    }
}
