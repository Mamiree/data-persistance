using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System.Xml.Serialization;


public class HighScores : MonoBehaviour
{

    
List<HighScoreEntry> scores = new List<HighScoreEntry>();
    void Start()
    {
        // Adds some test data
        AddNewScore("John", 4500);
        AddNewScore("Max", 5520);
        AddNewScore("Dave", 380);
        AddNewScore("Steve", 6654);
        AddNewScore("Mike", 11021);
        AddNewScore("Teddy", 3252);
        
    }

    void AddNewScore(string entryName, int entryScore)
    {
        scores.Add(new HighScoreEntry { name = entryName, score = entryScore });
    }
public class HighScoreEntry
{
    public string name;
    public int score;
}
}