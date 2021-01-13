using System;
using System.Collections.Generic;
using System.Text;

namespace Rummy_Timer.Models
{
    interface ITimer
    {
        event EventHandler<TimerEventArgs> Finished;
        event EventHandler<TimerEventArgs> OneSecondPassed;
        void Pause();
        void Resume();
        void Start();
        void Stop();
        void Reset();
    }

    public class TimerEventArgs : EventArgs
    {
        public double TimeLeft { get; set; }
    }
}
