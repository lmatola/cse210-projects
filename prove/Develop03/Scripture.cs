using System;
using System.Text;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;  
    private List<Word> _words = new List<Word>();
    
    public Scripture(Reference reference, string text)
    {       
        string[]words = text.Split(" ");
        _references = references;

        foreach (string sWord in words) 
        {
            Word word = new Word(sWord);
            _words.Add(word);
        }      

    }


    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_words.Count);

        while (_words[index].IsHidden()) {
            index = randomGenerator.Next(_words.Count);
        }
        _words[index].HideWord();
        return IsCompletlyHidden();
       
    }


    public string GetDisplayText()   //string
    {        
        _references.DisplayText();

        foreach (Word word in _words){
            word.DisplayWord();
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
}





