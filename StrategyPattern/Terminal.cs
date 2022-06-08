namespace StrategyPattern
{
    public class Terminal
    {
        private readonly Seller _seller;

        public Terminal(Seller seller)
        {
            _seller = seller;
        }

        public void SellTicket(decimal price, Passenger passengerData)
        {
            _seller.Sell(price, passengerData);
        }
    }
}
