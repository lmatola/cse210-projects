using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Program 1: Abstraction with YouTube Videos");
        Console.WriteLine();

        Console.WriteLine("---------------------------------");
        Console.WriteLine("         VIDEO 1                 ");
        Console.WriteLine("---------------------------------");

        Video video1 = new Video();
        video1._videoTitle = "Girls Need Love";
        video1._videoAuthor = "Sumer Walker";
        video1._videoLength = 153;


        Comment comment1 = new Comment();
        comment1._userName = "zensoundsarah9209";
        comment1._commentText = "This hit so hard, when you come from a life where you're shamed for being a woman, having needs or expressing anything";

        Comment comment2 = new Comment();
        comment2._userName = "therealkoolaidandkale";
        comment2._commentText = "The ONLY bad thing about this song is that it's not long enough";

        Comment comment3 = new Comment();
        comment3._userName = "webbster78724";
        comment3._commentText = "I miss old Summer "; 

        video1._videoComments.Add(comment1);
        video1._videoComments.Add(comment2);
        video1._videoComments.Add(comment3);     


        video1.DisplayVideo();
    
        Console.WriteLine();

        Console.WriteLine("---------------------------------");
        Console.WriteLine("         VIDEO 2                 ");
        Console.WriteLine("---------------------------------");

        Video video2 = new Video();
        video2._videoTitle = "Hello";
        video2._videoAuthor = "Lionel Richie ";
        video2._videoLength = 326;

        Comment comment4 = new Comment();
        comment4._userName = "ZonSol";
        comment4._commentText = "I am leaving a comment so that after a month, or a year, or a decade when someone likes it, i get a reminder to listen to this beautiful song again.";

        Comment comment5 = new Comment();
        comment5._userName = "gihanchathuranga4479";
        comment5._commentText = "Someone here who is listening this song  in 2024";

        Comment comment6 = new Comment();
        comment6._userName = "SoftRockForever";
        comment6._commentText = "This song is 45 years old and still sounds better than any song today.";

        video2._videoComments.Add(comment4);
        video2._videoComments.Add(comment5);
        video2._videoComments.Add(comment6);
     
        video2.DisplayVideo();
        Console.WriteLine();
        
        Console.WriteLine("---------------------------------");
        Console.WriteLine("         VIDEO 3                 ");
        Console.WriteLine("---------------------------------");

        Console.WriteLine();

        Video video3 = new Video();
        video3._videoTitle = "Please Forgive Me";
        video3._videoAuthor = "Bryan Adams";
        video3._videoLength = 377;        

        video3.DisplayVideo();

        Comment comment7 = new Comment();
        comment7._userName = "romii3139";
        comment7._commentText = "Happy Valentines to everyone out there that found that special person and never let go since❤";

        Comment comment8 = new Comment();
        comment8._userName = "gersonsaihmang592";
        comment8._commentText = "56 year old , today...so glad young people are still listening to this... commenting from my son's youtube account ,Spend your youth carefully";

        Comment comment9 = new Comment();
        comment9._userName = "ilumizoldic";
        comment9._commentText = "If you are reading this. You have a good taste in music";

        video3._videoComments.Add(comment7);
        video3._videoComments.Add(comment8);
        video3._videoComments.Add(comment9);

        Console.WriteLine();

    }
}