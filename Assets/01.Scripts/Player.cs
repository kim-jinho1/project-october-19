using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field:SerializeField] public InputReader inputReader { get; private set; }
    
    public CharacterController CharacterController  { get; private set; }


    [SerializeField] private State currentState,previousState;
    [SerializeField] private State startState;
    
    
    [Header("State")]
    public string StateName="";
    private void Awake()
    {
        CharacterController = GetComponent<CharacterController>();
        State[] states = GetComponentsInChildren<State>();
        foreach (State state in states)
            state.InitializeState(this);
    }

    private void Start()
    {
        TransitionState(startState);
    }
    

    private void Update()
    {
        currentState.StateUptate();
    }

    private void FixedUpdate()
    {
        currentState.StateFixedUpdate();
    }

    internal void TransitionState(State state)
    {
        if (state == null) return;

        if (currentState != null)
        {
            currentState.Exit();
        }

        previousState = currentState;
        currentState = state;
        currentState.Enter();

        DisplayState();
    }

    private void DisplayState()
    {
        if (previousState == null || previousState.GetType() != currentState.GetType())
        {
            StateName = currentState.GetType().ToString();
        }
    }
}
