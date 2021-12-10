using System.Collections.Generic;
using UnityEngine;

public struct Achievement
{
    public string name;
    public string description;
}

public class AchievementManager : MonoBehaviour
{
    [SerializeField] private AchievementWindow achievementWindow;

    private Achievement[] availableAchievements;

    private Achievement testAchi;

    private void Awake()
    {
        testAchi = new Achievement
        {
            name = "Test Achievement",
            description = "Cool test description."
        };
    }

    private void ShowAchievementMessage()
    {
        achievementWindow.DisplayAchievement(testAchi);
    }
}
