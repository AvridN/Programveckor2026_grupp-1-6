using UnityEngine;

public class boss : MonoBehaviour
{
    public Transform player;

    public bool isflipped = false;

    public void lookatplayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;


        if (transform.position.x > player.position.x && isflipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isflipped = false;
        }
        else if (transform.position.x < player.position.x && !isflipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isflipped = true;
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
