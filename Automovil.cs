using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectCode4Girls
{
    class Automovil:Vehiculo
    {
        private int NumPuertas { get; set; }
        private string Color { get; set; }

        public Automovil()
        {
            Matricula = String.Empty;
            Precio= 0;
            Cantidad = 0;
            Marca = String.Empty;
            Modelo = String.Empty;
            Año = 0;
            NumPuertas = 0;
            Color = String.Empty;

        }
        public Automovil(string matricula, int anio,decimal precio, string marca, string modelo, int cantidad, int numPuertas, string color)
        {
            Matricula = matricula;
            Cantidad = cantidad;
            Precio= precio;
            Marca = marca;
            Año = anio;
            Modelo = modelo;
            NumPuertas = numPuertas;
            Color = color;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Matricula:{Matricula}\nPrecio:{Precio}\nMarca:{Marca} \nColor:{Color}" +
                $"\nModelo:{Modelo}\nCantidad:{Cantidad}\nNumero de Puertas:{NumPuertas} \n");
            
        }
    }
}
