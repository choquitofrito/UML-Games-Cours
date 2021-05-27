using System;
using ClassesBase;
using Heritage;
using Association;

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
            Console.WriteLine("La force de perso1 est: " + perso1.Force); // appel au get
            perso1.Force += 25;
            Console.WriteLine("La force de perso1 est: " + perso1.Force); // appel au get

            Console.WriteLine(perso1.obtenirDescription());

            string msgDescription = perso1.obtenirDescription();
            Console.WriteLine(msgDescription);

            // Héritage
            AnimalDomestique animal1 = new AnimalDomestique();
            animal1.seDeplacer();


            Gremlin g = new Gremlin();
            g.seDeplacer();
            g.attaquer(90);

            // animal1.attaquer(90); non, pas dispo dans la clase mère/base
            Console.WriteLine(g);
            g.Nom = "Gizmo";
            Console.WriteLine("Le Gremlin est " + g.Nom);


            Level level1 = new Level();
            Console.WriteLine(level1);
            level1.Identifiant = 1;
            Console.WriteLine("You are on level" + level1.Identifiant);
            Brick brick1 = new Brick();
            Console.WriteLine(brick1);
            brick1.Type = "Red";
            Console.WriteLine("The brick type is " + brick1.Type);
            brick1.seCasser();
            Brick brick2 = new Brick();
            Console.WriteLine(brick2);
            brick2.Type = "Blue";
            Console.WriteLine("The brick type is " + brick2.Type);
            brick2.seCasser();
            level1.Rajouter(brick1);
            level1.Rajouter(brick2);
            level1.AfficherBricks();

        }
    }
}


// res = somme (4,5)
// write (res)

// write (somme (4,5))
