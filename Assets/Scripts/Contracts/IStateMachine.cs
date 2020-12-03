using System;

namespace B2B.Contracts
{
    /// <summary>
    /// The interface <c> IStateMachine </c> it facilitates the integration of a state machine into a class that inherits it
    /// </summary>
    /// <typeparam name="T"> The type of states to be managed </typeparam>
    public interface IStateMachine<T> where T : Enum
    {
        #region Public Variables

        /// <summary>
        /// An event that allows you to track changes in state
        /// </summary>
        event Action<T> OnStateChanged;

        #endregion

        #region Public Methods

        /// <summary>
        /// Allows you to change the current state
        /// </summary>
        /// <param name="state"> The state you want to set </param>
        void ChangeState(T state);

        #endregion
    }
}
