using UnityEngine;

public class astroidhögkvarter : MonoBehaviour
{
    [SerializeField]
    public GameObject Astroid;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int placering = gameObject.GetComponent<wormholePlayerTP>().rumsplacering;
        if (placering == 1)
        {

        }
        if (placering == 2)
        {

        }
        if (placering == 3)
        {

        }
        if (placering == 4)
        {

        }
        if (placering == 5)
        {

        }
        if (placering == 6)
        {

        }
        if (placering == 7)
        {

        }
    }
}
