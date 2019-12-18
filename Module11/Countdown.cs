
using System.Threading;

namespace Module11
{
    /// <summary>
    /// Izh-11-3. Delegates. Lambdas and Events
    /// </summary>
    public class Countdown
    {
        public delegate void CountdownHandler(object sender, NewCountdownEventArgs e);
        public event CountdownHandler NewCountdown;

        /// <summary>
        /// Start countdown and then send a message to subscribers of event.
        /// </summary>
        /// <param name="time">Waiting time in ms.</param>
        public void Wait(int time)
        {
            Thread.Sleep(time);
            NewCountdown?.Invoke(this, new NewCountdownEventArgs($"{time}ms waited", time));
        }
    }
}
