using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using game_Simulation.Entities;
using game_Simulation.Enums;
using game_Simulation.Entities.Server;

namespace game_Simulation
{
    public delegate void RemoveFromListDelegate(int listID);
    public partial class Sim_View : Form
    {
        Bank _bank;
        int _clientNo;
        Random random;
        RemoveFromListDelegate UpdateFromTeller;
        

        internal Bank Bank
        {
           get { return _bank; }
           set { _bank = value; }
        }
        public int ActiveQueue
        {
            get;
            set;
        }
        public int ClientNo
        {
            get { return _clientNo; }
            private set { _clientNo = value; }
        }

        public Sim_View() 
        {
            Bank = new Bank();
            UpdateFromTeller = new RemoveFromListDelegate(RemoveFromList);
            Bank.RemoveClient = new UpdateClientDelegate(RemoveClient);
            Bank.AddClient = new UpdateClientDelegate(SetActiveQueue);
            random = new Random();
            InitializeComponent();
            client_Clock.Interval /= Calculations.BankCalculations.GameSpeedMultiplier;
            clock.Interval /= Calculations.BankCalculations.GameSpeedMultiplier;
        }
        public void SetActiveQueue(int ID)
        {
            ActiveQueue = ID;
        }
        public void RemoveClient(int listID)
        {
            if (InvokeRequired)
                Invoke(UpdateFromTeller, new object[] { listID });
            else
                RemoveFromList(listID);
        }
        public void RemoveFromList(int listNumber)
        {
            ListView activeList = ChooseList(listNumber);
            activeList.Items.RemoveAt(0);
        }
        private void clock_Tick(object sender, EventArgs e)
        {
            clock_Time();
        }
        private void teller_Clock_Tick(object sender, EventArgs e)
        {
           
        }
        private void clock_Time() 
        {
            Structs.BankInfo info = Bank.GetInfo();
            capital_Money_lbl.Text = info.Money.ToString();
            title_Holder_Label.Text = info.Title;
            twithdrawn_Holder_Label.Text = info.TotalWithdraw.ToString();
            tdeposited_Holder_Label.Text = info.TotalDeposit.ToString();
            served_Holder_Label.Text = info.Served.ToString();
            repu_Label.Text = info.Reputation.ToString();

            min.Value++;
            if (min.Value == 59) 
            {
                hour.Value++;
                min.Value = 0;
            }
            else if (hour.Value == 24)
            {
                hour.Value = 0;
                days_NumericUpDown.Value++;
                StopGame(false);
                MessageBox.Show("You gained: " + Bank.ProcessLoans() + " from loans", " Loans Report");
                StartGame();
            }
        }
        private void clock_Start_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void clock_Stop_Click(object sender, EventArgs e)
        {
            StopGame(false);
        }
        private void btn_options_Click(object sender, EventArgs e)
        {
           new Sim_Options(clock,teller_Clock,client_Clock).Show();
        }
        private void client_Clock_Tick(object sender, EventArgs e)
        {
            clientSelection();
        }
        private void clientSelection()
        {
            double _clientProb = (Bank.CustomerFlowRate * Calculations.BankCalculations.GameSpeedMultiplier) * (((double)client_Clock.Interval) / 1000);
            if (_clientProb > random.NextDouble())
            {
                int prob = random.Next(10);
                game_Simulation.Enums.TransactionRequestType requestType;
                int money = 0;
                if (prob > 2 && Bank.TotalWithdraw + Calculations.BankCalculations.WithdrawalAllowance < Bank.TotalDeposit)
                {
                    money = Calculations.BankCalculations.GetWithDrawAmount();
                    requestType = Enums.TransactionRequestType.WithDrawal;
                }
                else
                {
                    money = Calculations.BankCalculations.GetDepositAmount();
                    requestType = Enums.TransactionRequestType.Deposit;
                }
                Client client = new Client("" , money, requestType);
                if (Bank.EnqueueClient(client))
                {
                    ListView activeList = ChooseList(ActiveQueue);
                    client.Name = "C" + (++ClientNo);
                    addClient(activeList, client);
                }
                if (requestType == Enums.TransactionRequestType.Deposit)
                    DepositLabel.Text = (Int32.Parse(DepositLabel.Text) + 1).ToString();
                else
                    W_lbl_no.Text = (Int32.Parse(W_lbl_no.Text) + 1).ToString();
            }
            if(Calculations.BankCalculations.LoanProbability * Calculations.BankCalculations.GameSpeedMultiplier > random.NextDouble())
            {
                int bankMoney = Bank.Capital;
                LoanLevel loanLevel = 0;
                if (bankMoney >= 110000)
                    loanLevel = LoanLevel.Category5Loan;
                else if (bankMoney >= 55000)
                    loanLevel = LoanLevel.Category4Loan;
                else if (bankMoney >= 30000)
                    loanLevel = LoanLevel.Category3Loan;
                else if (bankMoney >= 12000)
                    loanLevel = LoanLevel.Category2Loan;
                else if (bankMoney >= 7000)
                    loanLevel = LoanLevel.Category1Loan;
                if(loanLevel != 0)
                {
                    loanLevel = (LoanLevel)random.Next(1, (int)loanLevel + 1);
                    Loan loan = new Loan(0, loanLevel);
                    StopGame(false);
                    DialogResult dialogResult = MessageBox.Show(loan.Display(), "Loan Request", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        if (!Bank.AddLoan(loan))
                            MessageBox.Show("Sorry but you have already issued max amount of loans");
                    StartGame();
                }
            }
        }
        private void addClient(ListView listview, Client client)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = client;
            item.Text = client.ToString();
            listview.Items.Add(item);
        }
        ListView ChooseList(int id)
        {
            switch (id)
            {
                case 2: return listView2;
                case 3: return listView3; 
                case 4: return listView4;
                case 5: return listView5;
                case 6: return listView6;
                case 7: return listView7;
                case 1:
                default: return listView1;
            }
        }
        void StopGame(bool kill)
        {
            clock.Enabled = false;
            teller_Clock.Enabled = false;
            client_Clock.Enabled = false;
            Bank.StopTransactions(kill);
        }
        void StartGame()
        {
            clock.Enabled = true;
            teller_Clock.Enabled = true;
            client_Clock.Enabled = true;
            Bank.StartTransactions();
        }

        private void tellersComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            tellers_ComboBox.Items.Clear();
            foreach(BaseServer bs in Bank.Servers)
            {
                if(bs != null)
                    tellers_ComboBox.Items.Add(bs);
            }
        }

        private void tellers_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTellerInfo();
        }

        private void tellerUpgrade_Button_Click(object sender, EventArgs e)
        {
            if (tellers_ComboBox.SelectedItem is Teller)
                if(!Bank.UpgradeTeller((Teller)tellers_ComboBox.SelectedItem))
                    MessageBox.Show("Not enough money");
                else
                    updateTellerInfo();
        }
        private void updateTellerInfo()
        {
            if (tellers_ComboBox.SelectedItem is Teller)
                tellers_Info_Label.Text = String.Format("Info: Level({0}) \n ID({1})", ((Teller)tellers_ComboBox.SelectedItem).Level, ((Teller)tellers_ComboBox.SelectedItem).ID);
            else
                tellers_Info_Label.Text = String.Format("Info: ID({0})", ((BaseServer)tellers_ComboBox.SelectedItem).ID);
            tellerUpgrade_Button.Text = "Upgrade";
        }

        private void buyTeller_button_Click(object sender, EventArgs e)
        {
            if (!Bank.BuyTeller())
                MessageBox.Show("Not enough Money or already maxed");
        }

        private void buyATM_button_Click(object sender, EventArgs e)
        {
            if (!Bank.BuyATM())
                MessageBox.Show("Not enough Money or already maxed");
        }

        private void buyOB_button_Click(object sender, EventArgs e)
        {
            if (!Bank.BuyOB())
                MessageBox.Show("Not enough Money or already maxed");
        }

        private void Sim_View_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopGame(true);
        }
    }
}
