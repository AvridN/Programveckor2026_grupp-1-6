using UnityEngine;

public class wormholePlayerTP : MonoBehaviour
{

    int rumsplacering = Random.Range(1, 7);



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        // if (collision.gameObject.CompareTag("enemy_movment"))
        {
            if (collision.gameObject.CompareTag("Övredörr"))
            {
                int rumsplacering = Random.Range(1, 7);
                transform.position = new Vector2(0, 0);

            }
            if (collision.gameObject.CompareTag("Högradörr"))
            {
                int rumsplacering = Random.Range(1, 7);
                transform.position = new Vector2(0, 0);

            }
            if (collision.gameObject.CompareTag("Vänstradörr"))
            {
                int rumsplacering = Random.Range(1, 7);
                transform.position = new Vector2(0, 0);

            }
            if (collision.gameObject.CompareTag("Nedredörr"))
            {
                transform.position = new Vector2(0, 0);
                int rumsplacering = Random.Range(1, 7);

            }
        }
    }
}
