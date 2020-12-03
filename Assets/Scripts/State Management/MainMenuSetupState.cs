using UnityEngine;

using B2B.Managers;

namespace B2B.StateManagement
{
    public class MainMenuSetupState : StateMachineBehaviour
    {
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (Input.GetKeyDown(InputManager.GetInstance.NextStateKey))
                GameManager.GetInstance.ChangeState(GameManager.States.MainMenu);
            else if (Input.GetKeyDown(InputManager.GetInstance.NextStateOption1Key))
                GameManager.GetInstance.ChangeState(GameManager.States.Register);
        }
    }
}
