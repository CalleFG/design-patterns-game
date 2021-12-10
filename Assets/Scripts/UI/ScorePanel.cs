using TMPro;
using UnityEngine;

public class ScorePanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        ScoreManager.Instance.onScoreUpdated += OnScoreUpdated;
    }

    private void OnScoreUpdated(int score)
    {
        scoreText.text = score.ToString();
    }
}
