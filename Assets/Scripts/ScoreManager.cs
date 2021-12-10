using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;
    private static int currentScore;

    public event Action<int> onScoreUpdated;

    public static ScoreManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = new GameObject("Score Manager");
                instance = obj.AddComponent<ScoreManager>();
            }

            return instance;
        }
    }

    public void AddPoints(int amount)
    {
        currentScore += amount;
        onScoreUpdated?.Invoke(currentScore);
    }
}
