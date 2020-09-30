using System;
using System.Collections.Generic;

namespace lethal_combat {
    class Human {
        public string Name;
        public int Health;
        protected int Dexterity;
        protected int Strength;

        protected List<string> weapons;

        public Human(string name) {
            Name = name;
            weapons =new List<string>()
            {
            "Sword", "Axe", "Bow"
            };

        }
        public void printWeapons(){
            System.Console.WriteLine($"Weapon choices: {weapons[0]} , {weapons[1]}, {weapons[2]}");

        }

        public bool Attack(string weapon, Human target){
            Random rand = new Random();
            int damage = 0;
            if(weapon == "Sword"){

                if (rand.Next(10) <= 2) {
                    System.Console.WriteLine($"\n{target.Name} Dodged! You did {damage} points of damage with {weapon}!");
                } else {
                    damage = (int)((double)20.00 * (double)(Strength)/100.00);
                    target.Health -= damage;
                    System.Console.WriteLine($"\nYou did {damage} points of damage!");
                }
                return true;
            }

            else if(weapon == "Axe"){
                if (rand.Next(10) <= 5) {
                    System.Console.WriteLine($"\n{target.Name} Dodged! You did {damage} points of damage with {weapon}!");
                } else {

                damage = (int)((double)50.00 * (double)(Dexterity)/100.00);
                target.Health -= damage;
                System.Console.WriteLine($"\nYou did {damage} points of damage with {weapon}!");
                }
                return true;
            }

            else if(weapon == "Bow"){
                if (rand.Next(10) <= 4) {
                    System.Console.WriteLine($"\n{target.Name} Dodged! You did {damage} points of damage with {weapon}!");
                } else {

                damage = (int)((double)15.00 * (double)(Dexterity)/100.00);
                target.Health -= damage;
                System.Console.WriteLine($"\nYou did {damage} points of damage with {weapon}!");
                }
                return true;
            }
            else {
                System.Console.WriteLine("\nThat is not a weapon choose again!");
                return false;
            }

        }

        public virtual void print(){
            System.Console.WriteLine($"{Name} Health: {Health}");
        }

    }
}