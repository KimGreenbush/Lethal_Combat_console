using System;
using System.Collections.Generic;

namespace lethal_combat
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("\nWELCOME TO LETHAL COMBAT!\n");

            Human player1 = new Human("temp");
            Human player2 = new Human("temp");

            System.Console.WriteLine("Player 1: Choose your Class:");
            string warrior = Console.ReadLine();
            if(warrior == "Knight"){
                System.Console.WriteLine("Player 1: Choose your Name:");
                player1 = new Knight(Console.ReadLine());
                player1.print();
            } else if (warrior == "Viking")
                {
                    System.Console.WriteLine("Player 1: Choose your Name:");
                    player1 = new Viking(Console.ReadLine());
                    player1.print();
                }

            System.Console.WriteLine();

            System.Console.WriteLine("Player 2: Choose your Class:");
            warrior = Console.ReadLine();
            if(warrior == "Knight"){
                System.Console.WriteLine("Player 2: Choose your Name:");
                player2 = new Knight(Console.ReadLine());
                player2.print();
            } else if (warrior == "Viking")
                {
                    System.Console.WriteLine("Player 2: Choose your Name:");
                    player2 = new Viking(Console.ReadLine());
                    player2.print();
                }
            System.Console.WriteLine("\nNew Players");
            player1.print();
            player2.print();

            System.Console.WriteLine();
            player1.printWeapons();
            System.Console.WriteLine();

            while(true){

                //PLAYER 1 ATTACK
                if(player1.Health > 0){
                    player2.print();
                    player1.print();
                    System.Console.WriteLine($"\n{player1.Name}.. How do you want to attack?");
                    player1.printWeapons();
                    while(player1.Attack(Console.ReadLine(), player2) != true);

                } else {
                    System.Console.WriteLine($"\n{player2.Name} You Won! {player1.Name} is dead!");
                    break;
                }

                System.Console.WriteLine();

                //PLAYER 2 ATTACK
                if(player2.Health > 0){
                    player1.print();
                    player2.print();
                    System.Console.WriteLine($"\n{player2.Name} How do you want to attack?");
                    player1.printWeapons();
                    while(player2.Attack(Console.ReadLine(), player1) != true);

                } else {
                    System.Console.WriteLine($"\n{player1.Name}. You Won! {player2.Name} is dead!");
                    break;
                }
            }
        }
    }
}