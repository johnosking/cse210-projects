using System;

class Program
{
    static void Main(string[] args)
    {
        Random radomGenerator = new Random();
        int magicNumber = radomGenerator.Next(1, 101);

        int guess = -1;


        while (guess != magicNumber)
        {
            Console.WriteLine("Guess a number between 1 and 101 ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);

            if (magicNumber == guess)
            {
                Console.WriteLine("You guessed the magic number!");
            }    
            else if (magicNumber > guess)
            {
                Console.WriteLine("You did not guess right. Guess Higher");
            }    

            else if (magicNumber < guess)
            {
                Console.WriteLine("You did not guess right. Guess Lower");
            }
            else
            {
                Console.WriteLine("You guessed it correctly");
            }
        }        
        
    }
}