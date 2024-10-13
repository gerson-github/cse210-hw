using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {

        Random random = new Random();
        var hiddenWords = _words.Where(w => !w.IsHidden())  // filter data
                                .OrderBy(w => random.Next()) // shuffle
                                .Take(numberToHide) // get a number
                                .ToList(); // outcome is a list

        foreach(var word in hiddenWords)                                
        {
            word.Hide();
        }

    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string words = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{reference}: {words}";
    }

    public bool IsCompletelyHidden()
    {
       // return _words.All(w => w.IsHidden());

        bool allWordHidden = true;

        foreach(var word in _words)
        {
            if (!word.IsHidden())
            {
                allWordHidden = false;
                break;
            }
        }
        return allWordHidden;
    }

}