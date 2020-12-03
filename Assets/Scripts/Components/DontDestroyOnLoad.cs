using UnityEngine;

namespace B2B.Components
{
    public class DontDestroyOnLoad : MonoBehaviour
    {
        #region Unity Callbacks

        private void Awake() => DontDestroyOnLoad(gameObject);

        #endregion
    }
}
