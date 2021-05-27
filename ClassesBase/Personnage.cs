using System;

namespace ClassesBase
{
    public class Personnage
    {
        public int _force;
        public int _stamina;

        public int Force
        {
            get
            {
                return _force;
            }
            set
            {
                _force = value;
            }
        }

        public int Stamina
        {
            get
            {
                return _stamina;
            }
            set
            {
                _stamina = value;
            }
        }

        public void seDeplacer (){
            Console.WriteLine ("Je bouge!");
        }
        public void attaquer (){
            Console.WriteLine ("J'attaque!!");
        }


        public string obtenirDescription (){
            string description = "Je suis un personnage d'un jeu";
            return (description);
        }
    }

}