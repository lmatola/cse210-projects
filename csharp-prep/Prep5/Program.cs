using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = userName();
        int number = userNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);         
    }     
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }       
        
        static string userName()      
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }
            
        static int userNumber()      
        {     
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;           
        }      
     
        static int SquareNumber(int number)      
        {          
           int square = number * number;

           return square;
        }        
      

        static void DisplayResult(string name, int square)      
        {
            Console.WriteLine($"{name} The square  of your number is: {square}");           
        }   
 
        

}