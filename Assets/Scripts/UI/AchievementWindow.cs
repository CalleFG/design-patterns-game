using System.Collections;
using UnityEngine;
using TMPro;

public class AchievementWindow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI achievementNameText;
    [SerializeField] private TextMeshProUGUI achievementDescriptionText;
    [SerializeField] private float fadeTime = 4.0f;

    public void DisplayAchievement(Achievement achievement)
    {
        achievementNameText.text = achievement.name;
        achievementDescriptionText.text = achievement.description;
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
