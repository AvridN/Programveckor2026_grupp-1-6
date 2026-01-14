using UnityEngine;
using UnityEngine.SceneManagement;

public class wormholePlayerTP : MonoBehaviour
{





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
        if (collision.gameObject.CompareTag("dörr3"))
        {


        }

        if (collision.gameObject.CompareTag("dörr2"))
        {
            SceneManager.LoadScene(2);

        }


        if (collision.gameObject.CompareTag("dörr1"))
        {
            SceneManager.LoadScene(1);

        }

    }
}

