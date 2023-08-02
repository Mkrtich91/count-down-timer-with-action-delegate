using System;
using System.Xml.Linq;
using CustomTimer.Interfaces;

namespace CustomTimer.Implementation
{
    /// <inheritdoc/>
    public class CountDownNotifier : ICountDownNotifier
    {
        private Action<string, int> startHandler;
        private Action<string> stopHandler;
        private Action<string, int> tickHandler;
#pragma warning disable SA1214
        private readonly string name;
#pragma warning restore SA1214
        private readonly int ticks;

        public void Init(Action<string, int> startHandler, Action<string> stopHandler, Action<string, int> tickHandler)
        {
            this.startHandler = startHandler;
            this.stopHandler = stopHandler;
            this.tickHandler = tickHandler;
        }

#pragma warning disable SA1201
        public CountDownNotifier(string name, int ticks)
#pragma warning restore SA1201
        {
            this.name = name;
            this.ticks = ticks;
        }

        public void Run()
        {
            this.startHandler?.Invoke(this.name, this.ticks);

            for (int i = this.ticks - 1; i > 0; i--)
            {
                Thread.Sleep(1000);

                this.tickHandler?.Invoke(this.name, i);
            }

            this.stopHandler?.Invoke(this.name);
        }
    }
}
