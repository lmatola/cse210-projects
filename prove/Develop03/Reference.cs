public class Reference
{
    private string _book;
    private int _chapter;
    private int _Verse;
    private int _endVerse;



    public Reference(string book, int chapter, int verse)

    {
        _book = book;
        _chapter = chapter;
        _Verse = verse;


    }

    public Reference(string book, int chapter, int startVerse, int endVerse)

    {
        _book = book;
        _chapter = chapter;
        _Verse = startVerse;
        _Verse = endVerse;

        
    }

    public string GetDisplayText()  //string
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }

}