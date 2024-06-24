using Xunit;
using RPS_Game;
using System.Text;

namespace RPS_GameTest
{
    public class UnitTest1
    {
        [Fact]
        public void PlayerWinsRound()
        {
            // Arrange
            var game = new RPSGame();
            var player = new Player("Player");

            // Act           
            string result = game.DetermineWinner("r", 2);

            // Assert
            Assert.Equal("You win this round!", result); 
        }
        [Fact]
        public void TieRound()
        {
            // Arrange
            var game = new RPSGame();
            var player = new Player("Player");

            // Act           
            string result = game.DetermineWinner("s", 2);

            // Assert
            Assert.Equal("Tie", result);
        }
        [Fact]
        public void LoseRound()
        {
            // Arrange
            var game = new RPSGame();
            var player = new Player("Player");

            // Act           
            string result = game.DetermineWinner("s", 0);

            // Assert
            Assert.Equal("You lose", result);
        }


        [Fact]
        public void TestScoreUpdate()
        {
            // Arrange
            Player player = new Player("reem");
            RPSGame game = new RPSGame();


            int initialPlayerScore = player.Score;
            int initialAIScore = game.aiScore;

            // Act
            game.DetermineWinner("r", 1);

            // Assert
            Assert.Equal(initialPlayerScore, player.Score);
            Assert.Equal(initialAIScore + 1, game.aiScore);
        }
    }
}
