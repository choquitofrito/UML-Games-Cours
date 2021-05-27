using System;
using System.Collections.Generic;
namespace Association {
    public class Brick{
        private List<Level> levels = new List<Level>();
        public string _type;
        public string Type{
            get{
                return _type;
            }
            set{
                _type = value;
            }
        }
        public void seCasser(){
            Console.WriteLine("The brick has been hit!");
        }
    }
}