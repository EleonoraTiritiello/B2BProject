using UnityEngine;

namespace B2B.Components
{
    /// <summary>
    /// Class <c> DontDestroyOnLoad </c> prevents Unity from destroying the object that owns this script on scene change
    /// </summary>
    public class DontDestroyOnLoad : MonoBehaviour
    {
        #region Unity Callbacks

        private void Awake() => DontDestroyOnLoad(gameObject);

        #endregion
    }
}
