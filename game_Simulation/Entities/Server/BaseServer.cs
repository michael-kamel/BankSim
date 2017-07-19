using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Threading;

namespace game_Simulation.Entities.Server
{
    public abstract class BaseServer
    {
        int _responseTime;
        ConcurrentQueue<Client> _queue;
        bool _busy;
        Bank _bank;
        int _ID;
        int _maxQueueLength;
        string _name;
        protected Thread TransactionsThread;
        protected ManualResetEvent ResetEvent = new ManualResetEvent(true);

        public BaseServer()
        {
            _queue = new ConcurrentQueue<Client>();
        }

        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }
        public int MaxQueueLength
        {
            get { return _maxQueueLength; }
            protected set { _maxQueueLength = value; }
        }
        public Bank Bank
        {
            get { return _bank; }
            set { _bank = value; }
        }
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        internal ConcurrentQueue<Client> Queue
        {
            get { return _queue; }
            set { _queue = value; }
        }
        public bool IsBusy
        {
            get { return _busy; }
            set { _busy = value; }
        }
        [DefaultValueAttribute(10000)]
        public int ResponseTime
        {
            get { return _responseTime; }
            protected set { _responseTime = value; }
        }

        public Transaction ProcessTransaction()
        {
            if (IsBusy)
                return new Transaction(-1, Enums.TransactionRequestType.Invalid);
            IsBusy = true;

            Client c;
            bool ret = false;
            int money = 0;
            Enums.TransactionRequestType type;

            Thread.Sleep(ResponseTime / Calculations.BankCalculations.GameSpeedMultiplier);
            ResetEvent.WaitOne();
            if (Queue.TryDequeue(out c))
                ret = true;
            if (ret)
            {
                money = c.Money;
                type = c.Request;
            }
            else
                type = Enums.TransactionRequestType.Invalid;

            IsBusy = false;
            return new Transaction(money, type);
        }

        public void StopTransactions()
        {
            TransactionsThread.Abort();
        }
        public void PauseTransactions()
        {
            ResetEvent.Reset();
        }
        public void StartTransactions()
        {
            TransactionsThread = new Thread(() => _startTransactions());
            TransactionsThread.Start();
            ResetEvent.Set();
        }
        private void _startTransactions()
        {
            while (true)
            {
                ResetEvent.WaitOne();
                if (Queue.Count == 0)
                {
                    Thread.Sleep(Calculations.BankCalculations.ServerMinumumDelayInterval);
                    continue;
                }
                Transaction res = ProcessTransaction();
                if (res.TransactionType == Enums.TransactionRequestType.Deposit)
                    Bank.Deposit(res.Amount, ID);
                else if (res.TransactionType == Enums.TransactionRequestType.WithDrawal)
                    Bank.Withdraw(res.Amount, ID);
            }
        }
        public override string ToString()
        {
            return Name + "(" + ID + ")";
        }
    }
}
