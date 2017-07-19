using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_Simulation.Structs
{
    public struct BankInfo
    {
        public int Money,
                   TotalWithdraw,
                   TotalDeposit,
                   Served,
                   Reputation;
        public string Title;
        
        public BankInfo(int money, int totalWithdraw, int totalDeposit, int served, string title, int reputation)
        {
            Money = money;
            TotalWithdraw = totalWithdraw;
            TotalDeposit = totalDeposit;
            Served = served;
            Title = title;
            Reputation = reputation;
        }
    }
}
