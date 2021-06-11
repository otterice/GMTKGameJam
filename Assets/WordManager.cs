using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> wordList;

    private bool hasActiveWord;
    private Word activeWord;

    public void Start()
    {
        AddWord();
        AddWord();
        AddWord();
    }


    public void AddWord()
    {
        Word word = new Word(WordGenerator.getRandomWord());
        Debug.Log(word.word);

        wordList.Add(word);
    }


    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.getNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach (Word word in wordList)
            {
                if (word.getNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                    //break to only set one word as active at a time
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            wordList.Remove(activeWord);
        }
    }
}
