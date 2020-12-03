using UnityEngine;

namespace B2B.StateManagement
{
    /// <summary>
    /// Class <c> LevelFailedState </c> executes the code once the level is failed
    /// </summary>
    public class LevelFailedState : StateMachineBehaviour
    {
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.LogWarning("Game Over!");
        }
    }
}
