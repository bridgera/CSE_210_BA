using System;

class Program
{
    static void Main(string[] args)
    {
        int guess_count = 0;
        int guess = 0;
        Random rnd = new Random();
        int random_int = rnd.Next(1,20);

        Console.WriteLine($"What is the magic number? {random_int}");

        while (guess != random_int)
        {
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess > random_int)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < random_int)
            {
                Console.WriteLine("Higher");
            }

            guess_count += 1;
        }
        
        Console.WriteLine($"You guessed it in {guess_count} guesses!");
    }
}