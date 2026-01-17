using UnityEngine;

public class johnslemkod2 : MonoBehaviour
{
    bool johngången = true;
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {



        if (johngången == true)
        {
            animator.Play("shop_intro");
            johngången = false;
        }
        else if (johngången == false)
        {
            animator.Play("talking");
        }
    }
}
