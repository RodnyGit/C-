using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            CAbstraccion abst;
            int opcion = 123;
            Dictionary<string, double> productos = new Dictionary<string, double>();
            productos.Add("Leche", 24);
            productos.Add("Manzana", 16);
            productos.Add("Caramelo", 54);
            productos.Add("Mango", 120);
            productos.Add("Cerdo", 300);
            productos.Add("papa", 20);
            productos.Add("Lechuga", 12);
            productos.Add("Tomate", 60);
            while (opcion != 0)
            {
                Console.WriteLine("K tipo de implementacion desea (1 - 2 - 3) o 0 para salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion > 0 && opcion < 4)
                {
                    abst = new CAbstraccion(opcion, productos);
                    abst.Mostrar();
                }
                else
                {
                    Console.WriteLine("Opcion incorrepta");
                }

            }
        }
    }
}
