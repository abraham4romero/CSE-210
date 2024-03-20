using System;

class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _lastverse;

    public Reference(string book, string chapter, string verse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastverse = "0";
    }
    public Reference(string book, string chapter, string verse, string lastverse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastverse = lastverse;
    }

    public string GetReference() {
        if (_lastverse == "0") {
            return $"{_book} {_chapter}:{_verse}";
        } else {
            return $"{_book} {_chapter}:{_verse}-{_lastverse}";
        }
    }   
}