using UnityEngine;

namespace B2B.Managers
{
    /// <summary>
    /// Class <c> Singleton </c> it allows any class that inherits from it to get the same benefits as a static class
    /// </summary>
    /// <typeparam name="T"> The type of the child class </typeparam>
    public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        #region Singleton

        /// <summary>
        /// The instance of the class
        /// </summary>
        private static T _instance;

        /// <summary>
        /// High-level access to the instance
        /// </summary>
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

        /// <summary>
        /// Check if the instance exists
        /// </summary>
        /// <returns> Returns <c> false </c> if the instance is equal to <c> null </c>, otherwise it returns <c> true </c> </returns>
        public bool Exists() => GetInstance != null;

        #endregion
    }
}
