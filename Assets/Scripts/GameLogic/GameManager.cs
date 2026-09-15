using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;

    public int highScore;
    [SerializeField] private bool ResetActive;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0); // 0 = Default, falls noch nichts gespeichert
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetHighscore();
        }
    }

    public void AddScore(int amount)
    {
        score += amount;

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }

    void ResetHighscore()
    {
        ResetActive = true;
        PlayerPrefs.SetInt("HighScore", 0);
        PlayerPrefs.Save();
    }
}

