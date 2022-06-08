using System;

namespace CleanCodeExamples
{
    public class PaperBoy
    {
        public void DeliverMagazine(decimal costOfMagazine, Customer customer)
        {
            decimal payment = customer.GetPayment(costOfMagazine);

            if (payment == costOfMagazine)
                Console.WriteLine("Thank you. Have a nice day.");
            else
                Console.WriteLine("Okay, I'll come later.");
        }
    }
}
