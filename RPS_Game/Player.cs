using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public string ChooseMove()
        {
            Console.WriteLine("Please Enter\n [R] for Rock\n [P] for Paper\n [S] for Scissors");
            string choice = Console.ReadLine().ToLower();

            while (choice != "r" && choice != "p" && choice != "s")
            {
                Console.WriteLine("Invalid choice. Please enter [R] for Rock, [P] for Paper, [S] for Scissors");
                choice = Console.ReadLine().ToLower();
            }

            return choice;
        }
    }
}  