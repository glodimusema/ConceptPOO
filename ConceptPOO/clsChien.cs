using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPOO
{
    class clsChien : IAnimal
    {
        string noms;
        void IAnimal.FaireDuBruit()
        {
            Console.WriteLine("Le chien aboie");
        }

        void IAnimal.Manger()
        {
            Console.WriteLine("Le Chien mange");
        }
    }
}
