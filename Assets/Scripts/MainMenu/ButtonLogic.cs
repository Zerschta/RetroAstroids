using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonLogic : MonoBehaviour
{
    [SerializeField] private string MainScene = "GameScene";

    [SerializeField] private Button Play;
    [SerializeField] private Button Settings;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        startGame();
    }
    void startGame()
    {
        if (Play.IsPressed())
        {
            SceneManager.LoadScene(MainScene);
        }
    }
}
