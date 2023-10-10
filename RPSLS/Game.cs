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
                "\n");
            

        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("How many players? Choose 1 or 2");
            string userInput = Console.ReadLine();
            int convertedInput = int.Parse(userInput);
            int numberOfPlayers;

            if(convertedInput == 1)
            {
                numberOfPlayers = 1;
            }
            else
            {
                numberOfPlayers = 2;
            }


            return numberOfPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            Console.WriteLine("Player One, what is your name?");
            string playerName = Console.ReadLine();
            this.playerOne = new HumanPlayer(playerName);
            this.playerTwo = new HumanPlayer(playerName);

            if (numberOfHumanPlayers == 1)
            {
                this.playerOne = new HumanPlayer("");
                this.playerTwo = new ComputerPlayer("CPU");
            }
            else
            {
                this.playerOne = new HumanPlayer("");
                this.playerTwo = new HumanPlayer("");
            }

        }

        public void CompareGestures()
        {
        

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            // TODO: Write the full game algorithm per the user story instructions
            // TODO: Create the ComputerPlayer class (inherit from Player)
            // TODO: Make sure to test!

            // Step 1: Display welcome message and rules.
            // Step 2: Ask user to select multiplayer or single player
            // Step 3: Player 1 Selects their gesture
            // Step 4: Player 2/CPU selects their gesture
            // Step 5: Compare gestures to determine the winner of the round.
            // Step 6: Add a score to the winner of each round.
            // Step 7: Display game winner.


            WelcomeMessage();
            int numberOfHumanPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numberOfHumanPlayers);
            

        }
    }
}
