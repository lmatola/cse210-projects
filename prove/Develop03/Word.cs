public class Word
{
    private string _text;
    //private bool _isHidden;


    public string GetText()
    { 

        return _text;

    }

    public void SetText(string text)
    {
        _text = text;
    }

    public void Hide(string text)
    {

       _text = text;

    }


    public void Show(string text)
    {

       
        _text = text;

    }


    public bool IsHidden()
    {
        return "";
    }


    public string GetDisplayText()
    {
        return _text;
        
    }

}