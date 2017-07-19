using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game_Simulation.Enums;

namespace game_Simulation.Entities
{
    public struct Transaction
    {
        public readonly int Amount;
        public readonly TransactionRequestType TransactionType;

        public Transaction(int amount, TransactionRequestType transactionType)
        {
            Amount = amount;
            TransactionType = transactionType;
        }
    }
}
