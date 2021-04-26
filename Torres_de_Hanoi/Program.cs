using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Disco peq(1);
            Disco med(2);
            Disco gra(3);

            Disco[3] nuevaPila = { peq, med, gra};

            Pila a(nuevaPila);
            Pila b();
            Pila c();

            Console.WriteLine(Hanoi.iterativo( a, c, b));

            Console.WriteLine(a.getDiscoAt(0).getValor());

            Hanoi.mover_disco( a, c);

            Console.WriteLine(a.getDiscoAt(0).getValor());
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
