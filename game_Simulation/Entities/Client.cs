using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game_Simulation.Enums;

namespace game_Simulation.Entities
{
    
    public class Client 
    {
        int _money;
        String _name;
        TransactionRequestType _request;
        public Client(String name, int money, TransactionRequestType request)
        {
            this.Name = name;
            this.Money = money;
            this.Request = request;
        }

        public int Money
        {
            get
            {
                return _money;
            }

            private set
            {
                _money = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        internal TransactionRequestType Request
        {
            get
            {
                return _request;
            }

            private set
            {
                _request = value;
            }
        }
        public override string ToString()
        {
            return Name + " "  + (char)Request + Money + " ";
        }
    }
}
