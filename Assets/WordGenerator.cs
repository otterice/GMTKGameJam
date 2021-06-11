using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "eclipse", "branded", "quest",
                                        "armor", "knight", "skull", "zodd",
                                        "dreams", "princess", "iron", "dragon",
                                        "causality", "puck", "fantasy", "guts",
                                        "witch", "death", "king", "golden age",
                                        "swordsman", "millennium empire",
                                        "conviction", "falcon", "destiny"



                                };

    public static string getRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];
        return randomWord;
    }

}
