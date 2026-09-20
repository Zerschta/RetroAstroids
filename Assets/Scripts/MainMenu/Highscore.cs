using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Highscore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highScore;
    int HighScore;
    void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        highScore.text = "Highscore : " + HighScore;
    }
}
