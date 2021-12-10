using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;
    private static int currentScore;

    private delegate void CheckAchievementConditions();
    private CheckAchievementConditions checkAchievementConditions;

    public event Action<int> onScoreUpdated;
    public event Action<int> onAchievement;

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

    private void Awake()
    {
        checkAchievementConditions = CheckFirstPoint;
    }

    public void AddPoints(int amount)
    {
        currentScore += amount;
        checkAchievementConditions?.Invoke();
        onScoreUpdated?.Invoke(currentScore);
    }

    private void CheckFirstPoint()
    {
        if (currentScore >= 1)
        {
            onAchievement?.Invoke(0);
            checkAchievementConditions = CheckFiftyPoints;
        }
    }

    private void CheckFiftyPoints()
    {
        if (currentScore >= 50)
        {
            onAchievement?.Invoke(1);
            checkAchievementConditions = null;
        }
    }
}
