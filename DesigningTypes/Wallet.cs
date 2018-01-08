using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningTypes
{
    //Walllet class could have been private
    public class Wallet
    {
        public decimal MoneyAmount { get; private set; }

        public Wallet(decimal moneyAmount)
        {
            MoneyAmount = moneyAmount;
        }
        
        public void AddMoney(decimal amount)
        {
            MoneyAmount += amount;
        }

        public void WithdrawAmount(decimal amount)
        {
            MoneyAmount -= amount;
        }
    }
}
