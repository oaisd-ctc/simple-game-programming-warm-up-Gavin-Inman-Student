using System;
public class Program
{
    
    private static int youScore;
    private static int rivalScore;
    public static void Main()
    {
        OnStart();
        DiceAction();
        OnEnd();

    }

    public static void OnStart()
    {
        Console.WriteLine("Dice Game");
        Console.WriteLine("");
        Console.WriteLine("In this game you and a computer Rival will play 10 rounds");
        Console.WriteLine("where you will each roll a 6-sided dice, and the player");     
        Console.WriteLine("with the highest dice value will win the round. The player");
        Console.WriteLine("who wins the most rounds wins the game. Good luck!");
        Console.WriteLine("");
        Console.Write("Press any key to start...");
        OnNext();
    }

    public static void DiceAction()
    {
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Round {i}");
            int rival = Roulette();
            Console.WriteLine($"Rival rolled a {rival}");
            Console.Write("Press any key to roll the dice...");
            OnNext();
            Console.WriteLine();
            int you = Roulette();
            Console.WriteLine($"You rolled a {you}");

            if (you < rival)
            {
                Console.WriteLine("The Rival won this round.");
                rivalScore++;
            }

            else if (you > rival)
            {
                Console.WriteLine("You won this round.");
                youScore++;
            }

            else
            {
                Console.WriteLine("This round is a draw!");
            }

            Console.WriteLine($"The score is now - You : {youScore}. Rival : {rivalScore}.");
            Console.Write("Press any key to continue...");
            OnNext();
            Console.WriteLine();
        }
    }

    public static void OnEnd()
    {
        Console.WriteLine("Game over.");
        Console.WriteLine($"The score is now - You : {youScore}. Rival : {rivalScore}.");
        if (youScore < rivalScore)
            {
                Console.WriteLine("You lost!");
            }

            else if (youScore > rivalScore)
            {
                Console.WriteLine("You won!");
            }

            else
            {
                Console.WriteLine("Draw!");
            }

            Console.WriteLine("Press any key to exit");
            OnNext();
            Console.WriteLine();

    }

    public static void OnNext()
    {
        var left = Console.CursorLeft;
        var top = Console.CursorTop;
        Console.ReadKey();
        Console.SetCursorPosition(left, top);
        Console.WriteLine(" ");
    }
    
    public static int Roulette()
    {
        Random rnd = new Random();
        int diceNumber = rnd.Next(1,6);
        return diceNumber;
    }
}