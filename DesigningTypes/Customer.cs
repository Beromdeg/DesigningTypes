using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//demo of Law of Demeter
namespace DesigningTypes
{
    public class Customer{

        public Customer(string firstName, string lastName){
            FirstName = firstName;
            lastName = lastName;
            Wallet = new Wallet(1000m);
        }

        public string FirstName { get; }
        public string LastName { get; }
        // Demo voilation of LoD principle
        //public Wallet Wallet { get; }

        //not voilating LoD principle
        private readonly Wallet Wallet;
        public decimal GetPayment(decimal amount)
        {
            if (Wallet.MoneyAmount >= amount)
            {
                Wallet.WithdrawAmount(amount);
                return amount;
            }
            return 0; //exit
        }
    }

    public class PizzaBoy
    {
        public void DeliverPizza(decimal costOfPizza, Customer customer)
        {
        // *** Voilation of LoD principle giving pizzaboy class accesss to customer wallet ***//
            //Wallet w = customer.Wallet;
            //if(w.MoneyAmount > costOfPizza)
            //{
            //    w.WithdrawMoney(costOfPizza);
            //}
            //else
            //{
            //    //cant buy
            //}

        //*** Following LoD, we isolate PizzaBoy from Wallet****// 
            decimal payment = customer.GetPayment(costOfPizza);
            if(payment == costOfPizza)
            {
                //Thank you and exit
            }
            else
            {
                //Cant buy
            }
        }
    }
}
