using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace RPS_Game
{
    public class RPSGame
    {
        private Player player;
        private Player ai;

        private Random random;

        public RPSGame()
        {
            player = new Player("Player");
            ai = new Player("AI");
            random = new Random();
        }

        public int playerScore = 0;
        public int aiScore = 0;

        public void StartGame()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Game");

            while (playerScore < 3 && aiScore < 3)
            {
                PlayRound();
            }

            DisplayFinalResults();
        }

        private void PlayRound()
        {
            Console.WriteLine($"Your Score - {playerScore}\nAI Score - {aiScore}");
            Console.WriteLine("------------------------------------------------------\n");

            string playerChoice = player.ChooseMove();
            int aiChoice = random.Next(0, 3);

            DetermineWinner(playerChoice, aiChoice);
        }

        public string DetermineWinner(string playerChoice, int aiChoice)
        {

            if (aiChoice == 0)
            {
                Console.WriteLine("AI chooses Rock");
                switch (playerChoice)
                {
                    case "r":
                        Console.WriteLine("Tie");
                        return "Tie";
                        
                    case "p":
                        Console.WriteLine("You win this round!");
                        playerScore++;
                        return "You win this round!";
                        
                    case "s":
                        Console.WriteLine("You lose");
                        aiScore++;
                        return "You lose";
                        
                
                }
            }
            else if (aiChoice == 1)
            {
                Console.WriteLine("AI chooses Paper");
                switch (playerChoice)
                {
                    case "r":
                        Console.WriteLine("You lose");
                        aiScore++;
                        return "You lose";
                        
                    case "p":
                        Console.WriteLine("Tie");
                        return "Tie";
                        
                    case "s":
                        Console.WriteLine("You win this round!");
                        playerScore++;
                        return "You win this round!";
                        
                }
            }
            else
            {
                Console.WriteLine("AI chooses Scissors");
                switch (playerChoice)
                {
                    case "r":
                        Console.WriteLine("You win this round!");
                        playerScore++;
                        return "You win this round!";
                        
                    case "p":
                        Console.WriteLine("You lose");
                        aiScore++;
                        return "You lose";
                        
                    case "s":
                        Console.WriteLine("Tie");
                        return "Tie";
 
                }
            }
            return "Invalid Input";
        }



        private void DisplayFinalResults()
        {
            if (playerScore == 3)
            {
                Console.WriteLine($"You Win! {playerScore} - {aiScore}");
            }
            else
            {
                Console.WriteLine($"You lose. {playerScore} - {aiScore}");
            }
        }
    }
}
