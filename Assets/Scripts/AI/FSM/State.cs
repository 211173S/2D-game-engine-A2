using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/FSM/State")]
public sealed class State : BaseState
{
    public List<Activity> Activities = new List<Activity>(); // activities are things that happen in a state
    public List<Transition> Transitions = new List<Transition>(); // transition are conditions that need to be met to change state
    public override void Enter(BaseStateMachine machine)
    {
        foreach (var activity in Activities)
            activity.Enter(machine);
    }

    public override void Execute(BaseStateMachine machine)
    {
        foreach (var activity in Activities)
            activity.Execute(machine);
        foreach (var transition in Transitions)
            transition.Execute(machine);
    }

    public override void Exit(BaseStateMachine machine)
    {
        foreach (var activity in Activities)
            activity.Exit(machine);
    }
}
