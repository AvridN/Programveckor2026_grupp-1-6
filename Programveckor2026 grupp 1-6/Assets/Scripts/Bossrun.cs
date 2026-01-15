using UnityEngine;

public class Bossrun : StateMachineBehaviour
{
    public float speed = 2.5f;
    public float attackrange = 3f;

    Transform Player;
    Rigidbody2D rb;
    boss boss;

    override public void OnStateEneter(Animator animator, AnimatorStateInfo stateinfo, int layerindex)
    {
        Player = GameObject.CompareTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        boss = animator.GetComponent<boss>();
    }


    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        boss.lookatplayer();

        Vector2 target = new Vector2(Player.position.x, Player.position.y);
        Vector2.MoveTowards(rb.position, target, Time.fixedDeltaTime * speed);
        rb.MovePosition(newPos);

        if (Vector2.Distance(Player.position, rb.position) <= attackrange)
        {
            animator.SetTrigger("Attack");
        }
    }


    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
    }
}

