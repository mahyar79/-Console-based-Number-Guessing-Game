using System;

public class Player
{
    public string Name { get; set; }

    public Player(string name)
    {
        Name = name;
    }
}

public class Game
{
    private Player _player;
    private int _theNumber;
    private int _maxNumber;

    public Game(Player player, int maxNumber = 100)
    {
        _player = player;
        _maxNumber = maxNumber;
        Random random = new Random();
        _theNumber = random.Next(1, maxNumber + 1); 
    }

    public void StartGame()
    {
        Console.WriteLine($"Welcome {_player.Name}! Try to guess the number between 1 and {_maxNumber}.");

        bool guessedCorrectly = false;

        while (!guessedCorrectly)
        {
            try
            {
                Console.Write("Enter your guess: ");
                
                

                
                int userGuess = int.Parse(Console.ReadLine());

               
                if (userGuess == _theNumber)
                {
                    Console.WriteLine("Congratulations! You've guessed the correct number.");
                    guessedCorrectly = true; 
                }
                else if (userGuess < _theNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }
            catch (FormatException)
            {
                
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();

        Player player = new Player(playerName);
        Game game = new Game(player);
        game.StartGame();
    }
}
