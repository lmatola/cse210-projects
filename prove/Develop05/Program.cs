using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
    }

        Console.WriteLine("AAA");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("___");

        // string input = "Trust in the LORD with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        // char[] delimiters = {' '};
        // string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        // Console.WriteLine(string.Join(" ", words));

            string str = "hellomatola";
            string strDisplayedAsUnderscores = new string('_', str.Length);


            Console.WriteLine(strDisplayedAsUnderscores);
            char guess = Convert.ToChar(Console.ReadLine().ToLower()); //reads the user's guess
            int guessIndex = str.IndexOf(guess); //gets the index of the character guessed in relation to the original word
            StringBuilder word = new StringBuilder(strDisplayedAsUnderscores); //converts the underscores into a StringBuilder string

            if (str.Contains(guess))  
            {
                Console.WriteLine(word.Replace('_', guess, guessIndex, 1));

                //if guess is contained in the original word
                //replace the indexed underscore with the 
                //guessed character

            }




        string hideText = "_____ __ ___ ____ ____ ___ _____ _____ ___ ____ ___ ____ _____ ___ ______________ __ ___ ___ ____ ___________ ____ ___ __ _____ ______ ___ ______";
        char[] delimiters = {' '};
        string[] words = hideText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
 
        Word hide = new Word();
        hide.SetText(string.Join(" ", words));
        Console.WriteLine(hide.Hide());
    }
}