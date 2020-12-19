using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using B2B.Contracts;
using B2B.StateManagement.ErrorHandling;
using B2B.Components;
using B2B.Data;

namespace B2B.Managers
{
    [RequireComponent(typeof(Animator))]
    public sealed class MemoryPuzzleManager : PuzzleManager<MemoryPuzzleManager>, IStateMachine<MemoryPuzzleManager.States>
    {
        #region Variables

        #region Public Variables

        public Picture SelectedPicture; //DEBUG

        public Memory Memory { get; private set; }

        [Header("Setup")]
        public Vector2Int MemorySize;
        public Vector2 CardsOffset = Vector2.zero;
        public bool MakeItSquare = false;

        public Vector3 CardFlipAnimationAxis = Vector3.forward;
        public float CardFlipAnimationDuration = 1f;

        public event Action<States> OnStateChanged;

        public event Action AllCardFlipped;

        public event Action<Card> OnCardSelect;
        public event Action<Card> OnCardDeselect;

        public Card FirstSelectedCard { get; private set; }
        public Card SecondSelectedCard { get; private set; }

        public enum States
        {
            Setup,
            Tutorial,
            FirstCardSelection,
            SecondCardSelection,
            Check,
            ShowPicture,
            PuzzleCompleted
        }

        public States CurrentState { get; private set; }

        #endregion

        #region Private Variables   

        [Space(5)]
        [SerializeField]
        private float _cardHideDelay = 0.2f;

        private Animator _animator;

        private readonly Dictionary<States, string> _animatorTriggers = new Dictionary<States, string>
        {
            { States.Setup, "GoToSetup" },
            { States.Tutorial, "GoToTutorial" },
            { States.FirstCardSelection, "GoToFirstCardSelection" },
            { States.SecondCardSelection, "GoToSecondCardSelection" },
            { States.Check, "GoToCheck" },
            { States.ShowPicture, "GoToShowPicture" },
            { States.PuzzleCompleted, "GoToPuzzleCompleted" }
        };

        private MemoryLoader _ml;

        [SerializeField]
        private GameObject _cardPrefab;

        #endregion

        #endregion

        #region Unity Callbacks

        private void Awake()
        {
            if (_animator == null) _animator = GetComponent<Animator>();

            if (_ml == null) _ml = new MemoryLoader();

            ResourcesFolderSuffix = "4x2";
        }

        #endregion

        #region Methods

        #region Public Methods

        public bool CheckCards()
        {
            if (FirstSelectedCard.Index == SecondSelectedCard.Index)
                return true;

            return false;
        }

        public void OnCardSelected(Card card)
        {
            if (FirstSelectedCard == null)
                FirstSelectedCard = card;
            else
            {
                if (SecondSelectedCard == null)
                    SecondSelectedCard = card;
            }

            Debug.Log($"Card Selected!\nFirst Card -> {FirstSelectedCard?.name} - Second Card -> {SecondSelectedCard?.name}");

            OnCardSelect?.Invoke(card);
        }

        public void OnCardDeselected(Card card)
        {
            if (FirstSelectedCard == card)
            {
                FirstSelectedCard = null;

                if (SecondSelectedCard != null)
                {
                    FirstSelectedCard = SecondSelectedCard;
                    SecondSelectedCard = null;
                }
            }
            else
            {
                if (SecondSelectedCard == card)
                    SecondSelectedCard = null;
            }

            Debug.Log($"Card Deselected!\nFirst Card -> {FirstSelectedCard?.name} - Second Card -> {SecondSelectedCard?.name}");

            OnCardDeselect?.Invoke(card);
        }

        public void ResetCards()
        {
            FirstSelectedCard = null;
            SecondSelectedCard = null;
        }

        public override void InitPuzzle(Picture picture)
        {
            Memory = new Memory(new Card[MemorySize.x, MemorySize.y]);

            Sprite sprite = Resources.Load<Sprite>($"Sprites/{picture.name}");
            Vector2 pictureSize = new Vector2(sprite.rect.width / 4 / 100f, sprite.rect.height / 2 / 100f);

            if (MakeItSquare)
            {
                if (pictureSize.x < pictureSize.y)
                    pictureSize.x = pictureSize.y;
                else if (pictureSize.y < pictureSize.x)
                    pictureSize.y = pictureSize.x;
            }

            GameObject card;
            Vector3 position = Vector3.zero;

            for(int x = 0; x < MemorySize.x; x++)
            {
                for(int y = 0; y < MemorySize.y; y++)
                {
                    card = Instantiate(_cardPrefab, position, Quaternion.identity, transform);
                    card.name = $"Card [{x}, {y}]";

                    Card cardScript = card.GetComponent<Card>();

                    Memory.Cards[x, y] = cardScript;

                    position.y+=pictureSize.y + CardsOffset.y;
                }

                position.x+=pictureSize.x + CardsOffset.x;
                position.y = 0;
            } 

            base.InitPuzzle(picture);
        }

        public override void StartPuzzle(Picture picture)
        {
            _ml.LoadTextures($"{picture.name}/{ResourcesFolderSuffix}");

            StartCoroutine(FlipAllCards());

            base.StartPuzzle(picture);
        }

        public void ChangeState(States state)
        {
            if (!_animatorTriggers.ContainsKey(state))
                throw new StateNotFoundException($"No trigger was found on object '{name}' leading to state '{state}'");

            _animator.SetTrigger(_animatorTriggers[state]);

            CurrentState = state;

            OnStateChanged?.Invoke(state);
        }

        #endregion

        #region Private Methods

        private IEnumerator FlipAllCards()
        {
            for (int y = Memory.Cards.GetLength(1) - 1; y >= 0; y--)
            {
                for (int x = 0; x < Memory.Cards.GetLength(0); x++)
                {
                    Memory.Cards[x, y].Unlock();

                    Memory.Cards[x, y].Flip();

                    yield return new WaitForSeconds(_cardHideDelay);
                }
            }

            AllCardFlipped?.Invoke();

            yield return null;
        }

        #endregion

        #endregion
    }
}
