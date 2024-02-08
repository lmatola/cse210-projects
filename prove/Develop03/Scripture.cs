using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

public class Scripture
{
    private Reference _references;  
    private List<Word> _words = new List<Word>();
    
    public Scripture(Reference references, string text)
    {       
        string[]words = text.Split(" ");
       _references = references;

        foreach (string sWord in words) 
        {
            Word word = new Word(sWord);
            _words.Add(word);
        } 
    }

    public void GetDisplayText()
    {        
        _references.DisplayText();

        foreach (Word word in _words)
        {
            word.GetDisplayText();
        }
    }

    public bool IsCompletlyHidden()  //bool
    {
        bool isCompletlyHidden = true;

        foreach (Word word in _words)
        {   
            isCompletlyHidden = isCompletlyHidden && word.IsHidden();
        }
      
        return isCompletlyHidden;
    }

    public bool HideRandomWords()
    {
        Random rnd = new Random();
        int index = rnd.Next(_words.Count);

        while (_words[index].IsHidden()) 
        {
            index = rnd.Next(_words.Count);
        }

        _words[index].Hide();

        return IsCompletlyHidden();
    }

}





