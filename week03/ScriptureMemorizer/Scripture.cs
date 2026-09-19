using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    // Constructor that takes a Reference object and the scripture text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] wordArray = text.Split(' ');

        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Returns the display text for the scripture, including the reference and the words
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();
    }

    // Hides a specified number of random words in the scripture
    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int randomIndex = _random.Next(_words.Count);

            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
        }
    }

    // Checks if all words in the scripture are hidden
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

    //If user request for a hint
    public void ShowHint()
    {
        List<Word> hiddenWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenWords.Add(word);
            }
        }

        if (hiddenWords.Count > 0)
        {
            Random random = new Random();
            int randomIndex = random.Next(hiddenWords.Count);

            hiddenWords[randomIndex].Show();
        }
    }

}