using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_EN_C_
{
    internal class Compras
    {
        // Here the food variables are created with their value
        public Int64 Pizza { get; set; } = 140;
        public Int64 Hamburguesa { get; set; } = 120;
        public Int64 Burritos { get; set; } = 80;
        public Int64 Nuggets { get; set; } = 70;
        public Int64 Brochetas { get; set; } = 100;
        public Int64 HotDog { get; set; } = 75;

        // Here the drinks variables are created with their value
        public Int64 Refresco { get; set; } = 25;
        public Int64 Té { get; set; } = 20;
        public Int64 Jugos { get; set; } = 20;
        public Int64 Cafe { get; set; } = 30;
        public Int64 Cerveza { get; set; } = 75;
        public Int64 Agua { get; set; } = 15;

        // Here the desserts variables are created with their value
        public Int64 Helado { get; set; } = 40;
        public Int64 Pastel { get; set; } = 65;
        public Int64 Pay { get; set; } = 65;

        // Calculates the total price of a food item
        public Int64 CalcularPrecioTotalComida(int cantidad, Int64 precio)
        {
            return cantidad * precio;
        }

        // Calculates the total price of a drink item
        public Int64 CalcularPrecioTotalBebida(int cantidad, Int64 precio)
        {
            return cantidad * precio;
        }

        // Calculates the total price of a dessert item
        public Int64 CalcularPrecioTotalPostre(int cantidad, Int64 precio)
        {
            return cantidad * precio;
        }
    }
}

