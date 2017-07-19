using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_Simulation.Entities.Server
{
    public class OnlineBanking : BaseServer
    {
        public OnlineBanking() : base()
        {
            ResponseTime = 2400;
            ID = 7;
            MaxQueueLength = 50;
            Name = "OB";
        }
    }
}
