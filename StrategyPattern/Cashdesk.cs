using System;

namespace StrategyPattern
{
    public class Cashdesk : Seller
    {
        public override void Sell(decimal price, Passenger passengerData)
        {
            //implementations for example,
            //ValidatePrice()
            //ProcessSell()

            Console.WriteLine($"Successful sale from Cashdesk.\nBuyer : {passengerData.Name} {passengerData.LastName}\nPrice : {price}\n");
        }
    }
}
