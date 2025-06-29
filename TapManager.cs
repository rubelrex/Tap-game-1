
using UnityEngine;
using UnityEngine.UI;

public class TapManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    public void OnTap()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
