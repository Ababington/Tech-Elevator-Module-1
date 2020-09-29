namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }
        public CheckingAccount(string AccountHolder, string AccountName) : base(AccountHolder, AccountName)
        {

        }
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw > -100M)
            {
                base.Withdraw(amountToWithdraw);

                if (Balance - amountToWithdraw < 0)
                {
                    base.Withdraw(10M);
                }
            }
            return Balance;
        }

    }
}
