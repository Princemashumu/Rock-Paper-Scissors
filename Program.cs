using System;

class Program
{
    static void Main()
    {
        string[] choices = { "rock", "paper", "scissors" };
        Random rand = new Random();
        int userScore = 0, computerScore = 0;

        Console.WriteLine("Welcome to Rock-Paper-Scissors!");
        
        while (true)
        {
            Console.Write("Enter Rock, Paper, or Scissors (or type 'exit' to quit): ");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice == "exit")
            {
                Console.WriteLine("Thanks for playing! Final Score - You: {0}, Computer: {1}", userScore, computerScore);
                break;
            }

            if (Array.IndexOf(choices, userChoice) == -1)
            {
                Console.WriteLine("Invalid choice, please try again.");
                continue;
            }

            string computerChoice = choices[rand.Next(3)];
            Console.WriteLine("Computer chose: " + computerChoice);

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                     (userChoice == "paper" && computerChoice == "rock") ||
                     (userChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win!");
                userScore++;
            }
            else
            {
                Console.WriteLine("Computer wins!");
                computerScore++;
            }

            Console.WriteLine("Score - You: {0}, Computer: {1}\n", userScore, computerScore);
        }
    }
}
