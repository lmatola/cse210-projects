using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {     

        // While Loops

        // string response = "yes";

        // while (response == "yes")
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // }
           
         // For Loops
        // for (int i = 0; i <= 20; i +=2 )
        // {
        // Console.WriteLine(i);
        // }

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        // Console.WriteLine(magicNumber);

        string response = "yes";
        int userGuess = 0;
        int guessCount = 0;
        List<int> guessList = new List<int>();
        
  
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

                Console.Write("Do you want to continue? ");
                response = Console.ReadLine();
            } 
        
        } while( response == "yes");


                    // foreach (int num in guessList)
            // {
                // Console.WriteLine(num);
            // }            
            // for (int i = 0; i < guessList.Count; i++)
            // {
            //     Console.WriteLine(guessList[i]);
            // }                      
            // Console.WriteLine(guessCount); 
 
    }

    
}