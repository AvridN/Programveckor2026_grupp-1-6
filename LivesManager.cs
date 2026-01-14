using TMPro;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    public PlayerMovement player;
    public TextMeshProUGUI livesText;
    public float timer = 0;
    public bool isGameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + player.lives;

        timer += Time.deltaTime;
    }
}
