using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using System.Collections.Concurrent;

namespace game_Simulation.Entities.Server
{
    public class Teller : BaseServer
    {
        int _level;

        public Teller() : base()
        {
            Level = 1;
            MaxQueueLength = 10;
            Name = "Teller";
        }

        [DefaultValueAttribute(1)]
        public int Level
        {
            get { return _level; }
            set
            {
                if (value > 5 || value < 1)
                    return;
                    _level = value;
                switch (value)
                {
                    case 1: ResponseTime = 10000; break;
                    case 2: ResponseTime = 8500; break;
                    case 3: ResponseTime = 7000; break;
                    case 4: ResponseTime = 5500; break;
                    case 5: ResponseTime = 4000; break;
                }
            }
        }
    }
}
