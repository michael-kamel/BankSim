using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game_Simulation.Enums;

namespace game_Simulation.Entities
{
    public class Loan
    {
        int _loanAmount,
            _installementAmount,
            _insuranceAmount,
            _loanDuration;
        LoanTrustedLevel _trustLevel;
        public Loan(int amount, int duration, int insurance)
        {
            LoanAmount = amount;
            LoanDuration = duration;
            InstallementsCount = duration;
            RemainingInstallements = duration;
            InsuranceAmount = insurance;
            InstallementAmount = Calculations.BankCalculations.CalculateMonthlyLoanPayment(LoanAmount, Calculations.BankCalculations.DefaultLoanInterest, LoanDuration);
        }
        public Loan(int insurance, LoanLevel loanLevel) : this(Calculations.BankCalculations.CalculateLoanAmount(loanLevel), (int)loanLevel, insurance) { }
        public int LoanAmount
        {
            get { return _loanAmount; }
            private set { _loanAmount = value; }
        }
        public int InstallementsCount
        {
            get;
            private set;
        }
        public int RemainingInstallements
        {
            get;
            private set;
        }
        public int InstallementAmount
        {
            get { return _installementAmount; }
            private set { _installementAmount = value; }
        }
        public int InsuranceAmount
        {
            get { return _insuranceAmount; }
            private set { _insuranceAmount = value; }
        }
        public int LoanDuration
        {
            get { return _loanDuration; }
            private set { _loanDuration = value; }
        }
        public LoanTrustedLevel TrustLevel
        {
            get { return _trustLevel; }
            private set { _trustLevel = value; }
        }

        public int GetInstallement()
        {
            RemainingInstallements--;
            return InstallementAmount;
        }

        public string Display()
        {
            return "A client wants a loan of: " + LoanAmount + " with an Insurance Amount of " + InsuranceAmount + "\n" + "Will be repayed on a duration of " + LoanDuration + " days";
        }
    }
}
