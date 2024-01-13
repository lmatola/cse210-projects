using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        int userNumber = 0;
        List<int> userNumberList = new List<int>();
        int numbersCount = 0;                    

        do
        {       
            Console.WriteLine(" ");
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber !=0) 
            {
                userNumberList.Add(userNumber);
                
            }        

        } while (userNumber != 0);

            numbersCount = userNumberList.Count();
            Console.WriteLine(numbersCount);        
            Console.WriteLine(" ");
            
            int sum = userNumberList.Sum();
            Console.WriteLine($"The sum is: {sum }");

            double aver = userNumberList.Average();
            Console.WriteLine($"The average is: {aver}");          
            
            int largest = userNumberList.Max();
            Console.WriteLine($"The largest number is: {largest} ");

            Console.WriteLine($"The smallest positive number is: "); 


            userNumberList.Sort();  // Sort the list in an ascending order            
            Console.WriteLine($"The sorted list is:");
            for (int i = 0; i < userNumberList.Count; i++)
            {
                int number = userNumberList[i];     
                Console.WriteLine(number);
            }   

        // Termina o trabalho principal
        // Data source 
        // int[] sequence = {20, 45, 50, 79, 90, 
        //                79, 89, 100, 567, 29};

        // // Display the sequence 
        // Console.WriteLine("The sequence is:"); 
        // foreach(int s in sequence) 
        // { 
        //     Console.WriteLine(s); 
        // } 
  
        // // Finding the maximum element 
        // // from the given sequence 
        // // Using Max function 
        // int result = sequence.Max(); 
        // Console.WriteLine("Maximum Value: " + result);

        // List<int> numbers = new List<int>{ 4, 2, -1, -5, 3 };
        // numbers.Sort();  // Sort the list in an ascending order
        
        // Console.WriteLine("Sorted numbers:");
        // Console.WriteLine("The smallest posive number is:");

        // for (int i = 0; i < numbers.Count; i++)
        // {
        //     int number = numbers[i];

        //     if ( number >= 0)        
            
        //     {       
        //     Console.WriteLine( number);            
        //     }           
            
        // }         

    }
}