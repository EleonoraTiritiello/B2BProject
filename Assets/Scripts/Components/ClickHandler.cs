using System;
using UnityEngine;

namespace B2B.Components
{
    [RequireComponent(typeof(Collider))]
    public class ClickHandler : MonoBehaviour
    {
        #region Public Variables

        public bool Active = true;

        public event Action OnClick;

        #endregion

        #region Unity Callbacks

        private void OnMouseOver()
        {
            if (Active)
            {
                if (Input.GetMouseButtonDown(0))
                    OnClick?.Invoke();
            }
        }

        #endregion
    }
}
