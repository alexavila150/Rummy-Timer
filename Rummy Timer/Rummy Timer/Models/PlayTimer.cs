using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Rummy_Timer.Models
{
    class PlayTimer : ITimer
    {
        public double totalTime;
        public double timeLeft;
        public Timer timer;
        public event EventHandler<TimerEventArgs> Finished;
        public event EventHandler<TimerEventArgs> OneSecondPassed;

        private readonly static PlayTimer instance = new PlayTimer(30);

        private PlayTimer(double totalTime)
        {
            this.totalTime = totalTime;
            timeLeft = totalTime;
            Finished += OnFinished;
        }

        public static PlayTimer GetInstance() {
            return instance;
        }

        public void Start()
        {
            timer?.Close();
            timer?.Dispose();

            timer = new Timer(1000)
            {
                Enabled = true,
                AutoReset = true,
            };
            timer.Elapsed += OnElapsed;
        }

        public void Pause()
        {
            timer.Enabled = false;
        }

        public void Resume() 
        {
            timer.Enabled = true;
        }

        public void Stop()
        {
            timeLeft = 30;
            timer.Enabled = false;   
        }

        public void Reset()
        {
            timeLeft = 30;
            timer.Enabled = true;
        }

        public void OnElapsed(object value, ElapsedEventArgs elapsedEventArgs)
        {
            timeLeft -= 1;
            OneSecondPassed.Invoke(this, new TimerEventArgs { TimeLeft = timeLeft });
            if (timeLeft == 0)
            {
                Finished.Invoke(this, new TimerEventArgs() { TimeLeft = timeLeft});
            }
            Console.WriteLine("Time Left: " + timeLeft);
        }

        public void OnFinished(object value, EventArgs eventArgs) {
            //TODO: Alert that the time is up
            timeLeft = 30;
            timer.Enabled = false;
        }
    }
}
