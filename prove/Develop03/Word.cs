using System;

class Word
{
    private string _word = "";
    public bool _hidden = false;

    public Word(string word) {
        _word = word;
    }
    public void HideWord() {
        int _wordCount = _word.Count();
        _word = "";
        for (int x = 0; x < _wordCount; x++) {
            _word = _word + "_";
        }
        _hidden = true;
    }

    public string GetWord() {
        return _word;
    }
}