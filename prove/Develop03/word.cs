using System;
using System.Collections.Generic;
 

public class Word
{
    
    private bool _isHidden;
    private string _text;

    // Constructor that sets the text and the isHidden  bool. 
    public Word(string text)
    {
        _text = text;
        _isHidden  = false;
    }

    // Method sets the isHidden variable to true
    public void SetIsHidden(bool input)
    {
        _isHidden = true;
    }

      // Method returns the boolean _hidden variable.
    public bool GetIsHidden()
    {
        
        return _isHidden;
    }

    // Method that replaces the random word with an underscore
    public void DisplayWord()
    {
        if(_isHidden == true)
        {
            foreach (char letter in _text)
            {
                Console.Write("_");
            }
        }
        else
            Console.Write(_text);

    }



}
 


 
