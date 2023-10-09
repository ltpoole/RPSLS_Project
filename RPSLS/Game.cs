using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n" +
                "Rock breaks Scissors\n" +
                "Scissors slices Paper\n" +
                "Paper smothers Rock\n" +
                "Rock kills Lizard\n" +
                "Lizard poisons Spock\n" +
                "Spock trashes Scissors\n" +
                "Scissors beheads Lizard\n" +
                "Lizard eats Paper\n" +
                "Paper weakens Spock\n" +
                "Spock shatters Rock\n" +
                "\n" +
                "Winner will be declared by winning best out of 3!\n" +
                "\n" +
                "How many people are playing?");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            return 0;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
        }
    }
}
