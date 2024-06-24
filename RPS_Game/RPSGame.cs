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

            while (player.Score < 3 && ai.Score < 3)
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
            string[] moves = { "r", "p", "s" };
            string aiMove = moves[aiChoice];

            Console.WriteLine($"AI chooses {GetMoveName(aiMove)}");

            if (playerChoice == aiMove)
            {
                Console.WriteLine("Tie");
                return "Tie";
            }
            else if ((playerChoice == "r" && aiMove == "s") ||
                     (playerChoice == "p" && aiMove == "r") ||
                     (playerChoice == "s" && aiMove == "p"))
            {
                Console.WriteLine("You win this round!");
                playerScore++;
                return "You win this round!";

            }
            else
            {
                Console.WriteLine("You lose");
                aiScore++;
                return "You lose";
            }
            
        }

        private string GetMoveName(string move)
        {
            switch (move)
            {
                case "r":
                    return "Rock";
                case "p":
                    return "Paper";
                case "s":
                    return "Scissors";
                default:
                    throw new ArgumentException("Invalid move");
            }
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
