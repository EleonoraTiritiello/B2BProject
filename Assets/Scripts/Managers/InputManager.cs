using UnityEngine;

namespace B2B.Managers
{
    /// <summary>
    /// Class <c> InputManager </c> contains all the inputs that can be used within the program
    /// </summary>
    public class InputManager : Singleton<InputManager>
    {
        #region Public Variables

        /// <summary>
        /// Temporary inputs to test state management
        /// </summary>
        #region DEBUG

        public KeyCode NextStateKey = KeyCode.Space;
        public KeyCode NextStateOption1Key = KeyCode.Alpha1;
        public KeyCode NextStateOption2Key = KeyCode.Alpha2;
        public KeyCode NextStateOption3Key = KeyCode.Alpha3;
        public KeyCode NextStateOption4Key = KeyCode.Alpha4;
        public KeyCode NextStateOption5Key = KeyCode.Alpha5;

        #endregion

        public int SelectionKey = 0;

        #endregion
    }
}
