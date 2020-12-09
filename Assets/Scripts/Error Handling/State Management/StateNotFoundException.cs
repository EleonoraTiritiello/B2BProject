using System;

namespace B2B.StateManagement.ErrorHandling 
{
    /// <summary>
    /// Class <c> StateNotFoundException </c> is an exception for errors involving a failure to resolve a state
    /// </summary>
    public class StateNotFoundException : StateManagementException
    {
        public StateNotFoundException() : base("An error occurred while getting the specified state") { }
        public StateNotFoundException(string message): base(message) { }
        public StateNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
