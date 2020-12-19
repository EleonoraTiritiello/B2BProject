using UnityEngine;

using B2B.Managers;

namespace B2B.StateManagement
{
    public class MemoryShowPictureState : StateMachineBehaviour
    {
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (MemoryPuzzleManager.GetInstance.Memory.Score >= MemoryPuzzleManager.GetInstance.MemorySize.x * MemoryPuzzleManager.GetInstance.MemorySize.y)
                MemoryPuzzleManager.GetInstance.ChangeState(MemoryPuzzleManager.States.PuzzleCompleted);
            else
                MemoryPuzzleManager.GetInstance.ChangeState(MemoryPuzzleManager.States.FirstCardSelection);
        }
    }
}
