using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : State
{
   [SerializeField] private MoveData moveData;
   
   public State idleState;

   private void Awake()
   {
      moveData = GetComponentInParent<MoveData>();
      PlayerMove();
   }

   protected override void EnterState()
   {
      base.EnterState();
      Debug.Log("Move State Entered");
   }

   protected override void ExitState() 
   {
      base.ExitState();
   }

   protected override void Move(Vector3 obj)
   {
      moveData.moveDir = obj;
   }

   public override void StateFixedUpdate()
   {
      PlayerMove();
      if (Mathf.Abs(_agent.CharacterController.velocity.magnitude) <1f)
      {
         _agent.TransitionState(idleState);
      }
   }

   protected void PlayerMove()
   {
      _agent.CharacterController.Move(moveData.moveDir * (moveData.moveSpeed * Time.deltaTime));
   }
}
