using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "AI/FSM/Decisions/DistanceDecision")]
public class DistanceDecision : Decision
{
    GameObject target; // player
    public string targetTag; // tag of player
    public float distThreshold = 1f; 
    public override bool Decide(BaseStateMachine stateMachine)
    {
        return false;
        if (target == null) target = GameObject.FindWithTag(targetTag);
        if (Vector3.Distance(stateMachine.transform.position, target.transform.position) >= distThreshold  == false) Debug.Log("back to patrol");
        return (Vector3.Distance(stateMachine.transform.position, target.transform.position) >= distThreshold);
    }
}
