using UnityEngine;

public class johnslemkod : MonoBehaviour
{
    Animator animator;
    bool johnengång = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (johnengång == true)
        {
            animator.Play("shop_intro");
            johnengång = false;
        }
        else
        {

            animator.Play("talking");
        }
    }
}
