using UnityEngine;

public class hurt_enemy_any : MonoBehaviour
{
    int Hp;
    public int maxhp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hp = maxhp;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Hoock"))  // ska ändras till fiender script
        {
            Hp--;
        }
        if (Hp == 0)
        {
            Destroy(gameObject);

        }
    }




}
