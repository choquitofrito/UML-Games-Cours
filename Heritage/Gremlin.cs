using System;

namespace Heritage
{
    public class Gremlin : AnimalDomestique
    {
        public string _nom;

        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
            }
        }

        public void attaquer(int forceAttaque)
        {
            Console.WriteLine("Je suis un Gremlin et j'attaque avec " + forceAttaque + "HP");
        }

    }
}