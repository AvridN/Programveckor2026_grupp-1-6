using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject player;
    public GameObject bulletPrefab;

    public float timeBetweenShots = 1f;
    public float bulletSpeed = 2f;

    private float timer = 0f;

    void Start()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player == null) return;

        Vector2 direction = (player.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle - 90);

        timer += Time.deltaTime;

        if (timer >= timeBetweenShots)
        {
            Shoot();
            timer = 0f;
        }
    }

    void Shoot()
    {
        Vector2 direction = (player.transform.position - transform.position).normalized;

        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = direction * bulletSpeed;

        Destroy(bullet, 4f);
    }
}
