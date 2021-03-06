using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    string mapName = "Map";
    int highScore = 0;

    public string MapName
    {
        get
        {
            return mapName;
        }

        set
        {
            mapName = value;
        }
    }

    public int HighScore
    {
        get
        {
            return highScore;
        }

        set
        {
            highScore = value;
        }
    }

    void updateHighScore(int score)
    {
        highScore = score;
    }
}
