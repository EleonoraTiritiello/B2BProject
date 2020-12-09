using UnityEngine;

using B2B.Managers;

namespace B2B.StateManagement 
{
    /// <summary>
    /// Class <c> GameSetupState </c> initialize everything needed to start the program
    /// </summary>
    public class GameSetupState : StateMachineBehaviour
    {
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (Input.GetKeyDown(InputManager.GetInstance.NextStateKey))
                GameManager.GetInstance.ChangeState(GameManager.States.MainMenuLayer);
        }
    }
}
