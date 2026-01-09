using UnityEngine;

public class Hookattack : MonoBehaviour
{
    public GameObject Hook;
    Rigidbody2D rb;
    float speed = 1f;
    void Start()
    {


    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(0, -speed);
        }
    }
}
