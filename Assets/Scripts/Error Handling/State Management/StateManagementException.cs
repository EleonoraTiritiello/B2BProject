using System;

namespace B2B.StateManagement.ErrorHandling
{
    /// <summary>
    /// Class <c> StateManagementException </c> is a generic exception for errors involving a state machine
    /// </summary>
    public class StateManagementException : Exception
    {
        public StateManagementException() : base("An error occurred in the state management") { }
        public StateManagementException(string message) : base(message) { }
        public StateManagementException(string message, Exception innerException) : base(message, innerException) { }
    }
}
