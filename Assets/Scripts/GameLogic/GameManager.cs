using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public int highScore;

    void Start()
    {
        // Beim Start den gespeicherten High Score laden
        highScore = PlayerPrefs.GetInt("HighScore", 0); // 0 = Default, falls noch nichts gespeichert
    }

    public void AddScore(int amount)
    {
        score += amount;

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save(); // optional, Unity speichert eh regelm‰ﬂig automatisch
        }
    }
}

