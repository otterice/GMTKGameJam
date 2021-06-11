using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordDisplay : MonoBehaviour
{
    public TextAlignment text;

    public void SetWord(string word)
    {
        text.text = word;
    }
}
