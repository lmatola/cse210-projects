using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {     

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        // Console.WriteLine(magicNumber);

        int userGuess = 0;
        int guessCount = 0;
        List<int> guessList = new List<int>();
        string answer;
        bool Continue = true;        
  
        // int magicNumber = 1;

        do
        {            
            // Console.Write("What is the magic number? ");
            // Console.ReadLine();
            // magicNumber = int.Parse(Console.ReadLine());

            Console.Write("What is the your number? ");
            // Console.ReadLine();
            userGuess = int.Parse(Console.ReadLine());
            guessList.Add(userGuess); 
            guessCount = guessList.Count();            

            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }

            else if ( magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }

            else
            { 
                Console.WriteLine(" "); 
                Console.WriteLine("you guessed!");                
                Console.WriteLine($"You have guessed the number after" + " " + guessCount + " attempts");  
                Console.WriteLine(" ");         

                Console.Write("Do you want to continue? type YES/NO ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                
                if (answer == "YES")
                {
                    Continue = true;
                }

                else 
                {
                    Continue = false;
                    
                }          

            }

        } while( Continue);         

        Console.WriteLine("Thanks for playing!!"); 
    }

}