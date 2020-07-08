using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectCode4Girls
{
    class Vehiculo
    {
        public string Matricula { get; set; }
        public decimal Precio{ get; set; }
        public string Marca { get; set; }
        public int Año { get; set; }
        public int Cantidad { get; set; }
        public string Modelo { get; set; }
        public virtual void Imprimir() { }


        public Vehiculo()
        {
            Matricula = String.Empty;
            Precio= 0;
            Año = 0;
            Marca = String.Empty;
            Cantidad = 0;
            Modelo = String.Empty;
        }

        public Vehiculo(string matricula, int anio ,int cantidad ,int precio, string marca, string modelo)
        {
            Matricula = matricula;
            Año = anio;
            Precio= precio;
            Marca = marca;
            Cantidad = cantidad;
            Modelo = modelo;
        }
    }
}
