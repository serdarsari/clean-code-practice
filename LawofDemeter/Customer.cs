namespace CleanCodeExamples
{
    public class Customer
    {
        public string FirstName { get; }
        public string LastName { get; }
        private readonly Wallet _wallet;

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            _wallet = new Wallet(100);
        }

        public decimal GetPayment(decimal amount)
        {
            if (_wallet.MoneyAmount >= amount)
            {
                _wallet.WithdrawMoney(amount);
                return amount;
            }
            return 0;
        }
    }
}
