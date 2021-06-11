using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    private int wordIndex;

    WordDisplay display;

    //constructor 
    public Word(string _word, WordDisplay _display)
    {

        word = _word;
        display = _display;
        wordIndex = 0;
        display.SetWord(word);
    }

    public char getNextLetter()
    {
        return word[wordIndex];
    }

    public void TypeLetter()
    {
        wordIndex++;
    }

    public bool WordTyped()
    {
        bool wordTyped = (wordIndex >= word.Length);

        if (wordTyped)
        {
            //remove word on screen
        }

        return wordTyped;
    }
}
