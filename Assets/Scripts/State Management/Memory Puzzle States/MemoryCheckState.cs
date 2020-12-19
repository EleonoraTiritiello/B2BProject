using UnityEngine;

using B2B.Managers;
using B2B.Components;

namespace B2B.StateManagement
{
    public class MemoryCheckState : StateMachineBehaviour
    {
        private Card _firstCard;
        private Card _secondCard;

        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            _firstCard = MemoryPuzzleManager.GetInstance.FirstSelectedCard;
            _secondCard = MemoryPuzzleManager.GetInstance.SecondSelectedCard;

            if (MemoryPuzzleManager.GetInstance.CheckCards())
            {
                MemoryPuzzleManager.GetInstance.Memory.AddScore();

                _firstCard.DisableInteraction();
                _secondCard.DisableInteraction();

                Debug.LogWarning("NICE!");

                MemoryPuzzleManager.GetInstance.ChangeState(MemoryPuzzleManager.States.ShowPicture);
            }
            else
            {
                _firstCard.Flip();
                _secondCard.Flip();

                MemoryPuzzleManager.GetInstance.ChangeState(MemoryPuzzleManager.States.FirstCardSelection);
            }
        }

        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            MemoryPuzzleManager.GetInstance.ResetCards();
        }
    }
}
