using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if (rb != null)
        {
            // Apply movement to the Rigidbody
            // .normalized ensures diagonal movement isn't faster
            rb.linearVelocity = new Vector2(moveX, moveY).normalized * moveSpeed;
        }
    }
}