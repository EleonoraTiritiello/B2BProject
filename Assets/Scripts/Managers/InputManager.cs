using UnityEngine;

namespace B2B.Managers
{
    public class InputManager : Singleton<InputManager>
    {
        #region Public Variables

        public KeyCode NextStateKey = KeyCode.Space;
        public KeyCode NextStateOption1Key = KeyCode.Alpha1;
        public KeyCode NextStateOption2Key = KeyCode.Alpha2;
        public KeyCode NextStateOption3Key = KeyCode.Alpha3;
        public KeyCode NextStateOption4Key = KeyCode.Alpha4;

        #endregion
    }
}
