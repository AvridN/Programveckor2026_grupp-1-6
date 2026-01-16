using System.Collections;
using UnityEngine;

public class LarryBodySegment : MonoBehaviour
{
    public int damageToPlayer = 1;
    public float flashDuration = 0.1f;

    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    private bool isFlashing = false;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject
                .GetComponent<PlayerMovement1>()
                .TakeDamage(damageToPlayer);
        }
    }

    // Anropas när segmentet tar skada
    public void TakeDamage()
    {
        if (!isFlashing)
        {
            StartCoroutine(FlashRed());
        }
    }

    IEnumerator FlashRed()
    {
        isFlashing = true;
        spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(flashDuration);

        spriteRenderer.color = originalColor;
        isFlashing = false;
    }
}

