using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectCode4Girls
{
    class Camioneta:Vehiculo
    {
        public int NumRuedas { get; set; }
       
        public Camioneta(string matricula, int anio, decimal precio, string marca, string modelo, int cantidad, int numRuedas)
        {
            Matricula = matricula;
            Cantidad = cantidad;
            Precio= precio;
            Marca = marca;
            Año = anio;
            Modelo = modelo;
            NumRuedas = numRuedas;
            
        }

        public Camioneta()
        {
            Matricula = String.Empty;
            Cantidad = 0;
            Precio= 0;
            Marca = String.Empty;
            Modelo = String.Empty;
            Año = 0;
            NumRuedas = 0;
           
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Matricula:{Matricula}\nPrecio:{Precio}\nMarca:{Marca} \n Año:{Año}" +
                $"\nModelo:{Modelo}\n Cantidad:{Cantidad}\nNumero de Ruedas:{NumRuedas} \n");

        }
    }
}
