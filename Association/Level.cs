using System;
using System.Collections.Generic;
namespace Association{
    public class Level {
        private List<Brick> bricks = new List<Brick>();
        public int _identifiant;
        public int Identifiant {
            get{
                return _identifiant;
            }
            set{
                _identifiant = value;
            }
        }
        public void Rajouter(Brick brickVittoria){
            bricks.Add(brickVittoria);
        }
        public void AfficherBricks(){
            foreach (Brick unBrick in bricks)
            {
                Console.WriteLine(unBrick.Type);
            }
        }
    }
}