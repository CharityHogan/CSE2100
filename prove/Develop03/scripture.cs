using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide, Random random)
    {
        int count = 0;
        int attempts = 0;
        int maxAttempts = _words.Count * 10;
        
        while (count < numberToHide && attempts < maxAttempts)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
            attempts++;
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + " ";
        
        for (int i = 0; i < _words.Count; i++)
        {
            display += _words[i].GetDisplayText();
            if (i < _words.Count - 1)
            {
                display += " ";
            }
        }
        
        return display;
    }
}