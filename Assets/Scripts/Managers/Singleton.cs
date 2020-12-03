using UnityEngine;

namespace B2B.Managers
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        #region Singleton

        private static T _instance;

        public static T GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = FindObjectOfType<T>();

                return _instance;
            }
        }

        #endregion

        #region Public Methods

        public bool Exists() => GetInstance != null;

        #endregion
    }
}
