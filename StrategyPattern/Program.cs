using System;

namespace StrategyPattern
{

    public class Program
    {
        static void Main(string[] args)
        {
            Terminal terminal;
            terminal = new Terminal(new Cashdesk());
            terminal.SellTicket(10, new Passenger("Serdar", "Sari"));


            terminal = new Terminal(new Pos());
            terminal.SellTicket(20, new Passenger("Jack", "Sparrow"));

            Console.ReadKey();
        }
    }
}
