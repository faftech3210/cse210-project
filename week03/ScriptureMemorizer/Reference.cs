public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructors
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse; // Handles a range of verses
    }

    // Method to return the reference as a string
    public string GetReferenceString()
    {
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}
