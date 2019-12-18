using System;

namespace Module11
{
    /// <summary>
    /// Izh-11-3. Delegates. Lambdas and Events
    /// </summary>
    public class NewCountdownEventArgs : EventArgs
    {
        public string Message { get; }
        public int WaitingTime { get; }

        public NewCountdownEventArgs(string message, int waitingTime)
        {
            Message = message;
            WaitingTime = waitingTime;
        }
    }
}
