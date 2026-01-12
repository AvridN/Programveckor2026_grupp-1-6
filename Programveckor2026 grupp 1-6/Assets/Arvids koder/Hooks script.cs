using UnityEngine;

public class Hooksscript : MonoBehaviour
{

    Rigidbody2D rb;
    public Transform Player;


    public float hookspeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }
    int engångs = 0;

    float hookrange = 4;
    int timersak = 0;


    // Update is called once per frame
    void Update()
    {






        if (engångs == 0)
        {


            rb.MovePosition(Player.position);



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

        if (engångs > 0)
        {
            // uppåt
            if (rb.position.y > Player.position.y + hookrange)
            {
                // rb.MovePosition(new Vector2(Player.position.x, Player.position.y - hookrange));
                rb.MovePosition(Player.position);
                engångs = 0;
            }


            // nedåt
            if (rb.position.y < Player.position.y - hookrange)
            {
                // rb.MovePosition(new Vector2(Player.position.x, Player.position.y + hookrange));
                rb.MovePosition(Player.position);
                engångs = 0;
            }


            // högeråt
            if (rb.position.x > Player.position.x + hookrange)
            {
                // rb.MovePosition(new Vector2(Player.position.x + hookrange, Player.position.y));


                rb.MovePosition(Player.position);
                engångs = 0;

            }

            //vänsteråt

            if (rb.position.x < Player.position.x - hookrange)
            {
                // rb.MovePosition(new Vector2(Player.position.x - hookrange, Player.position.y));
                rb.MovePosition(Player.position);
                engångs = 0;
            }


        }



    }
}
