using System;
using System.Collections.Generic;

namespace lethal_combat {
    class Knight : Human
    {

        public Knight(string name) : base(name){
                Health = 100;
                Dexterity = 50;
                Strength = 80;
        }

        public override void print(){
            System.Console.WriteLine($"Knight: {Name} Health: {Health}");
        }


    }
}