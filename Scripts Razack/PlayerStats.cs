using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float speed = 5f;
    public int speedLevel = 1;

    public void UpgradeSpeed()
    {
        speed += 1f;
        speedLevel++;

        Debug.Log("Speed upgraded Level: " + speedLevel + " Speed: " + speed);

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
