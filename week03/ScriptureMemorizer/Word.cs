using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    //Show words if user request for a hint
    public void Show()
    {
        _isHidden = false;
    }

    // Returns the display text for the word, either the original text or underscores if hidden
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string underscores = "";
            foreach (char character in _text)
            {
                if (char.IsLetter(character))
                {
                    underscores += "_";
                }
                else
                {
                    underscores += character;
                }
            }
            return underscores;
        }

        return _text;
    }
}