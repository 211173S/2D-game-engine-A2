using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStateMachine : MonoBehaviour
{
    [SerializeField] private BaseState _initialState;
    [SerializeField] public BaseState CurrentState { get; set; }
    private void Awake()
    {
        CurrentState = _initialState; // the state we pass in is the current state
    }
    // Start is called before the first frame update
    void Start()
    {
        CurrentState.Enter(this);
    }
    // Update is called once per frame
    void Update()
    {
        CurrentState.Execute(this);
    }
}
