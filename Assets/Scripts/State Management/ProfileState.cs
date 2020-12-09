using UnityEngine;

using B2B.Managers;

namespace B2B.StateManagement
{
    /// <summary>
    /// Class <c> ProfileState </c> executes the code for the player's profile page
    /// </summary>
    public class ProfileState : StateMachineBehaviour
    {
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (Input.GetKeyDown(InputManager.GetInstance.NextStateKey))
                GameManager.GetInstance.ChangeState(GameManager.States.MainMenu);
        }
    }
}
