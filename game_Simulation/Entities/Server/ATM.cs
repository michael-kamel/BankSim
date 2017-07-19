using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_Simulation.Entities.Server
{
    public class ATM : BaseServer
    {
        public ATM() : base()
        {
            ResponseTime = 3000;
            ID = 6;
            MaxQueueLength = 20;
            Name = "ATM";
        }
    }
}
