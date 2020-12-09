using UnityEngine;

using B2B.Managers;

namespace B2B.StateManagement
{
    /// <summary>
    /// Class <c> LevelCompletedState </c> executes the code once the puzzle is completed
    /// </summary>
    public class LevelCompletedState : StateMachineBehaviour
    {
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (Input.GetKeyDown(InputManager.GetInstance.NextStateKey))
                GameManager.GetInstance.ChangeState(GameManager.States.Gameplay);
        }
    }
}
