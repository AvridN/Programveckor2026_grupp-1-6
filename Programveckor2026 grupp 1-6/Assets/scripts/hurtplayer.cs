using UnityEngine;
using UnityEngine.SceneManagement;

public class hurtplayer : MonoBehaviour
{
    public object collision;
    int hurtamount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("enemy_movment"))  // ska ändras till fiender script
        {
            hurtamount++;


        }
        if (hurtamount == 3)
        {
            SceneManager.LoadScene(1);

        }
    }
}
