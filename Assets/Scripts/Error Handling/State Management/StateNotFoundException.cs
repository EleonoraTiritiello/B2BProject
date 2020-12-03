using System;

namespace B2B.StateManagement.ErrorHandling 
{
    public class StateNotFoundException : StateManagementException
    {
        public StateNotFoundException() : base("An error occurred while getting the specified state") { }
        public StateNotFoundException(string message): base(message) { }
        public StateNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
