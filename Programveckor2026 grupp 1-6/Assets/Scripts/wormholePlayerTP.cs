using UnityEngine;

public class wormholePlayerTP : MonoBehaviour
{

    public int rumsplacering = Random.Range(1, 7);



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
        if (collision.gameObject.CompareTag("Övredörr") && Input.GetKeyDown(KeyCode.E))
        {
            int rumplacering = Random.Range(1, 7);
            transform.position = new Vector2(0.09f, -4.69f);

        }
        if (collision.gameObject.CompareTag("Högradörr") && Input.GetKeyDown(KeyCode.E))
        {
            int rumsplacering = Random.Range(1, 7);
            transform.position = new Vector2(-8.33f, -0.02f);

        }
        if (collision.gameObject.CompareTag("Vänstradörr") && Input.GetKeyDown(KeyCode.E))
        {
            int rumsplacering = Random.Range(1, 7);
            transform.position = new Vector2(8.56f, -0.19f);

        }
        if (collision.gameObject.CompareTag("Nedredörr") && Input.GetKeyDown(KeyCode.E))
        {
            int rumsplacering = Random.Range(1, 7);
            transform.position = new Vector2(0.22f, 4.5f);

        }
    }
}
