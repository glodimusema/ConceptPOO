using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPOO
{
    class clsChat : IAnimal
    {
        void IAnimal.FaireDuBruit()
        {
            Console.WriteLine("Le chat miole");
        }

        void IAnimal.Manger()
        {
            Console.WriteLine("Le chat mange");
        }
    }
}
