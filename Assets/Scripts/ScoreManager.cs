using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;
    private static int points;
    
    public int Points => points;

    public static ScoreManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = new GameObject("Game Manager");
                instance = obj.AddComponent<ScoreManager>();
            }

            return instance;
        }
    }

    public void AddPoints(int amount)
    {
        points += amount;
    }
}
