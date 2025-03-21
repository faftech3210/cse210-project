public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Initially visible
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to display the word (hidden or visible)
    public string GetWord()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
