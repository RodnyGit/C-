using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Estrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            IEstrategia caculadora = new CSuma();
            char v = 'e';
            while (v != 's')
            {
                Console.WriteLine("Introduzca operacion +, -, *, /, s: salir");
                v = Convert.ToChar(Console.ReadLine());
                if ((v == '+') || (v == '-') || (v == '*') || (v == '/'))
                {
                    Console.WriteLine("Introduzca v1");
                    double v1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduzca v2");
                    double v2 = Convert.ToDouble(Console.ReadLine());
                    switch (v)
                    {
                        case ('+'):
                            {
                                caculadora = new CSuma();
                                break;
                            }
                        case ('-'):
                            {
                                caculadora = new CResta();
                                break;
                            }
                        case ('*'):
                            {
                                caculadora = new CMultiplicacion();
                                break;
                            }
                        case ('/'):
                            {
                                caculadora = new CDivision();
                                break;
                            }
                        default:
                            break;
                    }
                    Console.WriteLine(caculadora.Operacion(v1, v2));
                }

            }


        }
    }
}
