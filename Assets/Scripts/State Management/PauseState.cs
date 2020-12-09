using UnityEngine;

using B2B.Managers;

namespace B2B.StateManagement
{
    /// <summary>
    /// Class <c> PauseState </c> manages the game once the gameplay is paused
    /// </summary>
    public class PauseState : StateMachineBehaviour
    {
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (Input.GetKeyDown(InputManager.GetInstance.NextStateKey))
                GameManager.GetInstance.ChangeState(GameManager.States.Gameplay);
            else if (Input.GetKeyDown(InputManager.GetInstance.NextStateOption1Key))
                GameManager.GetInstance.ChangeState(GameManager.States.MainMenuLayer);
        }
    }
}
