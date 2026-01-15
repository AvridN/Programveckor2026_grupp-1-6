using UnityEngine;
using UnityEngine.SceneManagement;
public class hurt_enemy1 : MonoBehaviour
{
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

        if (collision.gameObject.CompareTag("Hoock"))
            Destroy(gameObject);
        { SceneManager.LoadScene(4); }
    }
}








