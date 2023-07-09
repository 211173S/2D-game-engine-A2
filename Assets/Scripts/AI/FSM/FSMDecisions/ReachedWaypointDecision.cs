using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "AI/FSM/Decisions/ReachedWaypointDecision")]
public class ReachedWaypointDecision : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        if ((stateMachine.GetComponent<PatrolPoints>().EnemyArrived()) == true) Debug.Log("enemy has arrived");
        return (stateMachine.GetComponent<PatrolPoints>().EnemyArrived()) ? true : false; 
    }
}
