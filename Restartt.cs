using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // public GameObject gameOverPanel;
    public string mainSceneName = "MainScene";

    void Start()
    {
        //gameOverPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    // Kallas när spelaren dör
    public void ShowGameOver()
    {
        //gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    // Kallas av Restart-knappen
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainSceneName);
    }
}
