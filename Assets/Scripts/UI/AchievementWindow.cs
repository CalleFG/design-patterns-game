using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class AchievementWindow : MonoBehaviour
{
    [SerializeField] private Text achievementNameText;
    [SerializeField] private Text achievementFlavorText;
    [SerializeField] private float fadeTime = 4.0f;

    private void DisplayAchievement(Achievement achievement)
    {
        achievementNameText.text = achievement.achievementName;
        achievementFlavorText.text = achievement.flavorText;
        ShowWindow();
        StartCoroutine(HideWindowTimer());
    }
    
    private void ShowWindow()
    {
        gameObject.SetActive(true);
    }
    
    private void HideWindow()
    {
        gameObject.SetActive(false);
    }

    private IEnumerator HideWindowTimer()
    {
        yield return new WaitForSeconds(fadeTime);
        HideWindow();
    }
}
