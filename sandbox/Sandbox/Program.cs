using System;

class Program
{
    static void Main(string[] args)

    // Example of Objects(book1 and book2).
    {
        Book book1 = new Book("Herry Potter", "JK Rowling", 400);
        Book book2 = new Book("The Lord of the Rings", "Tolkein", 700);
        Console.WriteLine(book1.author);
        Console.WriteLine(book2.author);

        Student student1 = new Student("Jim", "Business", 2.8);
        Student student2 = new Student("Pam", "Art", 3.6);
        Console.WriteLine(student1.HasHonors());
        Console.WriteLine(student2.HasHonors());

        Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
        Movie shrek = new Movie("The Shrek", "Adam Adamson", "PG");
        Console.WriteLine(avengers.Rating);
        Console.WriteLine(shrek.director);

        Chef chef = new Chef();
        chef.MakeChiken();
        
        ItalianChef italianChef = new ItalianChef();
        italianChef.MakeSalad();
   
    }

    // Example of Class Book. 
    class Book
    {
        public string title;
        public string author;
        public int pages;

        // Example of Constructors. 
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }  
    }

    // Example of Class Student. 
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        // Example of Constructors. 
        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        } 

        // Example of Methods. 
        public bool HasHonors()
        {
           if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }

        // Example of Class Movie. 
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        // Example of Constructors. 
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        // Example of Setter and Getter. 
        public string Rating
        {
            get { return rating;}
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR" )
                {
                    rating = value;
                }

                else {rating = "NR";}
            }
        } 
    }


// Example of inheritance
    class Chef
    {
        public void MakeChiken()
        {
            Console.WriteLine("The Chef makes chiken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }

    }

    class ItalianChef:Chef  // ItalianChef class inherite from class Chef all methods funtionality
    {
        public  override void MakeSpecialDish() // this method override method in line 118
        {
            Console.WriteLine("The Chef makes chiken parm");
        }

        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

    }
    
}