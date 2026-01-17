using UnityEngine;
using UnityEngine.SceneManagement;
public class tpdowntoplanet : MonoBehaviour
{
    public GameObject shopplanet;
    GameObject[] enemies;

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
            if (collision.gameObject.CompareTag("shopplanet") && Input.GetKey(KeyCode.E))
            {


                SceneManager.LoadScene(4);
            }
        }

    }
}
