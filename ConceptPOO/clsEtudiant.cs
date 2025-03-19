using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPOO
{
    class clsEtudiant : clsPersonne
    {
        string promotion;
        string option;

        void AfficherEt()
        {
            Console.WriteLine(this.promotion);
            Console.WriteLine(this.option);
        }
    }
}
