using UnityEngine;

using B2B.Managers;

namespace B2B.StateManagement
{
    /// <summary>
    /// Class <c> MainMenuState </c> runs the code for the main menu
    /// </summary>
    public class MainMenuState : StateMachineBehaviour
    {
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (Input.GetKeyDown(InputManager.GetInstance.NextStateKey))
                GameManager.GetInstance.ChangeState(GameManager.States.GameplayLayer);
            else if (Input.GetKeyDown(InputManager.GetInstance.NextStateOption1Key))
                GameManager.GetInstance.ChangeState(GameManager.States.Options);
            else if (Input.GetKeyDown(InputManager.GetInstance.NextStateOption2Key))
                GameManager.GetInstance.ChangeState(GameManager.States.Credit);
            else if (Input.GetKeyDown(InputManager.GetInstance.NextStateOption3Key))
                GameManager.GetInstance.ChangeState(GameManager.States.Profile);
            else if (Input.GetKeyDown(InputManager.GetInstance.NextStateOption4Key))
                GameManager.GetInstance.ChangeState(GameManager.States.Achievements);
        }
    }
}
