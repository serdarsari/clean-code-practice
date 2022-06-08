using System;

namespace StrategyPattern
{
    public class Pos : Seller
    {
        public override void Sell(decimal price, Passenger passengerData)
        {
            //implementations for example,
            //CanSell()
            //CheckDevices()

            Console.WriteLine($"Successful sale from Pos.\nBuyer : {passengerData.Name} {passengerData.LastName}\nPrice : {price}\n");
        }
    }
}
