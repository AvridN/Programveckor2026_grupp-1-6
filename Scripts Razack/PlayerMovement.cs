using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int lives = 3;
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private bool canTakeDamage = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        rb.linearVelocity = new Vector2(moveX, moveY).normalized * moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!canTakeDamage) return;

        if (other.CompareTag("Bullet"))
        {
            lives--;
            Debug.Log("Lives: " + lives);

            if (lives <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                StartCoroutine(DamageCooldown());
            }
        }
    }

    System.Collections.IEnumerator DamageCooldown()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(0.5f);
        canTakeDamage = true;
    }
}
