using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
   public State moveState;

   protected override void EnterState()
   {
      base.EnterState();

      Debug.Log("Enter IdleState");
      
      if (_agent.InputReader.inputVector.magnitude!=0)
      {
         _agent.TransitionState(moveState);
      }
   }

   protected override void EndScene()
   {
      base.EndScene();
   }

   protected override void ExitState()
   {
      base.ExitState();
   }
   
   protected override void Move(Vector3 obj)
   {
      if(Mathf.Abs(obj.magnitude) > 0)
      {
         _agent.TransitionState(moveState);
      }
   }
}
