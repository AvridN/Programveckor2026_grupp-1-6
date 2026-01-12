using UnityEngine;

public class wormholePlayerTP : MonoBehaviour
{
    bool top = false;
    bool botten = false;
    bool Right = false;
    bool left = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Övredörr") && Input.GetKeyDown(KeyCode.E))
        {

        }
    }
}
