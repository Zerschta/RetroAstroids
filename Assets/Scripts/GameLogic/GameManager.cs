using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;

    public int highScore;
    [SerializeField] private bool ResetActive;
    private bool StopSave;
    void Start()
    {
        StopSave = false;
        highScore = PlayerPrefs.GetInt("HighScore", 0); // 0 = Default, falls noch nichts gespeichert
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetHighscore();
            StopSave = true;
        }
    }

    public void AddScore(int amount)
    {
        score += amount;

        if (score > highScore && StopSave == false)
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

