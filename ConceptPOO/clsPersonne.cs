using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPOO
{
    class clsPersonne
    {
        private int id;
        private string noms;
        private int age;
        private float taille;

        public int Id { get => id; set => id = value; }
        public string Noms { get => noms; set => noms = value; }
        public int Age { get => age; set => age = value; }
        public float Taille { get => taille; set => taille = value; }

        public virtual void Afficher()
        {
            Console.WriteLine(this.Id);
            Console.WriteLine(this.Noms);
            Console.WriteLine(this.Age);
            Console.WriteLine(this.Taille);
        }
    }
}
