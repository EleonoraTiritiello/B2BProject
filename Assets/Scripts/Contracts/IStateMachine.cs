using System;

namespace B2B.Contracts
{
    public interface IStateMachine<T> where T : Enum
    {
        #region Public Variables

        event Action<T> OnStateChanged;

        #endregion

        #region Public Methods

        void ChangeState(T state);

        #endregion
    }
}
