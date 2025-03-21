using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Method to display the scripture
    public string GetScriptureText()
    {
        string wordsText = string.Join(" ", _words.Select(word => word.GetWord()));
        return $"{_reference.GetReferenceString()}\n{wordsText}";
    }

    // Method to hide random words
    public void HideRandomWords(int numberOfWordsToHide)
    {
        Random random = new Random();

        // Get visible words
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        for (int i = 0; i < numberOfWordsToHide && visibleWords.Count > 0; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex); // Avoid selecting the same word again
        }
    }

    // Method to check if all words are hidden
    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
