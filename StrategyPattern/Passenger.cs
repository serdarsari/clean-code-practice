namespace StrategyPattern
{
    public class Passenger
    {
        public string Name { get; }
        public string LastName { get; }

        public Passenger(string firstName, string lastName)
        {
            Name = firstName;
            LastName = lastName;
        }
    }
}
