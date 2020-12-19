using UnityEngine;

using B2B.Managers;

namespace B2B.StateManagement
{
    public class MemorySetupState : StateMachineBehaviour
    {
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            MemoryPuzzleManager.GetInstance.InitPuzzle(MemoryPuzzleManager.GetInstance.SelectedPicture);
            MemoryPuzzleManager.GetInstance.StartPuzzle(MemoryPuzzleManager.GetInstance.SelectedPicture);

            MemoryPuzzleManager.GetInstance.AllCardFlipped += ExitSetup;
        }

        private void ExitSetup()
        {
            MemoryPuzzleManager.GetInstance.ChangeState(MemoryPuzzleManager.States.FirstCardSelection);
        }
    }
}
