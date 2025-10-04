public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int vesre)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = vesre;
        _endVerse = vesre;
    }
}