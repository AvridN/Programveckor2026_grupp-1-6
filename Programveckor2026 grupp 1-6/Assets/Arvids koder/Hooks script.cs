using UnityEngine;

public class Hooksscript : MonoBehaviour
{

    Rigidbody2D rb;
    public GameObject Player;

    public float hookspeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    int engångs = 0;
    // Update is called once per frame
    void Update()
    {
        if (engångs == 0)
        {



            transform.position = Player.transform.position;




            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                engångs++;
                rb.linearVelocityX = 0;
                rb.linearVelocityY = hookspeed;

            }


            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                engångs++;
                rb.linearVelocityX = 0;
                rb.linearVelocityY = -hookspeed;

            }


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                engångs++;
                rb.linearVelocityX = hookspeed;
                rb.linearVelocityY = 0;

            }


            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                engångs++;
                rb.linearVelocityX = -hookspeed;
                rb.linearVelocityY = 0;

            }


        }

    }
}
