using UnityEngine;

using B2B.Managers;

namespace B2B.StateManagement
{
    public class GameplayState : StateMachineBehaviour
    {
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (Input.GetKeyDown(InputManager.GetInstance.NextStateKey))
                GameManager.GetInstance.ChangeState(GameManager.States.Pause);
            else if (Input.GetKeyDown(InputManager.GetInstance.NextStateOption1Key))
                GameManager.GetInstance.ChangeState(GameManager.States.LevelFailed);
            else if (Input.GetKeyDown(InputManager.GetInstance.NextStateOption2Key))
                GameManager.GetInstance.ChangeState(GameManager.States.LevelCompleted);
        }
    }
}
