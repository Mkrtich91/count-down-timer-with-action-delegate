﻿namespace CustomTimer
{
    /// <summary>
    /// A custom class for simulating a countdown clock, which implements the ability to send a messages and additional
    /// information about the Started, Tick and Stopped events to any types that are subscribing the specified events.
    ///
    /// - When creating an object of Timer class, it must be assigned:
    ///     - name (not null or empty string, otherwise ArgumentException will be thrown);
    ///     - the number of ticks (the number must be greater than 0, otherwise an exception will throw an ArgumentException).
    ///
    /// - After the timer has been created, it can fire the Started event, the event should contain information about
    /// the name of the timer and the number of ticks to start.
    ///
    /// - After starting the timer, it fires Tick events, which contain information about the name of the timer and
    /// the number of ticks left for triggering, there should be delays between Tick events, delays are modeled by Thread.Sleep.
    ///
    /// - After all Tick events are triggered, the timer should start the Stopped event, the event should contain information about
    /// the name of the timer.
    /// </summary>
    public class Timer
    {
        public string Name { get; private set; }

        public int Ticks { get; private set; }

        public object Start { get; internal set; }

        public object Stop { get; internal set; }

#pragma warning disable SA1201
        public Timer(string name, int ticks)
#pragma warning restore SA1201
        {
           this.Name = name;
           this.Ticks = ticks;
        }
    }
}
