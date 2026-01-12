using UnityEngine;

public class BulletScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Spelaren träffad!");
            Destroy(collision.gameObject); // Dödar spelaren
        }

        Destroy(gameObject); // Bullet förstörs alltid vid kollision
    }
}