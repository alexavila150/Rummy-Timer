using System;
using System.Collections.Generic;
using System.Text;
using Rummy_Timer.Models;
using System.Timers;

namespace Rummy_Timer.Logic
{
    class Logic : ILogic
    {
        private readonly List<Player> players;
        private int currUserIndex = 0;

        private static readonly Logic instance = new Logic();

        public ITimer Timer { get; set; }

        private Logic() {
            Timer = PlayTimer.GetInstance();
            players = new List<Player>();
            currUserIndex = 0;
        }

        public static Logic GetInstance()
        {
            return instance;
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void GoToNextTurn()
        {
            Timer.Reset();
            currUserIndex = (currUserIndex + 1) % players.Count;
        }

        public void Pause()
        {
            Timer.Pause();
        }

        public void Resume() 
        {
            Timer.Resume();
        }

        public void RemovePlayer(Player player)
        {
            players.Remove(player);
        }

        public void Start()
        {
            Timer.Start();
            currUserIndex = 0;
        }

        public void Stop()
        {
            Timer.Stop();
            currUserIndex = 0;
        }

        public Player GetCurrPlayer() {
            return players[currUserIndex];
        }
    }
}
