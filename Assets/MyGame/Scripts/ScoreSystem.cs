using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public Button button;
    public Text scoreText;
    public int maxScore = 10;
    public Text messageText;

    private int score;

    private void Start()
    {
        button.onClick.AddListener(IncrementScore);
    }

    private void IncrementScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();

        if (score >= maxScore)
        {
            messageText.text = "Du hast gewonnen!";
            button.interactable = false;
        }
    }
}
