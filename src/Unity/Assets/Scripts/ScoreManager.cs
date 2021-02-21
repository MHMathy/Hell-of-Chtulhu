using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public float timeElapsed = 0f;
    public TextMeshProUGUI textUI;
    public TextMeshProUGUI timeUI;
    public void IncreaseScore()
    {
        score += 100;
        textUI.text = "Score " + this.score;
    }

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        timeUI.text = Mathf.Round(timeElapsed).ToString();
    }
}
