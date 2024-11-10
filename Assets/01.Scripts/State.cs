using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public abstract class State : MonoBehaviour
{
    protected Player _agent;
    public UnityEvent OnEnter, OnExit;


    public void InitializeState(Player agent)
    {
        _agent = agent;
    }

    public void Exit()
    {
        _agent.InputReader.OnMove -= Move;
        OnExit?.Invoke();
        ExitState();
    }

    protected virtual void ExitState()
    {
        
    }

    public void Enter()
    {
        _agent.InputReader.OnKey +=EndScene;
        _agent.InputReader.OnMove += Move;
        OnEnter?.Invoke();
        EnterState();
    }

    protected virtual void EndScene()
    {
        _agent.GameManager.EndScene();
    }
    
    protected virtual void EnterState()
    {
        
    }

    protected virtual void Move(Vector3 obj)
    {
        
    }

    public virtual void StateUptate()
    {
        
    }

    public virtual void StateFixedUpdate()
    {
        
    }
}
