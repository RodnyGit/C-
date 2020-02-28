using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace delegados
{
    class Program
    {
        static void Main(string[] args)
        {

            #region UsandoDelegados

            //Func<List<double>, double> func = Sumar;

            //func += Multiplicar;

            //List<double> valores = new List<double>();

            //valores.Add(13);
            //valores.Add(17);
            //valores.Add(19);
            //valores.Add(12);
            //valores.Add(14);
            //valores.Add(16);
            //valores.Add(18);

            //Console.WriteLine("Funciones con retornos");
            //foreach (Func<List<double>, double> item in func.GetInvocationList())
            //{
            //    Console.WriteLine(item(valores));
            //}

            //Action action = ShowMessage1;
            //action += ShowMessage2;
            //action += ShowMessage3;

            //Console.WriteLine("");
            //Console.WriteLine("--------------------");
            //Console.WriteLine("Acciones sin retorno");
            //action();

            #endregion

            List<int> pares = CNumero.Pares(20, SubscribirYProbarFunciones);

            Console.Write("Press a key...");
            Console.ReadKey();
        }

        #region  Funciones de los Delegados

        static void ShowMessage1() { Console.WriteLine("Action 1"); }
        static void ShowMessage2() { Console.WriteLine("Action 2"); }
        static void ShowMessage3() { Console.WriteLine("Action 3"); }


        static double Sumar(List<double> numeros)
        {
            double salida = 0;
            foreach (double item in numeros)
            {
                salida += item;
            }
            Console.WriteLine("Suma");
            return salida;
        }
        static double Multiplicar(List<double> numeros)
        {
            double salida = 1;
            foreach (double item in numeros)
            {
                salida *= item;
            }
            Console.WriteLine("Multiplicacion");
            return salida;
        }
        #endregion


        #region Segunda parte del uso de los delegados

        static public void MostrarNumero(int i)
        {
            Console.WriteLine("Analizando {0}", i);
        }

        static public void MostrarPar(int i)
        {
            if (i % 2 == 0)
                Console.WriteLine("Registrando {0}", i);
        }

        static void SubscribirYProbarFunciones(int i)
        {
            Action<int> funciones = MostrarNumero;
            funciones += MostrarPar;
            funciones(i);
        }


        #endregion

    }
}
