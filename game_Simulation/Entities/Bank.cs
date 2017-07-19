using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Threading;
using game_Simulation.Entities.Server;
using game_Simulation.Structs;

namespace game_Simulation.Entities
{
    public delegate void UpdateClientDelegate(int listNumber);
    public class Bank 
    {
        int _capital,
            _totalWithdraw,
            _totalDeposit,
            _totalServed;
        double _effectiveReputation;
        Queue<Client> _clients;
        BaseServer[] _servers;
        BaseServer _mostAvailable;
        bool _working;
        List<Loan> _loans;
        public UpdateClientDelegate RemoveClient;
        public UpdateClientDelegate AddClient;

        public Bank() 
        {
            Capital = 0;
            EffectiveReputation = 200.0;
            Clients = new Queue<Client>();
            Servers = new BaseServer[7];
            CreaterNewTeller();
            MostAvailable = Servers[0];
            Loans = new List<Loan>();
        }

        public List<Loan> Loans
        {
            get { return _loans; }
            set { _loans = value; }
        }
        public int WithdrawCount
        {
            get;
            set;
        }
        public int DepositCount
        {
            get;
            set;
        }
        public double CustomerFlowRate
        {
            get
            {
                return Calculations.BankCalculations.CalculateCustomerFlowRate(EffectiveReputation);
            }
        }
        public int TotalServed
        {
            get { return _totalServed; }
            set 
            {
                if (value >= 0)
                {
                    _totalServed = value;
                    calculateReputation();
                }
            }
        }
        public bool IsWorking
        {
            get { return _working; }
            private set { _working = value; }
        }
        public BaseServer MostAvailable
        {
            get { return _mostAvailable; }
            private set { _mostAvailable = value; }
        }
        public BaseServer[] Servers
        {
            get { return _servers; }
            private set { _servers = value; }
        }
        [DefaultValue(200)]
        public double EffectiveReputation
        {
            get { return _effectiveReputation; }
            private set 
            {
                if (value > 10000 || value < 200)
                    return;
                _effectiveReputation = value;
            }
        }
        public string Reputation
        {
            get
            {
                return Enums.BankTitleExtensions.GetBankTitle(EffectiveReputation);
            }
        }
        internal Queue<Client> Clients
        {
            get { return _clients; }
            private set { _clients = value; }
        }
        public int TotalWithdraw
        {
            get { return _totalWithdraw; }
            private set { _totalWithdraw = value; }
        }
        public int TotalDeposit
        {
            get { return _totalDeposit; }
            private set { _totalDeposit = value; }
        }
        public int Capital
        {
            get { return _capital; }
            set { _capital = value; }
        }

        public Boolean CreaterNewTeller()
        {
            for (int i = 0; i < Calculations.BankCalculations.MaxTellers; i++)
            {
                if (Servers[i] == null)
                {
                    Teller _teller = new Teller();
                    _teller.Bank = this;
                    _teller.ID = i + 1;
                    Servers[i] = _teller;
                    return true;
                }
            }
            return false;
        }
        public bool BuyTeller()
        {
            if(Capital >= Calculations.BankCalculations.TellerPrice)
            {
                return CreaterNewTeller();
            }
            return false;
        }
        public bool BuyATM()
        {
            if (Capital >= Calculations.BankCalculations.ATMPrice)
            {
               return CreateATMs();
            }
            return false;
        }
        public bool BuyOB()
        {
            if (Capital >= Calculations.BankCalculations.OBPrice)
            {
                return CreateOB();
            }
            return false;
        }
        public bool CreateOB()
        {
            if(Servers[6] == null)
            {
                OnlineBanking _ob = new OnlineBanking();
                _ob.Bank = this;
                Servers[6] = _ob;
                return true;
            }
            return false;
        }
        public bool CreateATMs()
        {
            if (Servers[5] == null)
            {
                ATM _atms = new ATM();
                _atms.Bank = this;
                Servers[5] = _atms;
                return true;
            }
            return false;
        }
        public void Deposit(int amount, int tellerID)
        {
            Capital += amount;
            TotalDeposit += amount;
            updateAfterTransaction(tellerID);
            //Console.WriteLine("Deposit: " + ++DepositCount);
        }
        public void Withdraw(int amount, int tellerID)
        {
            Capital -= amount;
            TotalWithdraw += amount;
            updateAfterTransaction(tellerID);
           // Console.WriteLine("Withdraw: " + ++WithdrawCount);
        }
        void updateAfterTransaction(int tellerID)
        {
            TotalServed++;
            RemoveClient(tellerID);
        }
        public bool EnqueueClient(Client c)
        {
            if (MostAvailable.Queue.Count < MostAvailable.MaxQueueLength)
            {
                MostAvailable.Queue.Enqueue(c);
                AddClient(MostAvailable.ID);
                foreach (BaseServer bs in Servers)
                    if (bs != null && bs.MaxQueueLength - bs.Queue.Count > MostAvailable.MaxQueueLength - MostAvailable.Queue.Count)
                        MostAvailable = bs;
                return true;
            }
            else
                TotalServed--;
            return false;
        }
        public void StartTransactions()
        {
            if (IsWorking)
                return;
            IsWorking = true;
            foreach (BaseServer server in Servers)
                if(server != null)
                    server.StartTransactions();
        }
        public void StopTransactions(bool kill)
        {
            if (!IsWorking)
                return;
            IsWorking = false;
            foreach (BaseServer server in Servers)
                if (server != null)
                    if (!kill)
                        server.PauseTransactions();
                    else
                        server.StopTransactions();
        }
        void calculateReputation()
        {
            EffectiveReputation = Calculations.BankCalculations.CalculateReputation(TotalServed);
            //Console.WriteLine(Calculations.BankCalculations.CalculateReputation(TotalServed) + " REPU");
        }
        public BankInfo GetInfo()
        {
            return new BankInfo(Capital, TotalWithdraw, TotalDeposit, TotalServed, Reputation, (int)EffectiveReputation);
        }
        public bool AddLoan(Loan loan)
        {
            if (Loans.Count >= Calculations.BankCalculations.MaxLoans)
                return false;
            Loans.Add(loan);
            Capital -= loan.LoanAmount;
            return true;
        }
        public int ProcessLoans()
        {
            int loanInstallementsGained = 0;
          
            foreach (Loan loan in Loans)
            {
                if (loan.RemainingInstallements > 0)
                    loanInstallementsGained += loan.GetInstallement();
            }
            Loans.RemoveAll(loan => loan.RemainingInstallements <= 0);
            Capital += loanInstallementsGained;
            return loanInstallementsGained;
        }
        public bool UpgradeTeller(Teller teller)
        {
            int price = 0;
            if (Servers.Contains(teller))
            {
                switch (teller.Level)
                {
                    case 1: price = Calculations.BankCalculations.TellerL2Price; break;
                    case 2: price = Calculations.BankCalculations.TellerL3Price; ; break;
                    case 3: price = Calculations.BankCalculations.TellerL4Price; ; break;
                    case 4: price = Calculations.BankCalculations.TellerL5Price; ; break;
                }
                if (Capital >= price)
                {
                    Capital -= price;
                    teller.Level++;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
