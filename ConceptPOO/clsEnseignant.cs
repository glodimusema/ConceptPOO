using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPOO
{
    class clsEnseignant : clsPersonne
    {
        string poste;
        string fonction;

        public string Poste { get => poste; set => poste = value; }
        public string Fonction { get => fonction; set => fonction = value; }

        public override void  Afficher()
        {
            base.Afficher();
            Console.WriteLine(this.Poste);
            Console.WriteLine(this.Fonction);
        }
    }
}
