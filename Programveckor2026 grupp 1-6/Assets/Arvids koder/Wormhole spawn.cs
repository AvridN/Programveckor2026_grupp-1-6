using UnityEngine;

public class Wormholespawn : MonoBehaviour
{
    GameObject[] enemies;
    public GameObject Wormhole;

    bool baraengång = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemy_movment");
        if (enemies.Length == 0)
        {
            if (baraengång == true)
            {


                Vector2 spawnlocation = new Vector2(-7f, 0f);
                Instantiate(Wormhole, spawnlocation, Quaternion.identity);
                baraengång = false;
            }
        }
    }
}
