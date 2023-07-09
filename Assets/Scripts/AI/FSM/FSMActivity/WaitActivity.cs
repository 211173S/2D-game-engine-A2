using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "AI/FSM/Activity/WaitActivity")]
public class WaitActivity : Activity
{
    public override void Enter(BaseStateMachine stateMachine)
    {
        // things that will happen when state is entered (may be initialization)
        stateMachine.GetComponent<Rigidbody2D>().velocity = Vector2.zero; // set enemy to not move at all
        stateMachine.GetComponent<Animator>().SetBool("isRunning", false);
    }

    public override void Execute(BaseStateMachine stateMachine)
    {
      
    }

    public override void Exit(BaseStateMachine stateMachine)
    {
    
    }
}
