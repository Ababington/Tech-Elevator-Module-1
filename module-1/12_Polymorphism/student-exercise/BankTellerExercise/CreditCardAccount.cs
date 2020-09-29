using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CreditCardAccount : IAccountable
    {
       
        public string AccountHolderName { get; }
        public string AccountNumber { get; }
        public int Debt
        {
            get
            {
                return 0 - Balance;
            }
        }
        public int Balance { get; set; }

        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
        }
        public int Pay(int amountToPay)
        {
            Balance +=  amountToPay;
            return Balance;
        }

        public int Charge(int amountToCharge)
        {
            Balance -= amountToCharge;
            return Balance;
        }
    }

}
