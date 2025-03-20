using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            clsEnseignant ens1 = new clsEnseignant();
            ens1.Noms="KAKULE";
            ens1.Id=1;
            ens1.Age = 20;
            ens1.Taille = 2;
            ens1.Poste = "Enseignant";
            ens1.Fonction = "Chef de section";


            //ens1.Afficher();

            //clsSurcharge data = new clsSurcharge();
            //int x=0, y=0, z=0;

            //data.Addition(x, y,z);



            IAnimal chien1 = new clsChien();
            IAnimal chat1 = new clsChat();

            chien1.FaireDuBruit();
            chat1.FaireDuBruit();



            Console.Read();
        }
    }
}
