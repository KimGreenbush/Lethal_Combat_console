using System;
using System.Collections.Generic;

namespace lethal_combat {
    class Viking : Human
    {

        public Viking(string name) : base(name){
                Health = 75;
                Dexterity = 100;
                Strength = 70;
        }

        public override void print(){
            System.Console.WriteLine($"Viking: {Name} Health: {Health}");
        }

    }
}