namespace RandomNumberGuessingGame
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();

            int randomNum = random.Next(1, 99);
            int maxAttempts = 6;
            int attempts = 0;
            int guess;

            Console.WriteLine("You have 6 tries to guess the random number");

            while (attempts < maxAttempts)
            {
                Console.WriteLine("Enter your guess:");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess < randomNum)
                    {
                        Console.WriteLine("Too low. Guess higher!");
                    }
                    else if (guess > randomNum)
                    {
                        Console.WriteLine("Too high. Guess lower!");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it right!");
                        return;
                    }
                    attempts++;
                }
            }
            Console.WriteLine("You ran out of tries.");
            Console.WriteLine("The number was: " + randomNum);

        }
    }
}