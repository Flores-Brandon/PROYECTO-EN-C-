using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_EN_C_
{
    public abstract class Pedido
    {
        public Dictionary<int, string> platillos = new Dictionary<int, string>();
        public Dictionary<string, decimal> precios = new Dictionary<string, decimal>();
        public Dictionary<int, int> platillosSeleccionados = new Dictionary<int, int>();

        public void MostrarTiposPlatillos()
        {
            // Muestra los platos disponibles para la categoría particular
            string mensaje = "Platos Disponibles:\n";
            foreach (KeyValuePair<int, string> kvp in platillos)
            {
                mensaje += $"{kvp.Key}. {kvp.Value} - Precio: {precios[kvp.Value]}\n";
            }

            MessageBox.Show(mensaje);
        }

        public string SeleccionarPlatillo(int seleccion)
        {
            // Selecciona un plato según la selección proporcionada
            if (platillos.ContainsKey(seleccion))
            {
                return platillos[seleccion];
            }
            else
            {
                return string.Empty;
            }
        }

        public void AgregarPlatillo(string platillo, int cantidad)
        {
            // Agrega un plato y su cantidad al diccionario de platos seleccionados
            int seleccion = platillos.FirstOrDefault(x => x.Value == platillo).Key;
            if (seleccion != 0)
            {
                if (platillosSeleccionados.ContainsKey(seleccion))
                {
                    platillosSeleccionados[seleccion] += cantidad;
                }
                else
                {
                    platillosSeleccionados.Add(seleccion, cantidad);
                }
            }
        }

        public abstract List<string> ObtenerOrden();

        public decimal CalcularTotal()
        {
            // Calcula el costo total de los platos seleccionados
            decimal total = 0;

            foreach (KeyValuePair<int, int> kvp in platillosSeleccionados)
            {
                string platillo = platillos[kvp.Key];
                int cantidad = kvp.Value;
                decimal precio = precios[platillo];
                decimal subtotal = cantidad * precio;

                total += subtotal;
            }

            return total;
        }
    }

    public class Comida : Pedido
    {
        public Comida()
        {
            // Constructor de la clase Comida que inicializa los platos y precios disponibles
            platillos.Add(1, "Pizza");
            platillos.Add(2, "Hamburguesa");
            platillos.Add(3, "Nuggets");
            platillos.Add(4, "HotDog");
            platillos.Add(5, "Burritos");
            platillos.Add(6, "Brochetas");

            precios.Add("Pizza", 140);
            precios.Add("Hamburguesa", 120);
            precios.Add("Nuggets", 70);
            precios.Add("HotDog", 90);
            precios.Add("Burritos", 110);
            precios.Add("Brochetas", 130);
        }

        public override List<string> ObtenerOrden()
        {
            // Devuelve una lista de cadenas que representan los platos seleccionados en el pedido de Comida
            List<string> orden = new List<string>();

            foreach (KeyValuePair<int, int> kvp in platillosSeleccionados)
            {
                string platillo = platillos[kvp.Key];
                int cantidad = kvp.Value;
                decimal precio = precios[platillo];
                decimal subtotal = cantidad * precio;

                orden.Add($"{cantidad} x {platillo} - Subtotal: ${subtotal.ToString("0.00")}");
            }

            return orden;
        }
    }

    public class Bebidas : Pedido
    {
        public Bebidas()
        {
            // Constructor de la clase Bebidas que inicializa las bebidas y precios disponibles
            platillos.Add(1, "Refresco");
            platillos.Add(2, "Agua");
            platillos.Add(3, "Jugo");
            platillos.Add(4, "Té");
            platillos.Add(5, "Café");

            precios.Add("Refresco", 30);
            precios.Add("Agua", 20);
            precios.Add("Jugo", 35);
            precios.Add("Té", 25);
            precios.Add("Café", 40);
        }

        public override List<string> ObtenerOrden()
        {
            // Devuelve una lista de cadenas que representan las bebidas seleccionadas en el pedido de Bebidas
            List<string> orden = new List<string>();

            foreach (KeyValuePair<int, int> kvp in platillosSeleccionados)
            {
                string platillo = platillos[kvp.Key];
                int cantidad = kvp.Value;
                decimal precio = precios[platillo];
                decimal subtotal = cantidad * precio;

                orden.Add($"{cantidad} x {platillo} - Subtotal: ${subtotal.ToString("0.00")}");
            }

            return orden;
        }
    }

    public class Postres : Pedido
    {
        public Postres()
        {
            // Constructor de la clase Postres que inicializa los postres y precios disponibles
            platillos.Add(1, "Pastel");
            platillos.Add(2, "Helado");
            platillos.Add(3, "Pay");

            precios.Add("Pastel", 65);
            precios.Add("Helado", 40);
            precios.Add("Pay", 65);
        }

        public override List<string> ObtenerOrden()
        {
            // Devuelve una lista de cadenas que representan los postres seleccionados en el pedido de Postres
            List<string> orden = new List<string>();

            foreach (KeyValuePair<int, int> kvp in platillosSeleccionados)
            {
                string platillo = platillos[kvp.Key];
                int cantidad = kvp.Value;
                decimal precio = precios[platillo];
                decimal subtotal = cantidad * precio;

                orden.Add($"{cantidad} x {platillo} - Subtotal: ${subtotal.ToString("0.00")}");
            }

            return orden;
        }
    }
}
