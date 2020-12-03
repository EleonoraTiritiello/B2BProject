using UnityEngine;

namespace B2B.StateManagement
{
    public class LevelCompletedState : StateMachineBehaviour
    {
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.LogWarning("Level Completed!");
        }
    }
}
