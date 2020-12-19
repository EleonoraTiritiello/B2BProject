using UnityEngine;

using B2B.Managers;
using B2B.Components;

namespace B2B.StateManagement
{
    public class MemorySecondCardSelectionState : StateMachineBehaviour
    {
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            MemoryPuzzleManager.GetInstance.OnCardSelect += LockSecondCard;
            MemoryPuzzleManager.GetInstance.OnCardDeselect += UnlockCard;
        }

        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            MemoryPuzzleManager.GetInstance.OnCardSelect -= LockSecondCard;
            MemoryPuzzleManager.GetInstance.OnCardDeselect -= UnlockCard;
        }

        private void LockSecondCard(Card card)
        {
            card.Lock();

            MemoryPuzzleManager.GetInstance.ChangeState(MemoryPuzzleManager.States.Check);
        }

        private void UnlockCard(Card card)
        {
            card.Unlock();
            
            MemoryPuzzleManager.GetInstance.ChangeState(MemoryPuzzleManager.States.FirstCardSelection);
        }
    }
}
