using System;
using System.Text;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;  
    private List<Word> _words;
    
    public Scripture(Reference reference, string text)
    {      
        _reference = reference;        
                 
    }


    public void HideRandomWords(int numberToHide)
    {
       
    }


    public string GetDisplayText()   //string
    {
        
        return "";
    }

    public bool IsCompletlyHidden()  //bool
    {
       return true;
    }
}





