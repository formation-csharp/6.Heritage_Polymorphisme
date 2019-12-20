using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {

            Personne s1 = new Stagiaire("Chami");
            Personne f1 = new Formateur("Madani");

            Console.WriteLine(s1.Presentation());
            Console.WriteLine(f1.Presentation());

            


            Console.ReadKey();
        }
    }
}
