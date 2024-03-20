using System;

class Scripture
{
    private Reference _reference;
    private Passage _passage;
    public Scripture(string book, string chapter, string verse, string passage) {
        _reference = new Reference(book, chapter, verse);
        _passage = new Passage(passage);
    }

    public Scripture(string book, string chapter, string verse, string lastVerse, string passage) {
        _reference = new Reference(book, chapter, verse, lastVerse);
        _passage = new Passage(passage);
    }
    
    public void HideWord() {
        _passage.HideWord();
    }

    public string GetScripture() {
        string refere = _reference.GetReference();
        string pass = _passage.GetPassage();

        return $"{refere}\n\"{pass}\"";
    }

    public bool GetState() {
        return _passage.GetState();
    }
}