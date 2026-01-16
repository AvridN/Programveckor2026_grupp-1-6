using UnityEngine;
using UnityEngine.SceneManagement;
public class tpdowntoplanet : MonoBehaviour
{
    GameObject[] enemies;
    bool engångbara = true;
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
        enemies = GameObject.FindGameObjectsWithTag("enemy_movment");
        if (enemies.Length == 0)
        {
            if (collision.gameObject.CompareTag("Player") && Input.GetKey(KeyCode.E))
            {
                Vector2 spawnlocation = new Vector2(-6f, 0f);
                Instantiate(spawnlocation, Quaternion.identity);
                engångbara = false;
                SceneManager.LoadScene(4);
            }
        }
    }
}
