using System;

namespace ProyectCode4Girls
{
    class Program
    {

        private static Vehiculo Agregar(int numTipo)
        {
            Vehiculo vehiculo;
            try
            {
                Console.WriteLine("Matricula: ");
                string matricula = Console.ReadLine();
                Console.WriteLine("Precio: ");
                int precio= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Año: ");
                int anio = Convert.ToInt32(Console.ReadLine());


                if (numTipo == 1)
                {
                   
                    Console.WriteLine("Numero de Puertas: ");
                    int numDePuertas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Color: ");
                    string color = Console.ReadLine();
                    vehiculo = new Automovil(matricula, anio,precio, marca, modelo, cantidad, numDePuertas,  color);

                }
                else
                {
                    Console.WriteLine("Numero de Ruedas: ");
                    int numDeRuedas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Peso: ");
                    float peso= Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Color: ");
                    string tipo = Console.ReadLine();
                    vehiculo = new Camioneta(matricula, anio, precio, marca, modelo, cantidad, numDeRuedas);

                }
            }
            catch (Exception)
            {

                throw;
            }

            return vehiculo;
        }
        private static void Visualizar(Vehiculo[] vehiculo)
        {
            Console.WriteLine("Tipos aexistentes:  ");
            foreach (var item in vehiculo)
            {
                if (item.Cantidad != 0)
                {
                    Console.WriteLine($"Marca: {item.Marca} Modelo: {item.Modelo} Año: {item.Año}");
                }
            }

            Console.WriteLine("Tipos agotados: ");
            foreach (var item in vehiculo)
            {
                if (item.Cantidad==0)
                {
                    Console.WriteLine($"Marca: {item.Marca} Modelo: {item.Modelo} Año: {item.Año}");
                }
            }
        }

        public static void Vender(Vehiculo[] vehiculo)
        {
            Console.WriteLine("Seleccione el tipo de vehiculo");
            foreach (var item in vehiculo)
            {
                int i = 1;
                Console.WriteLine($" {i} Marca: {item.Marca} Modelo: {item.Modelo} Año: {item.Año}");
                i++; 
            }

            int seleccion = 0;
            try
            {
                seleccion = Convert.ToInt32(Console.ReadLine());
                if(vehiculo[seleccion-1]!=null)
                {
                    Console.WriteLine("Elija la cantidad");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    if(vehiculo[seleccion-1].Cantidad<cantidad)
                    {
                        Console.WriteLine("La cantidad pedida es menor a la cantidad existente");
                    }
                    else
                    {
                        decimal total = vehiculo[seleccion - 1].Precio * cantidad;
                        vehiculo[seleccion - 1].Cantidad -= cantidad;
                        Console.WriteLine("Felicidades por su compra, el total es: {total}");
                    }
                }
;            }
            catch (FormatException)
            {
                Console.WriteLine("Introdujo dato invalido");

                throw;
            }

        }
        static void Main(string[] args)
        {
            Vehiculo[] vehiculo = new Vehiculo[500];
            int  cont=0;
            int opcion = 0;
            do
            {
                Console.WriteLine("Bienvenido a Ana RentA Car:\n 1-Agregar Vehiculo\n2-Listar Vehiculos\n3-Vender Vehiculo\n4-Salir ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Desea agregar\n1-Automovil\n2-Camioneta");
                        int t = Convert.ToInt32(Console.ReadLine());
                        vehiculo[cont] = Agregar(t);
                        Console.WriteLine("Agregado ");
                        break;
                    case 2:
                        Visualizar(vehiculo);
                        break;
                    case 3:
                        Vender(vehiculo);
                        break;
                    case 4:
                        Console.WriteLine("Adios");
                        break;
                    default:
                        break;
                }

            } while (opcion != 4);
            
        }
    }
}
