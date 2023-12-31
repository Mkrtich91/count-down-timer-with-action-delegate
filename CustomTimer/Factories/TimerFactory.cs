﻿using System;

namespace CustomTimer.Factories
{
    /// <summary>
    /// Implements the factory method pattern <see><cref>https://en.wikipedia.org/wiki/Factory_method_pattern</cref></see>
    /// for creating an object of the <see cref="Timer"/> class.
    /// </summary>
    public class TimerFactory
    {
        /// <summary>
        /// Create an object of the <see cref="Timer"/> class.
        /// </summary>
        /// <param name="name">Name of timer.</param>
        /// <param name="ticks">Count of ticks.</param>
        /// <returns>A reference to an object of the <see cref="Timer"/> class.</returns>
#pragma warning disable CA1822
        public Timer CreateTimer(string name, int ticks)
#pragma warning restore CA1822
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }

            if (ticks <= 0)
            {
                throw new ArgumentException("Number of ticks must be greater than 0.", nameof(ticks));
            }

            Timer timer = new Timer(name, ticks);

            return timer;
        }
    }
}
