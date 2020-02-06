using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Proxy
{
    class CRestaurant
    {
        private Cocina cocina;

        public string autenticacion(string password)
        {
            if (password == "asd")
            {
                if (cocina == null)
                {
                    cocina = new Cocina();
                }
                return "ok";
            }
            return "wrong";
        }
        public void atencion(string receta, int cant)
        {
            if (cocina == null)
            {
                Console.WriteLine("Debe autenicarse primero...");
            }
            else
            {
                cocina.cocinar(receta, cant);
            }
        }

        private class Cocina
        {
            private void desayuno()
            {
                Console.WriteLine("Calentando leche");
                Console.WriteLine("Friendo dos huevos");
                Console.WriteLine("Picando pan");
            }
            private void merienda()
            {
                Console.WriteLine("Hirviendo huevos");
                Console.WriteLine("Picando tomates");
                Console.WriteLine("Preparando aguahzuca");
            }

            public void cocinar(string receta, int cant)
            {
                switch (receta)
                {
                    case "desayuno":
                        {
                            while (cant > 0)
                            {
                                desayuno();
                                cant--;
                            }
                            break;
                        }
                    case "merienda":
                        {
                            while (cant > 0)
                            {
                                merienda();
                                cant--;
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("No se conoce esa receta...");
                        break;
                }
            }

        }
    }
}
