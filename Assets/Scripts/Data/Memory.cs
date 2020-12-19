using UnityEngine;

using B2B.Components;

namespace B2B.Data
{
    public class Memory
    {
        #region Public Variables

        public byte Score { get; private set; }

        public Card[,] Cards { get; private set; }

        public Card FirstSelectedCard { get; private set; }
        public Card SecondSelectedCard { get; private set; }

        #endregion

        #region Initializers

        public Memory(Card[,] cards)
        {
            Cards = cards;
        }

        #endregion

        #region Methods

        #region Public Methods

        public void AddScore() => Score++;

        #endregion

        #region Private Methods

        private void UpdateCardSelection(Card card)
        {
            if (FirstSelectedCard == null)
                FirstSelectedCard = card;
            else if (SecondSelectedCard == null)
                SecondSelectedCard = card;
            else
                Debug.LogError("Sono state selezionate 3 carte!");
        }

        private void RemoveCardSelection(Card card)
        {
            if (FirstSelectedCard == card)
            {
                if (SecondSelectedCard != null)
                {
                    FirstSelectedCard = SecondSelectedCard;
                    SecondSelectedCard = null;
                }
                else
                    FirstSelectedCard = null;
            }
            else if (SecondSelectedCard == card)
            {
                SecondSelectedCard = null;
            }
        }

        private void ResetSelection()
        {
            FirstSelectedCard = null;
            SecondSelectedCard = null;
        }

        #endregion

        #endregion
    }
}
