using System;

namespace CleanCodeExamples
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer("Serdar", "Sari");

            PaperBoy paperBoy = new PaperBoy();

            paperBoy.DeliverMagazine(40, cust);
            paperBoy.DeliverMagazine(25, cust);
            paperBoy.DeliverMagazine(35, cust);
            paperBoy.DeliverMagazine(10, cust);
            paperBoy.DeliverMagazine(15, cust);

            Console.ReadLine();
        }
    }
}
