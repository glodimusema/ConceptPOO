using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPOO
{
    class clsSurcharge
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine("Entrez un nombre ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le deuxieme nombre ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Somme = " + (a + b));

        }
        public void Addition(int a, int b,int c)
        {
            Console.WriteLine("Entrez un nombre ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le deuxieme nombre ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le troisieme nombre ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Somme = " + (a + b+c));

        }
    }
}
