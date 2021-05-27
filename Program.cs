using System;
using ClassesBase;

namespace UML_Games_Cours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wads!");
            Personnage perso1 = new Personnage();
            //Personnage perso2 = new Personnage();
            perso1.seDeplacer();
            perso1.attaquer();
            perso1.Force = 50; // appel au set
            Console.WriteLine ("La force de perso1 est: " + perso1.Force); // appel au get
            perso1.Force += 25;
            Console.WriteLine ("La force de perso1 est: " + perso1.Force); // appel au get
            Console.WriteLine(perso1.obtenirDescription());
            string msgDescription = perso1.obtenirDescription();
            Console.WriteLine (msgDescription);
        }
    }
}


// res = somme (4,5)
// write (res)

// write (somme (4,5))
