using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonLogic : MonoBehaviour
{
    [SerializeField] private string MainScene = "GameScene";

    [SerializeField] private Button Play;
    [SerializeField] private Button Settings;
    [SerializeField] private Button BackToMenu;
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject SettingsMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MainMenu.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        startGame();
        if (Settings.IsPressed())
        {
            MainMenu.SetActive(false);
            SettingsMenu.SetActive(true);
        }
        else if (BackToMenu.IsPressed())
        {
            MainMenu.SetActive(true);
            SettingsMenu.SetActive(false);
        }
    }
    void startGame()
    {
        if (Play.IsPressed())
        {
            SceneManager.LoadScene(MainScene);
        }
    }
}
