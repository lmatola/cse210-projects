using System;
using System.Collections.Generic;
using System.Text;

public class Word
{
    private string _text;
    public bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
   
    public void Hide()
    {       
        _isHidden = true; 
    }

    public void Show()
    {       
       _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;        
    }

}