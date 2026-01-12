using UnityEngine;

public class enemy_movment : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject speed;
    GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(0, 0);
        player = FindObjectOfType<PlayerMovement>().gameObject;

    }
    // skrip för splearens namn 


    // Update is called once per frame
    void Update()
    {
        Vector2 v = player.transform.position - transform.position;
        float angel = Vector2.SignedAngle(new Vector2(0, 1), v);
        transform.rotation = Quaternion.Euler(0, 0, angel);
        rb.linearVelocity = v;




    }
}


