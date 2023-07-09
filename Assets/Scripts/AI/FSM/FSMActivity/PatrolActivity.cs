using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "AI/FSM/Activity/PatrolActivity")]
public class PatrolActivity : Activity
{
    [SerializeField] private float speed; // speed of enemy patrolling 

    public override void Enter(BaseStateMachine stateMachine)
    {
        var PatrolPoints = stateMachine.GetComponent<PatrolPoints>();
        var SpriteRenderer = stateMachine.GetComponent<SpriteRenderer>();
        var Animator = stateMachine.GetComponent<Animator>();
        //if (PatrolPoints.EnemyArrived()) SpriteRenderer.flipX = true; 
        //SpriteRenderer.flipX = (PatrolPoints.GetTargetPointDir().x > 0) ? false : true;
        Animator.SetBool("isRunning", true);
        Debug.Log("entered patrol activity");
    }

    public override void Execute(BaseStateMachine stateMachine)
    {
        var PatrolPoints = stateMachine.GetComponent<PatrolPoints>();
        var RigidBody = stateMachine.GetComponent<Rigidbody2D>();
        float x = PatrolPoints.GetTargetPointDir().x;
        float y = PatrolPoints.GetTargetPointDir().y;

        /*
         * 
        Vector2 pos = RigidBody.position + new Vector2(x * speed * Time.deltaTime, y * speed * Time.deltaTime );
        RigidBody.MovePosition(pos);
         */
        Vector2 pos = stateMachine.gameObject.transform.position +
                      new Vector3(x * speed * Time.deltaTime, y * speed * Time.deltaTime);
        stateMachine.gameObject.transform.position = pos;
    }

    public override void Exit(BaseStateMachine stateMachine)
    {
        var PatrolPoints = stateMachine.GetComponent<PatrolPoints>();
        PatrolPoints.SetNextTargetPoint();
        Debug.Log("exited patrol activity");
    }
}
