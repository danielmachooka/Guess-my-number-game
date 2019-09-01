using System;

namespace guess_my_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello  welcome to guessing game World!");
            int guess;
            //Create an oject of the Random class
            Random number = new Random();
            _ = number.Next(1, 1000);

            
            int answer = number.Next(1, 1000);
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Select Randomly Number between 1 and 1000 ");
            //   guess = (Convert.ToInt32(Console.ReadLine()));
            for (int i = 1; i <= 500; i++)
            {
                Console.Write("Enter Number :");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > answer)
                {
                    Console.WriteLine("Guess is Higher");
                }
                else if (guess < answer)
                {
                    Console.WriteLine("Guess is Lower");
                }
                else
                {

                    Console.WriteLine("Your number is half !!\t {0} is the correct number", guess);
                    break;

                }
            }
            Console.WriteLine("Your number is half the total");
            Console.WriteLine("The answer is {0} ", answer);
            Console.ReadKey();
        }
    }
}