namespace GuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);  // 1 as lower bound , 11 as upper bound

            Console.WriteLine("Number Guessing Game");
            Console.WriteLine("A Random Number Between 1-10 Will Be Generated.");
            Console.WriteLine("If you guess the correct number, you win!");

            while (!isCorrectGuess)
            {
                Console.WriteLine("Enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if(guess> randomNum)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else if(guess < randomNum)
                {
                    Console.WriteLine("Your guess is too low");
                }
                else
                {
                    Console.WriteLine("Correct! Well Done.");
                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("Goodjob, you won!");

            Console.ReadKey();



        }
    }
}
