using System;
using System.Collections.Generic;
using UnityEngine;

using B2B.Managers;

namespace B2B.Components
{
    public class MemoryLoader
    {
        #region Public Variables

        public event Action OnMemoryLoad;

        #endregion

        #region Public Methods

        public void LoadTextures(string SpritesFolderPath)
        {
            Card[,] cards = MemoryPuzzleManager.GetInstance.Memory.Cards;

            List<int> availableIndices = new List<int>();

            for(int i = 0; i < 2; i++) { 
                for(int index = 0; index < cards.GetLength(0) * cards.GetLength(1) / 2; index++)
                {
                    availableIndices.Add(index);
                }
            }

            Sprite cardSprite;
            int cardIndex;

            Debug.LogWarning($"Loading sprites from 'Sprites/{SpritesFolderPath}/'");

            for(int x = 0; x < cards.GetLength(0); x++)
            {
                for(int y = 0; y < cards.GetLength(1); y++)
                {
                    cardIndex = availableIndices[UnityEngine.Random.Range(0, availableIndices.Count)];

                    cardSprite = Resources.Load<Sprite>($"Sprites/{SpritesFolderPath}/image_part_{cardIndex + 1:000}");
                    cards[x, y].SetSprite(cardSprite);
                    cards[x, y].StoreIndex(cardIndex);

                    availableIndices.Remove(cardIndex);
                }
            }

            OnMemoryLoad?.Invoke();
        }

        #endregion
    }
}
