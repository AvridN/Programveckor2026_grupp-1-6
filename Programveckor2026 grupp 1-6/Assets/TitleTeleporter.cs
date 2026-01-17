using UnityEngine;
using UnityEngine.SceneManagement;
public class TitleTeleporter : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(0);
    }
}