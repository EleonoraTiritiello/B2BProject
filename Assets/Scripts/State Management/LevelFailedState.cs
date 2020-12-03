using UnityEngine;

namespace B2B.StateManagement
{
    public class LevelFailedState : StateMachineBehaviour
    {
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.LogWarning("Game Over!");
        }
    }
}
