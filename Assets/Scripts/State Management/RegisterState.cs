using UnityEngine;

using B2B.Managers;

namespace B2B.StateManagement
{
    /// <summary>
    /// Class <c> RegisterState </c> runs the code that allows the player to register
    /// </summary>
    public class RegisterState : StateMachineBehaviour
    {
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (Input.GetKeyDown(InputManager.GetInstance.NextStateKey))
                GameManager.GetInstance.ChangeState(GameManager.States.MainMenu);
        }
    }
}
