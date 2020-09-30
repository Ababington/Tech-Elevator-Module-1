using System.Reflection.Metadata.Ecma335;

namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = 0;
        }
        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public decimal Deposit(decimal amountToDeposit) // Adds to current balance and returns new balance to Bank Account
        {
             Balance += amountToDeposit;
            {
                return Balance;
            }
        }
        public virtual decimal Withdraw(decimal amountToWithdraw) // Subtracts from current balance and returns new balance to Bank Account
        {
             Balance -= amountToWithdraw;
            {
                return Balance;
            }
        }
    }
}
