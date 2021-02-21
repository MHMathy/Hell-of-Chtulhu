using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    float secElapsed = 0f;
    float minElapsed = 0f;
    public TextMeshProUGUI textUI;
    public TextMeshProUGUI timeUI;
    public void IncreaseScore()
    {
        score += 100;
        textUI.text = "Score " + this.score;
    }

    private void Update()
    {
        secElapsed += Time.deltaTime;
<<<<<<< HEAD
        if(secElapsed >= 59)
=======
        if (secElapsed >= 59)
>>>>>>> e7d8db80a646fca2c0dd37e9183415e9e02f11f3
        {
            minElapsed += 1f;
            secElapsed = 0f;
        }
        timeUI.text = Mathf.Round(minElapsed).ToString("00") + ":" + Mathf.Round(secElapsed).ToString("00"); ;
    }
}