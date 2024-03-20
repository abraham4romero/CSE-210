using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Passage
{
    public List<Word> _passageList = new List<Word>();

    public int unhiddenWords;

    private bool allWords = false;

    public Passage(string passage) {
        string[] _wordList = passage.Split(" ");
        for (int thisWord = 0; thisWord < _wordList.Length; thisWord++) {
            Word w1 = new Word(_wordList[thisWord]);
            _passageList.Add(w1);
        }
        unhiddenWords = _passageList.Count();
    }

    public void HideWord() {
        Random r = new Random();
        if(unhiddenWords != 0) {
            if(unhiddenWords > 3) {
                for (int count = 0; count < 3; count++) {
                    int num = r.Next(_passageList.Count());
                    Word word = _passageList[num];
                    if (word._hidden == false) {
                        word.HideWord();
                    } else {
                        count -= 1;
                    }
                }
                UpdateUnhiddenWords();
            } else {
                for (int count = 0; count < 1; count++) {
                    int num = r.Next(_passageList.Count());
                    Word word = _passageList[num];
                    if (word._hidden == false) {
                        word.HideWord();
                    } else {
                        count -= 1;
                    }
                }
                UpdateUnhiddenWords();
            }
        } else {
            allWords = true;
        }
    }

    public string GetPassage() {
        string passage = "";
        for (int x = 0; x < _passageList.Count(); x++) {
            passage = passage + _passageList[x].GetWord() + " ";
        }
        return passage;
    }

    public bool GetState() {
        return allWords;
    }

    private void UpdateUnhiddenWords() {
        unhiddenWords = 0;
        for (int x = 0; x < _passageList.Count(); x++) {
            if (_passageList[x]._hidden == false) {
                unhiddenWords++;
            }
        }
    }
}