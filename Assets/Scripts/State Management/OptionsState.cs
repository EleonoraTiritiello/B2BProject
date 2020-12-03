using UnityEngine;

using B2B.Managers;

namespace B2B.StateManagement
{
    public class OptionsState : StateMachineBehaviour
    {
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (Input.GetKeyDown(InputManager.GetInstance.NextStateKey))
                GameManager.GetInstance.ChangeState(GameManager.States.MainMenu);
        }
    }
}
