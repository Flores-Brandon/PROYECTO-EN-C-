using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_EN_C_
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        private int sumaTotal;
        private string[] productos;

        public Ticket(int sumaTotal, string[] productos)
        {
            InitializeComponent();
            this.sumaTotal = sumaTotal;
            this.productos = productos;
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
        }

        private void MostrarTicket()
        {
            int numeroTicket = 123;
            DateTime fecha = DateTime.Now;
            string nombreRestaurante = "Restaurante La Parrilla Ardiente";

            string contenidoTicket = "";
            contenidoTicket += "-------------------------------------------------------------------------------" + Environment.NewLine;
            contenidoTicket += "      MUCHAS GRACIAS POR VENIR, ¡VUELVA PRONTO!      " + Environment.NewLine;
            contenidoTicket += "--------------------------------------------------------------------------------" + Environment.NewLine;
            contenidoTicket += "Número de ticket: " + numeroTicket.ToString() + Environment.NewLine;
            contenidoTicket += "Fecha: " + fecha.ToString() + Environment.NewLine;
            contenidoTicket += "Restaurante: " + nombreRestaurante + Environment.NewLine;
            contenidoTicket += "--------------------------------------------------------------------------------" + Environment.NewLine;
            contenidoTicket += "Productos:" + Environment.NewLine;

            foreach (string producto in productos)
            {
                contenidoTicket += "- " + producto + Environment.NewLine;
            }

            contenidoTicket += "--------------------------------------------------------------------------------" + Environment.NewLine;
            contenidoTicket += "Total: $" + sumaTotal.ToString() + Environment.NewLine;

            lblTicket.Text = contenidoTicket;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string archivoTicket = Path.Combine(desktopPath, "ticket.txt");

            File.WriteAllText(archivoTicket, contenidoTicket);
        }

        
        private void lblTicket_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarTicket_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ticket_Load_1(object sender, EventArgs e)
        {
            MostrarTicket();

        }
    }
}
