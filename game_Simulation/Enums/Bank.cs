using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_Simulation.Enums
{
    public enum LoanLevel : int
    {
        Category1Loan = 1,
        Category2Loan = 2,
        Category3Loan = 3,
        Category4Loan = 4,
        Category5Loan = 5
    }
    public enum LoanTrustedLevel
    {
        VeryLow,
        Low,
        Medium,
        High,
        VeryHigh
    }
    public enum TransactionRequestType : byte
    {
         Deposit = 0x44,
         WithDrawal = 0x57,
         Invalid = 0x00
    }
    public enum BankReputationTitle
    {
        BeginnerBanker1,
        BeginnerBanker2,
        BeginnerBanker3,
        NoviceBanker1,
        NoviceBanker2,
        NoviceBanker3,
        ProfessionalBanker1,
        ProfessionalBanker2,
        ProfessionalBanker3,
        MasterBanker1,
        MasterBanker2,
        MasterBanker3,
        EliteBanker1,
        EliteBanker2,
        EliteBanker3,
        GlobalBanker
    }
    public static class BankTitleExtensions
    {
        const int L1 = 400,
                  L2 = 700,
                  L3 = 1000,
                  L4 = 1693,
                  L5 = 2386,
                  L6 = 3079,
                  L7 = 3772,
                  L8 = 4465,
                  L9 = 5158,
                  L10 = 5851,
                  L11 = 6544,
                  L12 = 7237,
                  L13 = 7930,
                  L14 = 8623,
                  L15 = 9316,
                  L16 = 10000;
        public static string GetString(BankReputationTitle title)
        {
            switch (title)
            {
                case BankReputationTitle.BeginnerBanker1: return "Beginner Banker L1";
                case BankReputationTitle.BeginnerBanker2: return "Beginner Banker L2";
                case BankReputationTitle.BeginnerBanker3: return "Beginner Banker L2";
                case BankReputationTitle.NoviceBanker1: return "Novice Banker L1";
                case BankReputationTitle.NoviceBanker2: return "Novice Banker L2";
                case BankReputationTitle.NoviceBanker3: return "Novice Banker L3";
                case BankReputationTitle.ProfessionalBanker1: return "Professional Banker L1";
                case BankReputationTitle.ProfessionalBanker2: return "Professional Banker L2";
                case BankReputationTitle.ProfessionalBanker3: return "Professional Banker L3";
                case BankReputationTitle.MasterBanker1: return "Master Banker L1";
                case BankReputationTitle.MasterBanker2: return "Master Banker L2";
                case BankReputationTitle.MasterBanker3: return "Master Banker L3";
                case BankReputationTitle.EliteBanker1: return "Elite Banker L1";
                case BankReputationTitle.EliteBanker2: return "Elite Banker L2";
                case BankReputationTitle.EliteBanker3: return "Elite Banker L3";
                case BankReputationTitle.GlobalBanker: return "Global Banker";
                default: return "Unknown Title";
            }
        }
        public static string GetBankTitle(double reputation)
        {
            return GetString(GetTitle(reputation));
        }
        public static BankReputationTitle GetTitle(double reputation)
        {
            if (reputation < L1)
                return BankReputationTitle.BeginnerBanker1;
            if (reputation < L2)
                return BankReputationTitle.BeginnerBanker2;
            if (reputation < L3)
                return BankReputationTitle.BeginnerBanker3;
            if (reputation < L4)
                return BankReputationTitle.NoviceBanker1;
            if (reputation < L5)
                return BankReputationTitle.NoviceBanker2;
            if (reputation < L6)
                return BankReputationTitle.NoviceBanker3;
            if (reputation < L7)
                return BankReputationTitle.ProfessionalBanker1;
            if (reputation < L8)
                return BankReputationTitle.ProfessionalBanker2;
            if (reputation < L9)
                return BankReputationTitle.ProfessionalBanker3;
            if (reputation < L10)
                return BankReputationTitle.MasterBanker1;
            if (reputation < L11)
                return BankReputationTitle.MasterBanker2;
            if (reputation < L12)
                return BankReputationTitle.MasterBanker3;
            if (reputation < L13)
                return BankReputationTitle.EliteBanker1;
            if (reputation < L14)
                return BankReputationTitle.EliteBanker2;
            if (reputation < L15)
                return BankReputationTitle.EliteBanker3;
            return BankReputationTitle.GlobalBanker;
        }
    }
}
