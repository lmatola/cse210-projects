public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public string GetBook()
    {
        return _book;
    }


    public void SetBook(string book)
    {
        _book = book;
    }

    public int GetChapter()
    {
        return _chapter;
    }


    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

        
    public int GetVerse()
    {
        return _verse;
    }


    public void SetVerse(int verse)
    {
        _verse = verse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }


    public void SetEndVerse(int endverse)
    {
        _endVerse = endverse;
    }

    public string GetDisplayText()  //string
    {
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }

}