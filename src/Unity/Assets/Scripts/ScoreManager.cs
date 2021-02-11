using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshPro textUI;
    public void IncreaseScore()
    {
        score += 100;
        textUI.text = "Score " + this.score;
    }
}
