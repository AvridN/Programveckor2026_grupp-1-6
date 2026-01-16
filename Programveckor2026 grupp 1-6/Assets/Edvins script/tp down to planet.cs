using UnityEngine;
using UnityEngine.SceneManagement;
public class tpdowntoplanet : MonoBehaviour
{
    public GameObject shopplanet;
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
        if (engångbara == true)
        {
            if (enemies.Length == 0)
            {
                Vector2 spawnlocation = new Vector2(6f, 0f);
                Instantiate(shopplanet, spawnlocation, Quaternion.identity);
                engångbara = false;


            }
        }

        if (collision.gameObject.CompareTag("shopplanet") && Input.GetKey(KeyCode.E))
        {


            SceneManager.LoadScene(4);
        }
    }
}
