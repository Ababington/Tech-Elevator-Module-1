namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }
        public SavingsAccount(string AccountHolder, string AccountName) : base(AccountHolder, AccountName)
        {

        }
        public override decimal Withdraw(decimal amountToWithdraw)
        {
           
            if (amountToWithdraw > Balance)
            {
                return Balance;
            }
            else if (Balance - amountToWithdraw >= 2M)
            {
                base.Withdraw(amountToWithdraw);

                if (Balance < 150M)
                {
                    base.Withdraw(2M);
                }
                        
            }
            return Balance;
        }
    }
}
