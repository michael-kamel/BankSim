using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using game_Simulation.Enums;

namespace game_Simulation.Calculations
{
    public static class BankCalculations
    {
        static readonly double[] BankPD = { 0.01606, 0.05164, 0.11884, 0.19592, 0.23148, 0.19592, 0.11884, 0.05164, 0.01606, 0.003587 };
        static readonly int[] DepositAmounts = { 100, 300, 500, 700, 900, 1100, 1300, 1500, 1700, 9900 },
                              WithDrawAmounts = { 30, 90, 150, 210, 270, 330, 390, 450, 510, 5970 };
        const int PDElementCount = 10;
        public const int WithdrawRate = 7,
                         DepositRate = 3,
                         WithdrawMargin = 61,
                         DepositMargin = 201,
                         WithdrawalAllowance = 1000,
                         MaxQueueLength = 9,
                         MaxTellers = 5,
                         ServerMinumumDelayInterval = 1,
                         DefaultLoanInterest = 10,
                         MaxLoans = 20,
                         AverageLoansPerDay = 10,
                         GameSpeedMultiplier = 10,
                         TellerPrice = 1,
                         TellerL2Price = 6000,
                         TellerL3Price = 1,
                         TellerL4Price = 1,
                         TellerL5Price = 1,
                         ATMPrice = 1,
                         OBPrice = 1;
                         
        public const double LoanProbability = 1.0/720;

        public static int GetDepositAmount()
        {
           int amount = GetTransactionAmount(TransactionRequestType.Deposit);
           return new Random().Next(amount, amount+DepositMargin);
        }
        public static int GetWithDrawAmount()
        {
            int amount = GetTransactionAmount(TransactionRequestType.WithDrawal);
            return new Random().Next(amount, amount + WithdrawMargin);
        }
        static int GetTransactionAmount(TransactionRequestType type)
        {
            KeyValuePair<int, Double>[] elements = new KeyValuePair<int, double>[PDElementCount];
            int[] TransactionAmounts;
            if (type == Enums.TransactionRequestType.Deposit)
                TransactionAmounts = DepositAmounts;
            else
                TransactionAmounts = WithDrawAmounts;
            for (int i = 0; i < PDElementCount; i++)
            {
                KeyValuePair<int, double> KVP = new KeyValuePair<int, double>(TransactionAmounts[i], BankPD[i]);
                elements[i] = KVP;
            }
            return RouletteWheel.GetRandomWeigthedElements(elements, 1)[0].Key;
        }
        public static double CalculateReputation(int customers)
        {
            double res = (double)customers / 480;
            return (1000 * Math.Pow(res, (1.0 / 3.0)));
        }
        public static double CalculateCustomerFlowRate(double reputation)
        {
            return 0.0005 * reputation;
        }
        [Obsolete]
        public static int CalculateMonthlyLoanPayment2(int principal, int days, int interestPercentage)
        {
            double rate = (double)interestPercentage / 1200;
            return (int)((rate + (rate / ((Math.Pow(1 + rate, days))-1)))*principal);
        }
        public static int CalculateMonthlyLoanPayment(int principal, int interestPercentage, int duration)
        {
            return ((principal / interestPercentage) * duration + principal) / duration;
        }
        public static int CalculateLoanAmount(Enums.LoanLevel loanLevel)
        {
            Random rnd = new Random();
            int amount = 0;
            switch (loanLevel)
            {
                case LoanLevel.Category1Loan: amount = rnd.Next(3000, 7000); break;
                case LoanLevel.Category2Loan: amount = rnd.Next(8000, 12000); break;
                case LoanLevel.Category3Loan: amount = rnd.Next(20000, 30000); break;
                case LoanLevel.Category4Loan: amount = rnd.Next(45000, 55000); break;
                case LoanLevel.Category5Loan: amount = rnd.Next(90000, 110000); break;
            }
            return amount;
        }
    }
}
