using UnityEngine;


public class PlayerMovement1 : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0f;
        float y = 0f;

        if (Input.GetKey(KeyCode.W)) y += 1f;
        if (Input.GetKey(KeyCode.S)) y -= 1f;
        if (Input.GetKey(KeyCode.D)) x += 1f;
        if (Input.GetKey(KeyCode.A)) x -= 1f;

        Vector2 direction = new Vector2(x, y).normalized;
        rb.linearVelocity = direction * speed;

<<<<<<< Updated upstream
=======
        if (rb.position.x > sida)
        {
            rb.position = new Vector2(sida, transform.position.y);
        }
        if (rb.position.x < -sida)
        {
            rb.position = new Vector2(-sida, transform.position.y);
        }


        if (rb.position.y > uppner)
        {
            rb.position = new Vector2(transform.position.x, uppner);
        }
        if (rb.position.y < -uppner)
        {
            rb.position = new Vector2(transform.position.x, -uppner);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {

            rb.linearVelocity = direction * bspeed;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            rb.linearVelocity = direction * speed;
        }
        if (direction.y > 0)
        {
            animator.Play("front");
        }
        else if (direction.y < 0)
        {
            animator.Play("back");
        }
        else if (direction.x > 0)
        {
            animator.Play("right");
        }
        else if (direction.x < 0)
        {
            animator.Play("left");
        }
        else
        {
            animator.Play("neutral");
        }
        void OnCollisionEnter2D(Collision collision)
        {
            collision.gameObject
                .GetComponent<LarryBodySegment>()
                ?.TakeDamage();

        }


>>>>>>> Stashed changes
    }
}
