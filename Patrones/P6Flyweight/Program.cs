using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            CAuto lada = new CAuto("2105", "lada", 5000, 4, 1.5, 1200, 0.025);
            CAuto porche1 = new CAuto("cayman", "porshe", 90000, 4.6, 1.7, 900, 0.1);
            CAuto mustang = new CAuto("GT", "Ford Mustang", 120000, 5, 1.8, 2000, 0.2);
            CAuto wat = new CAuto("p-34", "Wat", 7000, 3, 1.6, 1200, 0.025);
            CAuto cil = new CAuto("250", "cil", 12000, 7, 2, 12000, 0.1);
            CFlyweight almacen = new CFlyweight();
            Console.WriteLine(almacen.AdddAuto(lada));
            Console.WriteLine(almacen.AdddAuto(porche1));
            Console.WriteLine(almacen.AdddAuto(mustang));
            Console.WriteLine(almacen.AdddAuto(wat));
            Console.WriteLine(almacen.AdddAuto(cil));            

            List<int> economicos = new List<int>();
            List<int> gastones = new List<int>();
            List<int> pesados = new List<int>();
            List<int> livianos = new List<int>();
            List<int> baratos = new List<int>();
            List<int> caros = new List<int>();            

            foreach (CAuto item in almacen)
            {
                if (item.Economico())
                {
                    economicos.Add(almacen.GetIndex(item));
                }
                if (!item.Economico())
                {
                    gastones.Add(almacen.GetIndex(item));
                }
                if (item.Liviano())
                {
                    livianos.Add(almacen.GetIndex(item));
                }
                if (!item.Liviano())
                {
                    pesados.Add(almacen.GetIndex(item));
                }
                if (item.Precio() < 20000)
                {
                    baratos.Add(almacen.GetIndex(item));
                }
                if (item.Precio() > 20000)
                {
                    caros.Add(almacen.GetIndex(item));
                }
            }            

            Console.WriteLine("--------------------");
            Console.WriteLine("Estos son los economicos:");
            foreach (int item in economicos)
            {
                CAuto auto = almacen.GetAuto(item);
                Console.WriteLine(auto.Marca + " " + auto.Modelo);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Estos son los gastones:");
            foreach (int item in gastones)
            {
                CAuto auto = almacen.GetAuto(item);
                Console.WriteLine(auto.Marca + " " + auto.Modelo);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Estos son los livianos:");
            foreach (int item in livianos)
            {
                CAuto auto = almacen.GetAuto(item);
                Console.WriteLine(auto.Marca + " " + auto.Modelo);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Estos son los pesados:");
            foreach (int item in pesados)
            {
                CAuto auto = almacen.GetAuto(item);
                Console.WriteLine(auto.Marca + " " + auto.Modelo);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Estos son los baratos:");
            foreach (int item in baratos)
            {
                CAuto auto = almacen.GetAuto(item);
                Console.WriteLine(auto.Marca + " " + auto.Modelo);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Estos son los caros:");
            foreach (int item in caros)
            {
                CAuto auto = almacen.GetAuto(item);
                Console.WriteLine(auto.Marca + " " + auto.Modelo);
            }
            Console.ReadKey();
        }
    }
}
