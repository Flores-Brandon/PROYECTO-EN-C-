using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace PROYECTO_EN_C_
{
    public partial class frmMenu : Form
    {
        private List<string> comentarios = new List<string>();
        private string archivoComentarios = "comentarios.txt";
        private Comida pedidoComida = new Comida();
        private Bebidas pedidoBebidas = new Bebidas();
        private Postres pedidoPostres = new Postres();
        public frmMenu()
        {
            InitializeComponent();
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            // Agregar las columnas al DataGridView
            dgvCarrito.Columns.Add("Producto", "Producto");
            dgvCarrito.Columns.Add("Cantidad", "Cantidad");
            dgvCarrito.Columns.Add("Precio Unitario", "Precio Unitario");
            dgvCarrito.Columns.Add("Precio Total", "Precio Total");


            CargarComentarios();
        }
        public void CargarComentarios()
        {
            // Check if the comments file exists
            if (File.Exists(archivoComentarios))
            {
                // Load the comments from the file into the list of comments
                comentarios = new List<string>(File.ReadAllLines(archivoComentarios));
            }
        }
        public void GuardarComentarios()
            {
                //Save the comments to the comments file
                File.WriteAllLines(archivoComentarios, comentarios);
            }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Ajustar la altura del panel pnlComida para que coincida con la altura del botón btnComida
            pnlNosotros.Height = btnInicio.Height;

            // Posicionar el panel pnlComida en la parte superior del botón btnComida
            pnlNosotros.Top = btnInicio.Height;

            // Mostrar el panel pnlindxComidas y ocultar los demás paneles
            pnlindxComidas.Visible = false;
            pnlIndxBebidas.Visible = false;
            pnlindixPostres.Visible = false;
            pnlindixCarrito.Visible = false;
            pnlindixInicio.Visible = true;
            pnlindixComentario.Visible = false;
            pnlindixRecoger.Visible = false;
        }
        private void btnRecoger_Click(object sender, EventArgs e)
        {            // Ajustar la altura del panel pnlComida para que coincida con la altura del botón btnComida
            pnlRecoger.Height = btnRecoger.Height;

            // Posicionar el panel pnlComida en la parte superior del botón btnComida
            pnlRecoger.Top = btnRecoger.Height;

            // Mostrar el panel pnlindxComidas y ocultar los demás paneles
            pnlindxComidas.Visible = false;
            pnlIndxBebidas.Visible = false;
            pnlindixPostres.Visible = false;
            pnlindixCarrito.Visible = false;
            pnlindixInicio.Visible =false;
            pnlindixComentario.Visible = false;
            pnlindixRecoger.Visible = true;
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            // Ajustar la altura del panel pnlComida para que coincida con la altura del botón btnComida
            pnlComida.Height = btnComida.Height;

            // Posicionar el panel pnlComida en la parte superior del botón btnComida
            pnlComida.Top = btnComida.Height;

            // Mostrar el panel pnlindxComidas y ocultar los demás paneles
            pnlindxComidas.Visible = true;
            pnlIndxBebidas.Visible = false;
            pnlindixPostres.Visible = false;
            pnlindixCarrito.Visible = false;
            pnlindixInicio.Visible = false;
            pnlindixComentario.Visible = false;
            pnlindixRecoger.Visible = false;
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            // Ajustar la altura del panel pnlComida para que coincida con la altura del botón btnComida
            pnlBebidas.Height = btnBebidas.Height;

            // Posicionar el panel pnlComida en la parte superior del botón btnComida
            pnlBebidas.Top = btnBebidas.Height;

            // Mostrar el panel pnlindxComidas y ocultar los demás paneles
            pnlindxComidas.Visible = false;
            pnlIndxBebidas.Visible = true;
            pnlindixPostres.Visible = false;
            pnlindixCarrito.Visible = false;
            pnlindixInicio.Visible = false;
            pnlindixComentario.Visible = false;
            pnlindixRecoger.Visible = false;
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            // Ajustar la altura del panel pnlComida para que coincida con la altura del botón btnComida
            pnlPostres.Height = btnPostres.Height;

            // Posicionar el panel pnlComida en la parte superior del botón btnComida
            pnlPostres.Top = btnPostres.Height;

            // Mostrar el panel pnlindxComidas y ocultar los demás paneles
            pnlindxComidas.Visible = false;
            pnlIndxBebidas.Visible = false;
            pnlindixPostres.Visible = true;
            pnlindixCarrito.Visible = false;
            pnlindixInicio.Visible = false;
            pnlindixComentario.Visible = false;
            pnlindixRecoger.Visible = false;
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            // Ajustar la altura del panel pnlComida para que coincida con la altura del botón btnComida
            pnlCarrito.Height = btnCarrito.Height;

            // Posicionar el panel pnlComida en la parte superior del botón btnComida
            pnlCarrito.Top = btnCarrito.Height;

            // Mostrar el panel pnlindxComidas y ocultar los demás paneles
            pnlindxComidas.Visible = false;
            pnlIndxBebidas.Visible = false;
            pnlindixPostres.Visible = false;
            pnlindixCarrito.Visible = true;
            pnlindixInicio.Visible = false;
            pnlindixComentario.Visible = false;
            pnlindixRecoger.Visible = false;
        }

        private void btnComentarios_Click(object sender, EventArgs e)
        {
            // Ajustar la altura del panel pnlComida para que coincida con la altura del botón btnComida
            pnlComentarios.Height = btnComentario.Height;

            // Posicionar el panel pnlComida en la parte superior del botón btnComida
            pnlComentarios.Top = btnComentario.Height;

            // Mostrar el panel pnlindxComidas y ocultar los demás paneles
            pnlindxComidas.Visible = false;
            pnlIndxBebidas.Visible = false;
            pnlindixPostres.Visible = false;
            pnlindixCarrito.Visible = false;
            pnlindixInicio.Visible = false;
            pnlindixComentario.Visible = true;
            pnlindixRecoger.Visible = false;
        }
        //Creeamos el evento para cuando seleccione una cantidad en el nud a la hora de precionar agregar al carrito los regrese al valor 0
        private void LimpiarV()
        {
            nudAgua.Value = 0;
            nudBrochetas.Value = 0;
            nudBurrito.Value = 0;
            nudCafe.Value = 0;
            nudCerveza.Value = 0;
            nudHamburguesa.Value = 0;
            nudHelado.Value = 0;
            nudHotDog.Value = 0;
            nudJugo.Value = 0;
            nudNugget.Value = 0;
            nudPastel.Value = 0;
            nudPay.Value = 0;
            nudPizza.Value = 0;
            nudRefresco.Value = 0;
            nudTe.Value = 0;
        }
        private void btnAggComida_Click(object sender, EventArgs e)
        {
            // Obtener las cantidades de los NumericUpDown
            int pizzaCantidad = (int)nudPizza.Value;
            int hamburguesaCantidad = (int)nudHamburguesa.Value;
            int burritosCantidad = (int)nudBurrito.Value;
            int brochetasCantidad = (int)nudBrochetas.Value;
            int hotDogCantidad = (int)nudHotDog.Value;
            int nuggetCantidad = (int)nudNugget.Value;



            // Crear una instancia de la clase Compras
            Compras compra = new Compras();

            // Calcular el precio total de cada tipo de comida
            long pizzaPrecioTotal = compra.CalcularPrecioTotalComida(pizzaCantidad, compra.Pizza);
            long hamburguesaPrecioTotal = compra.CalcularPrecioTotalComida(hamburguesaCantidad, compra.Hamburguesa);
            long burritosPrecioTotal = compra.CalcularPrecioTotalComida(burritosCantidad, compra.Burritos);
            long brochetasPrecioTotal = compra.CalcularPrecioTotalComida(brochetasCantidad, compra.Brochetas);
            long hotDogPrecioTotal = compra.CalcularPrecioTotalComida(hotDogCantidad, compra.HotDog);
            long nuggetPrecioTotal = compra.CalcularPrecioTotalComida(nuggetCantidad, compra.Nuggets);

            // Agregar las filas al DataGridView si el número es mayor que 0
            if (pizzaCantidad > 0)
            {
                dgvCarrito.Rows.Add("Pizza", pizzaCantidad, compra.Pizza, pizzaPrecioTotal);
            }

            if (hamburguesaCantidad > 0)
            {
                dgvCarrito.Rows.Add("Hamburguesa", hamburguesaCantidad, compra.Hamburguesa, hamburguesaPrecioTotal);
            }

            if (burritosCantidad > 0)
            {
                dgvCarrito.Rows.Add("Burritos", burritosCantidad, compra.Burritos, burritosPrecioTotal);
            }

            if (brochetasCantidad > 0)
            {
                dgvCarrito.Rows.Add("Brochetas", brochetasCantidad, compra.Brochetas, brochetasPrecioTotal);
            }

            if (hotDogCantidad > 0)
            {
                dgvCarrito.Rows.Add("Hot dog", hotDogCantidad, compra.HotDog, hotDogPrecioTotal);
            }

            if (nuggetCantidad > 0)
            {
                dgvCarrito.Rows.Add("Nuggets", nuggetCantidad, compra.Nuggets, nuggetPrecioTotal);
            }

            LimpiarV();
        }

        private void btnAggBebidas_Click(object sender, EventArgs e)
        {
            // Get the amounts of the NumericUpDown
            int RefrescosCantidad = (int)nudRefresco.Value;
            int JugosCantidad = (int)nudJugo.Value;
            int CafeCantidad = (int)nudCafe.Value;
            int AguaCantidad = (int)nudAgua.Value;
            int CervezaCantidad = (int)nudCerveza.Value;
            int TeCantidad = (int)nudTe.Value;

            // Create an instance of the shopping class
            Compras compra = new Compras();

            // Calculate the total price of each type of drinks
            long RefrescosPrecioTotal = compra.CalcularPrecioTotalBebida(RefrescosCantidad, compra.Refresco);
            long JugosPrecioTotal = compra.CalcularPrecioTotalBebida(JugosCantidad, compra.Jugos);
            long CafePrecioTotal = compra.CalcularPrecioTotalBebida(CafeCantidad, compra.Cafe);
            long AguaPrecioTotal = compra.CalcularPrecioTotalBebida(AguaCantidad, compra.Agua);
            long CervezaPrecioTotal = compra.CalcularPrecioTotalBebida(CervezaCantidad, compra.Cerveza);
            long TePrecioTotal = compra.CalcularPrecioTotalBebida(TeCantidad, compra.Té);

            // Add the rows to the DataGridView if the number is greater than 0
            if (RefrescosCantidad > 0)
            {
                dgvCarrito.Rows.Add("Refrescos", RefrescosCantidad, compra.Refresco, RefrescosPrecioTotal);
            }
            if (JugosCantidad > 0)
            {
                dgvCarrito.Rows.Add("Jugos", JugosCantidad, compra.Jugos, JugosPrecioTotal);
            }
            if (CafeCantidad > 0)
            {
                dgvCarrito.Rows.Add("Café", CafeCantidad, compra.Cafe, CafeCantidad);
            }
            if (AguaCantidad > 0)
            {
                dgvCarrito.Rows.Add("Agua", AguaCantidad, compra.Agua, AguaPrecioTotal);
            }
            if (CervezaCantidad > 0)
            {
                dgvCarrito.Rows.Add("Cerveza", CervezaCantidad, compra.Cerveza, CervezaPrecioTotal);
            }
            if (TeCantidad > 0)
            {
                dgvCarrito.Rows.Add("Té Helado", TeCantidad, compra.Té, TePrecioTotal);
            }

            LimpiarV();
            
        }

        private void btnAggPostre_Click(object sender, EventArgs e)
        {
            // Get the amounts of the NumericUpDown
            int HeladoCantidad = (int)nudHelado.Value;
            int PastelCantidad = (int)nudPastel.Value;
            int PayCantidad = (int)nudPay.Value;

            // Create an instance of the shopping class
            Compras compra = new Compras();

            // Calculate the total price of each type of dessert
            long HeladoPrecioTotal = compra.CalcularPrecioTotalPostre(HeladoCantidad, compra.Helado);
            long PastelPrecioTotal = compra.CalcularPrecioTotalPostre(PastelCantidad, compra.Pastel);
            long PayPrecioTotal = compra.CalcularPrecioTotalPostre(PayCantidad, compra.Pay);

            // Check if the quantity is greater than 0 before adding rows to the DataGridView
            if (HeladoCantidad > 0)
            {
                dgvCarrito.Rows.Add("Helado", HeladoCantidad, compra.Helado, HeladoPrecioTotal);
            }

            if (PastelCantidad > 0)
            {
                dgvCarrito.Rows.Add("Pastel", PastelCantidad, compra.Pastel, PastelPrecioTotal);
            }

            if (PayCantidad > 0)
            {
                dgvCarrito.Rows.Add("Pay", PayCantidad, compra.Pay, PayPrecioTotal);
            }

            LimpiarV();

        }

        private void btnSumaTotal_Click(object sender, EventArgs e)
        {
            // Calculate the total sum of the "Final Price" column
            int sumaTotal = 0;
            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                sumaTotal += Convert.ToInt32(fila.Cells["Precio Total"].Value);
            }

            // Display the total sum in the label
            lblMostrarPago.Text = "Total a pagar: $" + sumaTotal.ToString();

        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            // Calculate the total sum of the "Total Price" column
            int sumaTotal = 0;
            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                sumaTotal += Convert.ToInt32(fila.Cells["Precio Total"].Value);
            }

            List<string> productos = new List<string>(); // Create a List to store the product names

            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                DataGridViewCell celdaProducto = fila.Cells["Producto"]; // Get the "Product" cell
                DataGridViewCell celdaCantidad = fila.Cells["Cantidad"]; // Get the "Quantity" cell
                DataGridViewCell celdaPrecio = fila.Cells["Precio Unitario"]; // Get the "Unit Price" cell

                if (celdaProducto.Value != null && celdaCantidad.Value != null && celdaPrecio.Value != null) // Check if all cells have a value
                {
                    string producto = celdaProducto.Value.ToString(); // Get the value of the "Product" cell as a string
                    string cantidad = celdaCantidad.Value.ToString(); // Get the value of the "Quantity" cell as a string
                    string precio = celdaPrecio.Value.ToString(); // Get the value of the "Price" cell as a string
                    string productoCantidadPrecio = producto + "..........." + cantidad + "..........." + "$" + precio; // Concatenate the product name, quantity, price with the "$" sign, and separated by dots

                    productos.Add(productoCantidadPrecio); // Add the product name, quantity, and price to the list
                }
            }

            // Convert the List to an array of strings
            string[] productosArray = productos.ToArray();

            Ticket ticketForm = new Ticket(sumaTotal, productosArray); // Create an instance of your ticket form, passing the array as a parameter
            ticketForm.ShowDialog(); // Show the ticket form

        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            // Declare the array of pizza ingredients
            string[] ingredientesPizza = { "Masa de pizza", "Salsa de tomate", "Queso", "Pepperoni", "Champiñones", "Cebolla", "Pimiento" };

            // Show the pizza ingredients in a MessageBox
            MessageBox.Show("La pizza lleva los siguientes ingredientes:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesPizza));
        }

        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            // Declare the array of hamburger ingredients
            string[] ingredientesHamburguesa = { "Pan", "Mayonesa", "Mostaza", "Carne de Res O Pollo", "Queso", "Lechuga", "Tomate", "Cebolla", "Jamon" };

            // Show the hamburger ingredients in a MessageBox
            MessageBox.Show("La Hamburguesa lleva los siguientes ingredientes:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesHamburguesa));
        }

        private void btnBurrito_Click(object sender, EventArgs e)
        {
            // Declare the array of burrito ingredients
            string[] ingredientesBurrito = { "Tortilla", "Pollo O Carne Desebrada", "Frijoles", "Lechuga", "Tomate", "Crema" };

            // Show the burrito ingredients in a MessageBox
            MessageBox.Show("El Burrito lleva los siguientes ingredientes:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesBurrito));
        }

        private void btnBrochetas_Click(object sender, EventArgs e)
        {
            // Declare the array of kebab ingredients
            string[] ingredientesBrochetas = { "Carne", "Piña", "Chile Morron", "Tocino", "Salsa Especial De La Casa" };

            // Show the kebab ingredients in a MessageBox
            MessageBox.Show("Las Brochetas llevan los siguientes ingredientes:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesBrochetas));
        }

        private void btnNuggets_Click(object sender, EventArgs e)
        {
            // Declare the array of nugget ingredients
            string[] ingredientesNuggets = { "Pollo", "Salsas Al gusto", "Papas Fritas" };

            // Show the nugget ingredients in a MessageBox
            MessageBox.Show("Los Nuggets llevan los siguientes ingredientes:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesNuggets));
        }

        private void btnHotDog_Click(object sender, EventArgs e)
        {
            // Declare the array of hot dog ingredients
            string[] ingredientesHotDog = { "Pan", "Salchicha", "Cebolla", "Tocino", "Tomate", "Mostaza", "Salsa Tomate" };

            // Show the hot dog ingredients in a MessageBox
            MessageBox.Show("El Hot Dog lleva los siguientes ingredientes:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesHotDog));

        }

        private void btnRefresco_Click(object sender, EventArgs e)
        {
            // Declare the array of Refreshment ingredients
            string[] ingredientesRefrescos = { "Coca Cola", "Sprite", "Manzanita", "Fanta", "Pepsi" };

            // Show the Refreshment ingredients in a MessageBox
            MessageBox.Show("Tenemos los siguientes Sabores:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesRefrescos));
        }

        private void btnJugos_Click(object sender, EventArgs e)
        {
            // Declare the array of Juice ingredients
            string[] ingredientesJugos = { "Naranja", "Manzana", "Melon", "Platano", "Sandia", "Durazno", "Pimiento" };

            // Show the Juice ingredients in a MessageBox
            MessageBox.Show("Tenemos los siguientes tipos de jugos:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesJugos));
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            // Declare the array of coffee ingredients
            string[] ingredientesCafe = { "Americano", "Expresso", "Macchiato", "Cafe con Leche", "Capuchino", "Moca" };

            // Show the coffee ingredients in a MessageBox
            MessageBox.Show("Tenemos estos tipos de caffes:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesCafe));
        }

        private void btnAgua_Click(object sender, EventArgs e)
        {
            // Declare the array of water ingredients
            string[] ingredientesAgua = { "Agua", "Agua Mineral" };

            // Show the water ingredients in a MessageBox
            MessageBox.Show("Tenemos estos tipos de agua:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesAgua));
        }

        private void btnCerveza_Click(object sender, EventArgs e)
        {
            // Declare the array of beer ingredients
            string[] ingredientesCerveza = { "Tecate", "Corona", "Indio" };

            // Show the beer ingredients in a MessageBox
            MessageBox.Show("Tenemos las siguientes variedades de Cervezas:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesCerveza));
        }

        private void btnTe_Click(object sender, EventArgs e)
        {
            // Declare the array of iced tea ingredients
            string[] ingredientesTe = { "Limon y Miel", "Menta", "Te Verde", "Te Negro" };

            // Show the iced tea ingredients in a MessageBox
            MessageBox.Show("Tenemos estos tipos de Tés:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesTe));
        }

        private void btnHelado_Click(object sender, EventArgs e)
        {
            // Declare the array of ice cream ingredients
            string[] ingredientesHelado = { "Nieve De Vainilla", "Cereza", "Galleta", "Chocolate Derretido", "Chispas" };

            // Show the ice cream ingredients in a MessageBox
            MessageBox.Show("El Helado lleva los siguientes ingredientes:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesHelado));
        }

        private void btnPastel_Click(object sender, EventArgs e)
        {
            // Declare the array of cake ingredients
            string[] ingredientesPastel = { "Pan", "Fresas", "Leche", "Betun de Vainilla" };

            // Show the cake ingredients in a MessageBox
            MessageBox.Show("El Pastel lleva los siguientes ingredientes:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesPastel));
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Declare the array of pay ingredients
            string[] ingredientesPay = { "Fresas", "Base de Galleta", "Queso Fhiladelfhia", "Leche Condenzada", "Leche Evaporada", "Queso Panela", "Mermelada" };

            // Show the Pay ingredients in a MessageBox
            MessageBox.Show("El Pay lleva los siguientes ingredientes:" + Environment.NewLine + string.Join(Environment.NewLine, ingredientesPay));
        }
        private void btnMostrarComentario_Click(object sender, EventArgs e)
        {
            // Display the comments in the label if there are any, otherwise display a message indicating no comments
            lblComentarios.Text = comentarios.Count > 0 ? string.Join(Environment.NewLine, comentarios) : "No hay comentarios.";
        }
        private void btnComentario_Click(object sender, EventArgs e)
        {
            // Retrieve the comment from the text box
            string comentario = txtComentario.Text;
            // Check if the comment is empty or consists of only whitespace characters
            if (string.IsNullOrWhiteSpace(comentario))
            {
                // Display an error message if the comment is invalid
                lblMensaje.Text = "Comentario inválido. Por favor, escribe algo.";
            }
            else
            {
                // Add the comment to the list of comments
                comentarios.Add(comentario);
                // Save the comments to a file
               // GuardarComentarios();
                // Clear the text box after saving the comment
                txtComentario.Clear();
                // Display a success message indicating that the comment has been saved
                lblMensaje.Text = "Comentario guardado correctamente.";
            }

             void CargarComentarios()
             {
                // Check if the comments file exists
                if (File.Exists(archivoComentarios))
                {
                    // Load the comments from the file into the list of comments
                    comentarios = new List<string>(File.ReadAllLines(archivoComentarios));
                }
             }
            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAggComidas_Click(object sender, EventArgs e)
        {
            pedidoComida.MostrarTiposPlatillos();
            int seleccion;
            if (int.TryParse(InputBox("Ingrese el número del platillo que desea agregar:", "Agregar Platillo", 500, 300), out seleccion))
            {
                string platillo = pedidoComida.SeleccionarPlatillo(seleccion);
                if (!string.IsNullOrWhiteSpace(platillo))
                {
                    int cantidad;
                    if (int.TryParse(InputBox($"Ingrese la cantidad de {platillo}:", "Agregar Cantidad", 500, 300), out cantidad))
                    {
                        pedidoComida.AgregarPlatillo(platillo, cantidad);
                        MessageBox.Show($"Se ha seleccionado {cantidad} {platillo}(s).");
                    }
                    else
                    {
                        MessageBox.Show("Cantidad inválida. Intente nuevamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Platillo inválido. Intente nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("Selección inválida. Intente nuevamente.");
            }
        }

        private string InputBox(string prompt, string title, int width, int height)
        {
            Form promptForm = new Form();
            promptForm.Width = width;
            promptForm.Height = height;
            promptForm.Text = title;

            Label lblPrompt = new Label() { Left = 20, Top = 20, Text = prompt };
            lblPrompt.Font = new Font(lblPrompt.Font.FontFamily, 12, lblPrompt.Font.Style);
            TextBox txtInput = new TextBox() { Left = 50, Top = 100, Width = width - 0 };
            Button btnOk = new Button() { Text = "Aceptar", Left = width - 100, Width = 75, Top = height - 70, DialogResult = DialogResult.OK };
            Button btnCancel = new Button() { Text = "Cancelar", Left = width - 200, Width = 75, Top = height - 70, DialogResult = DialogResult.Cancel };

            promptForm.Controls.Add(lblPrompt);
            promptForm.Controls.Add(txtInput);
            promptForm.Controls.Add(btnOk);
            promptForm.Controls.Add(btnCancel);

            DialogResult result = promptForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                return txtInput.Text;
            }
            else
            {
                return "";
            }
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text.Trim();
            string telefono = txtNumeroTelefonico.Text.Trim();
            string hora = txtHora.Text.Trim();

            List<string> ordenComida = pedidoComida.ObtenerOrden();
            List<string> ordenBebidas = pedidoBebidas.ObtenerOrden();
            List<string> ordenPostres = pedidoPostres.ObtenerOrden();

            decimal total = pedidoComida.CalcularTotal() + pedidoBebidas.CalcularTotal() + pedidoPostres.CalcularTotal();

            string mensaje = $"Nombre: {nombre}" + Environment.NewLine;
            mensaje += $"Teléfono: {telefono}" + Environment.NewLine;
            mensaje += $"Hora: {hora}" + Environment.NewLine;
            mensaje += Environment.NewLine;
            mensaje += "Orden:" + Environment.NewLine;
            mensaje += "Comida:" + Environment.NewLine;
            mensaje += (ordenComida.Count > 0) ? string.Join(Environment.NewLine, ordenComida) : "No se ha seleccionado comida";
            mensaje += Environment.NewLine;
            mensaje += "Bebidas:" + Environment.NewLine;
            mensaje += (ordenBebidas.Count > 0) ? string.Join(Environment.NewLine, ordenBebidas) : "No se ha seleccionado bebida";
            mensaje += Environment.NewLine;
            mensaje += "Postres:" + Environment.NewLine;
            mensaje += (ordenPostres.Count > 0) ? string.Join(Environment.NewLine, ordenPostres) : "No se ha seleccionado postre";
            mensaje += Environment.NewLine;

            MessageBox.Show(mensaje, "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAggBebida_Click(object sender, EventArgs e)
        {
            pedidoBebidas.MostrarTiposPlatillos();
            int seleccion;
            if (int.TryParse(InputBox("Ingrese el número de la bebida que desea agregar:", "Agregar Bebida", 500, 300), out seleccion))
            {
                string bebida = pedidoBebidas.SeleccionarPlatillo(seleccion);
                if (!string.IsNullOrWhiteSpace(bebida))
                {
                    int cantidad;
                    if (int.TryParse(InputBox($"Ingrese la cantidad de {bebida}:", "Agregar Cantidad", 500, 300), out cantidad))
                    {
                        pedidoBebidas.AgregarPlatillo(bebida, cantidad);
                        MessageBox.Show($"Se ha seleccionado {cantidad} {bebida}(s).");
                    }
                    else
                    {
                        MessageBox.Show("Cantidad inválida. Intente nuevamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Bebida inválida. Intente nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("Selección inválida. Intente nuevamente.");
            }
        }

        private string InputBoox(string prompt, string title, int width, int height)
        {
            Form promptForm = new Form();
            promptForm.Width = width;
            promptForm.Height = height;
            promptForm.Text = title;

            Label lblPrompt = new Label() { Left = 20, Top = 20, Text = prompt };
            lblPrompt.Font = new Font(lblPrompt.Font.FontFamily, 10, lblPrompt.Font.Style);
            TextBox txtInput = new TextBox() { Left = 20, Top = 50, Width = width - 40 };
            Button btnOk = new Button() { Text = "Aceptar", Left = width - 100, Width = 75, Top = height - 70, DialogResult = DialogResult.OK };
            Button btnCancel = new Button() { Text = "Cancelar", Left = width - 200, Width = 75, Top = height - 70, DialogResult = DialogResult.Cancel };

            promptForm.Controls.Add(lblPrompt);
            promptForm.Controls.Add(txtInput);
            promptForm.Controls.Add(btnOk);
            promptForm.Controls.Add(btnCancel);

            DialogResult result = promptForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                return txtInput.Text;
            }
            else
            {
                return "";
            }
        }

        private void btnAggPostres_Click(object sender, EventArgs e)
        {
            pedidoPostres.MostrarTiposPlatillos();
            int seleccion;
            if (int.TryParse(InputBox("Ingrese el número del postre que desea agregar:", "Agregar Postre", 500, 300), out seleccion))
            {
                string postre = pedidoPostres.SeleccionarPlatillo(seleccion);
                if (!string.IsNullOrWhiteSpace(postre))
                {
                    int cantidad;
                    if (int.TryParse(InputBox($"Ingrese la cantidad de {postre}:", "Agregar Cantidad", 500, 300), out cantidad))
                    {
                        pedidoPostres.AgregarPlatillo(postre, cantidad);
                        MessageBox.Show($"Se ha seleccionado {cantidad} {postre}(s).");
                    }
                    else
                    {
                        MessageBox.Show("Cantidad inválida. Intente nuevamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Postre inválido. Intente nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("Selección inválida. Intente nuevamente.");
            }
        }

        private string InputBooox(string prompt, string title, int width, int height)
        {
            Form promptForm = new Form();
            promptForm.Width = width;
            promptForm.Height = height;
            promptForm.Text = title;

            Label lblPrompt = new Label() { Left = 20, Top = 20, Text = prompt };
            lblPrompt.Font = new Font(lblPrompt.Font.FontFamily, 10, lblPrompt.Font.Style);
            TextBox txtInput = new TextBox() { Left = 20, Top = 50, Width = width - 40 };
            Button btnOk = new Button() { Text = "Aceptar", Left = width - 100, Width = 75, Top = height - 70, DialogResult = DialogResult.OK };
            Button btnCancel = new Button() { Text = "Cancelar", Left = width - 200, Width = 75, Top = height - 70, DialogResult = DialogResult.Cancel };

            promptForm.Controls.Add(lblPrompt);
            promptForm.Controls.Add(txtInput);
            promptForm.Controls.Add(btnOk);
            promptForm.Controls.Add(btnCancel);

            DialogResult result = promptForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                return txtInput.Text;
            }
            else
            {
                return "";
            }
        }
    }
}

