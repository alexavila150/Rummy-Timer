using System;
using System.Collections.Generic;
using System.Text;
using Rummy_Timer.Models;
using Rummy_Timer.Logic;
using System.Timers;

namespace Rummy_Timer.Logic
{
    interface ILogic
    {
        ITimer Timer { get; set; }
        void Start();
        void Stop();
        void Pause();
        void GoToNextTurn();
        void AddPlayer(Player player);
        void RemovePlayer(Player player);
        Player GetCurrPlayer();
    }
}
