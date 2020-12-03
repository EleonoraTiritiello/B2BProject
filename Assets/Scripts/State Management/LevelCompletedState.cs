using UnityEngine;

namespace B2B.StateManagement
{
    /// <summary>
    /// Class <c> LevelCompletedState </c> executes the code once the level is completed
    /// </summary>
    public class LevelCompletedState : StateMachineBehaviour
    {
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.LogWarning("Level Completed!");
        }
    }
}
