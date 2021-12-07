using System.Collections.Generic;
using UnityEngine;

public struct Achievement
{
    public string achievementName;
    public string flavorText;
}

public class AchievementManager : MonoBehaviour
{
    public List<Achievement> achievements;
    private Achievement[] availableAchievements;

    private void ShowAchievementMessage()
    {
        
    }
}
