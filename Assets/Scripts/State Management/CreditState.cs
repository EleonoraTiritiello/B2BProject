using UnityEngine;

using B2B.Managers;

namespace B2B.StateManagement {
    /// <summary>
    /// Class <c> CreditsState </c> runs the code related to the credit page
    /// </summary>
    public class CreditState : StateMachineBehaviour
    {
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (Input.GetKeyDown(InputManager.GetInstance.NextStateKey))
                GameManager.GetInstance.ChangeState(GameManager.States.MainMenu);
        }
    }
}
