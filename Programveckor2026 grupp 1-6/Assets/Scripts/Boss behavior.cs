using UnityEngine;

public class Bossbehavior : MonoBehaviour
{

    public GameObject Radius;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        bool detection = Radius.GetComponent<bossradius>();
    }
}
