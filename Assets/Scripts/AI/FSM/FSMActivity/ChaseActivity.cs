using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "AI/FSM/Activity/ChaseActivity")]
public class ChaseActivity : Activity
{
    GameObject target; // target to chase ; player
    public string targetTag; // tag of thing we chase ; player
    [SerializeField] private float speed = 1f;
    public override void Enter(BaseStateMachine stateMachine)
    {
        target = GameObject.FindWithTag(targetTag);
        stateMachine.GetComponent<Animator>().SetBool("isRunning", true);
        Debug.Log("chase state");
    }

    public override void Execute(BaseStateMachine stateMachine)
    {
        var RigidBody = stateMachine.GetComponent<Rigidbody2D>();
        var SpriteRenderer = stateMachine.GetComponent<SpriteRenderer>();

        Vector2 dir = (target.transform.position - stateMachine.transform.position).normalized;
        RigidBody.velocity = new Vector2(dir.x * speed /** Time.deltaTime*/, RigidBody.velocity.y  * speed/* * Time.deltaTime*/);
        SpriteRenderer.flipX = (dir.x > 0) ? true : false;
    }

    public override void Exit(BaseStateMachine stateMachine)
    {
        Debug.Log("exited chase activity");
    }
}
