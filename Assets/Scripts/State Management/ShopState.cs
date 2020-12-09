using UnityEngine;

using B2B.Managers;

namespace B2B.StateManagement {
    /// <summary>
    /// Class <c> Shop </c> executes the code related to the part of the in app purchases
    /// </summary>
    public class ShopState : StateMachineBehaviour
    {
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (Input.GetKeyDown(InputManager.GetInstance.NextStateKey))
                GameManager.GetInstance.ChangeState(GameManager.States.MainMenu);
        }
    }
}
