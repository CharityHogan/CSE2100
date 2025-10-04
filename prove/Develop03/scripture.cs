using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    private List<words> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new words(word));
        }

        Public void HideRandomWords(int numberToHide, Random random)
        {
            int availableWords = _words.Count(w => !w.IsHidden());
            numberToHide = Math.Min(numberToHide, availableWords);

            int count = 0;
            while (count < numberToHide)
            {
                int index = random.Next(_words.Count);
                if (!_words[index].IsHidden())
                {
                    _words[index].Hide();
                    count++;
                }
            }
        }

        Public string GetDisplayText()
        {
            List<string> displayWords = new List<string>();
            foreach (words word in _words)
            {
                displayWords.Add(word.GetDisplayText());
            }
            return _reference.GetDisplayText() + " - " + string.Join("", displayWords);

        }
        Public bool IsCompletelyHidden()
        {
            foreach (words word in _words)
            {
                if (!word.IsHidden())
                    return false;
            }
            return true;
        }
    }
}