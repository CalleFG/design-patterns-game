using System.Collections;
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

    public List<Achievement> achievements;
    private Achievement[] availableAchievements;

    private Achievement testAchi;

    private IEnumerator TestTimer()
    {
        yield return new WaitForSeconds(3.0f);
        ShowAchievementMessage();
    }

    private void Awake()
    {
        testAchi = new Achievement();
        testAchi.name = "Test Achievement";
        testAchi.description = "Cool test description.";

        StartCoroutine(TestTimer());
    }

    private void ShowAchievementMessage()
    {
        achievementWindow.DisplayAchievement(testAchi);
    }
}
