using UnityEngine;

public class räkna_enemys_för_portal : MonoBehaviour
{
    GameObject[] enemies;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemy_movment");
        if (enemies == null) { }
    }

}
