using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            CNodo root = new CNodo();
            CNodo b = new CNodo("b", root);
            root.AddNodo(b);
            CNodo c = new CNodo("c", root);
            root.AddNodo(c);
            CNodo j = new CNodo("j", root);
            root.AddNodo(j);
            CNodo l = new CNodo("l", root);
            root.AddNodo(l);
            CNodo r = new CNodo("r", root);
            root.AddNodo(r);
            CNodo d = new CNodo("d", c);
            c.AddNodo(d);
            CNodo f = new CNodo("f", c);
            c.AddNodo(f);
            CNodo k = new CNodo("k", j);
            j.AddNodo(k);
            CNodo m = new CNodo("m", l);
            l.AddNodo(m);
            CNodo n = new CNodo("n", l);
            l.AddNodo(n);
            CNodo o = new CNodo("o", l);
            l.AddNodo(o);
            CNodo s = new CNodo("s", r);
            r.AddNodo(s);
            CNodo g = new CNodo("g", f);
            f.AddNodo(g);
            CNodo h = new CNodo("h", f);
            f.AddNodo(h);
            CNodo i = new CNodo("i", f);
            f.AddNodo(i);
            CNodo p = new CNodo("p", o);
            o.AddNodo(p);
            CNodo q = new CNodo("q", o);
            o.AddNodo(q);
            CNodo t = new CNodo("t", s);
            s.AddNodo(t);
            
            Console.WriteLine(((CNodo)root.Buscar(t)).Nombre);

            Console.WriteLine(Convert.ToString(i.Nivel()));

            foreach (CNodo item in m.Hermanos())
            {
                Console.WriteLine(item.Nombre);
            }
            Console.ReadKey();




        }
    }
}
