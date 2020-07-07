using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectCode4Girls
{
    class Vehiculo
    {
        public string Matricula { get; set; }
        public int NumDeSerie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo()
        {
            Matricula = String.Empty;
            NumDeSerie = 0;
            Marca = String.Empty;
            Modelo = String.Empty;
        }

        public Vehiculo(string matricula, int numDeSerie, string marca, string modelo)
        {
            Matricula = matricula;
            NumDeSerie = numDeSerie;
            Marca = marca;
            Modelo = modelo;
        }
    }
}
