using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public string mainSceneName = "MainScene";

    void Start()
    {

        Time.timeScale = 1f;
    }


    public void ShowGameOver()
    {

        Time.timeScale = 0f;
    }


    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainSceneName);
    }
}
