using System;
using System.Collections;
using UnityEngine;

using B2B.Managers;

namespace B2B.Components
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Card : MonoBehaviour
    {
        #region Public Variables

        public int Index { get; private set; }

        public event Action<Card> OnSelect;
        public event Action<Card> OnDeselect;

        #endregion

        #region Private Variables

        private SpriteRenderer _sr;

        [SerializeField]
        private GameObject _back;

        private bool _selected = true;
        private bool _locked = true;

        #endregion

        #region Unity Callbacks

        private void Awake()
        {
            _sr = GetComponentInChildren<SpriteRenderer>();

            _back.GetComponent<ClickHandler>().OnClick += Flip;

            if (OnSelect == null) OnSelect += MemoryPuzzleManager.GetInstance.OnCardSelected;
            if (OnDeselect == null) OnDeselect += MemoryPuzzleManager.GetInstance.OnCardDeselected;
        }

        #endregion

        #region Methods

        #region Public Methods

        public void DisableInteraction() => _back.GetComponent<ClickHandler>().OnClick -= Flip;

        public void StoreIndex(int index) => Index = index;

        public void Lock() => _locked = true;
        public void Unlock() => _locked = false;

        public void SetSprite(Sprite sprite) 
        {
            _sr.sprite = sprite;
            _back.transform.localScale = new Vector3(sprite.rect.width / 100f, sprite.rect.height / 100f, 0);
        }

        public void Flip()
        {
            if (!_locked)
            {
                StartCoroutine(DoFlipAnimation());

                _selected = !_selected;
            }

        }

        #endregion

        #region Private Methods

        private IEnumerator DoFlipAnimation()
        {
            _locked = true;

            float elapsedTime = 0f;
            float animationDuration = MemoryPuzzleManager.GetInstance.CardFlipAnimationDuration;

            Quaternion startingRotation = transform.rotation;
            Quaternion targetRotation = startingRotation * Quaternion.Euler(MemoryPuzzleManager.GetInstance.CardFlipAnimationAxis * 180f);

            while (elapsedTime < animationDuration)
            {
                transform.rotation = Quaternion.Slerp(startingRotation, targetRotation, elapsedTime / animationDuration);

                elapsedTime += Time.deltaTime;

                yield return new WaitForEndOfFrame();
            }

            transform.rotation = targetRotation;

            if (_selected)
                OnSelect?.Invoke(this);
            else
                OnDeselect?.Invoke(this);

            _locked = false;

            yield return null;
        }

        #endregion

        #endregion
    }
}
