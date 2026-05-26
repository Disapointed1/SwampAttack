using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
   [SerializeField] private List<Transition> _transitions;

   protected Player Target { get; private set; }

   public void Enter(Player target)
   {
      if (enabled == false)
      {
         Target = target;
         enabled = true;
         foreach (var t in _transitions)
         {
            t.enabled = true;
            t.Init(target);
         }
      }
   }

   public void Exit()
   {
      if (enabled == true)
      {
         foreach (var t in _transitions)
            t.enabled = false;

         enabled = false;
      }
   }

   public State GetNextState()
   {
      foreach (var t in _transitions )
      {
         if (t.NeedTransit)
            return t.TargetState;
      }
      return null;
   }

}
