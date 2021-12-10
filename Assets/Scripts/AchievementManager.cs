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

    private void Awake()
    {
        // Would've liked to use an external .css/.json file to fill out achievements.
        // However I don't know how to do that in unity.
        availableAchievements = new Achievement[2];
        availableAchievements[0] = new Achievement
        {
            name = "Earned one point.",
            description = "You just earned your first point."
        };
        availableAchievements[1] = new Achievement
        {
            name = "Fifty points!",
            description = "You have earned fifty points."
        };

        ScoreManager.Instance.onAchievement += ShowAchievementMessage;
    }

    private void ShowAchievementMessage(int achievementID)
    {
        achievementWindow.DisplayAchievement(availableAchievements[achievementID]);
    }
}
